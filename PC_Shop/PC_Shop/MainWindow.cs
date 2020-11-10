using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PC_Shop {
    public partial class MainWindow : Form {

        public double Price { get; set; } = default;
        public List<CPU> CPUs { get; set; }
        public List<Monitor> Monitors { get; set; }

        public CPU CPU { get; set; }
        public Disk Disk { get; set; }
        public Monitor Monitor { get; set; }

        public MainWindow() {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.SaveToFile);
            this.Load += new EventHandler(this.ReadFromFile);

            // Some default CPUs at init.
            this.CPUs = new List<CPU>() {
                new CPU("Intel i5-9600K", 1200.0),
                new CPU("Intel i7-10600K", 1700.5),
                new CPU("AMD Ryzen 5 3600", 999.99),
            };
            // Some default Monitors at init.
            this.Monitors = new List<Monitor>() {
                new Monitor("BenQ EX2780", 1599.99),
                new Monitor("Dell UltraSharp 27", 1799.99),
                new Monitor("HP Pavilion 32", 1949.99),
                new Monitor("Asus ROG Swift", 2199.99),
            };
        }

        // Get current price, set on label.
        public void updatePrice() {
            this.PriceTextBox.Text = this.Price.ToString();
        }

        private void NewPCButton_Click(object sender, EventArgs e) {
            NewPC_Form n_pc = new NewPC_Form(this);
            n_pc.Show();
        }

        private void NewMonitorButton_Click(object sender, EventArgs e) {
            NewMonitor_Form n_monitor = new NewMonitor_Form(this);
            n_monitor.Show();
        }

        private void UpdateCPUButton_Click(object sender, EventArgs e) {
            AddCPU_Form add_cpu = new AddCPU_Form(this);
            add_cpu.Show();
        }

        private void UpdateMonitorButton_Click(object sender, EventArgs e) {
            AddMonitor_Form add_monitor = new AddMonitor_Form(this);
            add_monitor.Show();
        }

        // Reset price, reset chosen items.
        private void ResetButton_Click(object sender, EventArgs e) {
            this.CPU = default;
            this.Disk = default;
            this.Monitor = default;
            this.Price = default;
            this.updatePrice();
        }

        // Serialize to XML File.
        private void SaveToFile(object sender, EventArgs e) {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Serial_Items));
            Serial_Items subReq = new Serial_Items(this.CPUs, this.Monitors);

            using (var sww = new StringWriter()) {
                using (XmlWriter writer = XmlWriter.Create("data.xml")) {
                    xsSubmit.Serialize(writer, subReq);
                }
            }
        }
        // Deserialize from XML File.
        private void ReadFromFile(object sender, EventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(Serial_Items));
            try {
                using (var reader = XmlReader.Create("data.xml")) {
                    Serial_Items items = (Serial_Items)serializer.Deserialize(reader);
                    this.CPUs = items.CPUs;
                    this.Monitors = items.Monitors;
                }
            } catch (FileNotFoundException) { }

        }
    }
}
