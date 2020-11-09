using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PC_Shop {
    public partial class MainWindow : Form {

        private double current_price = 0;
        private string str_current_price = "";

        private List<CPU> cpus = new List<CPU>() {
            new CPU("Intel i5-9600K", 1200.0),
            new CPU("Intel i7-10600K", 1700.5),
            new CPU("AMD Ryzen 5 3600", 999.99),
        };

        private List<Monitor> monitors = new List<Monitor>() {
            new Monitor("BenQ EX2780", 1599.99),
            new Monitor("Dell UltraSharp 27", 1799.99),
            new Monitor("HP Pavilion 32", 1949.99),
            new Monitor("Asus ROG Swift", 2199.99),
        };

        private CPU cpu;
        private Disk disk;
        private Monitor monitor;

        public MainWindow() {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.SaveToFile);
            this.Load += new EventHandler(this.ReadFromFile);
        }

        public List<CPU> CPUS {
            get => this.cpus;
            set => this.cpus = value;
        }

        public List<Monitor> MONITORS {
            get => this.monitors;
            set => this.monitors = value;
        }

        public CPU CPU {
            get => this.cpu;
            set => this.cpu = value;
        }
        public Disk DISK {
            get => this.disk;
            set => this.disk = value;
        }
        public Monitor MONITOR {
            get => this.monitor;
            set => this.monitor = value;
        }

        public double PRICE {
            get => this.current_price;
            set => this.current_price = value;
        }
        public string STR_PRICE {
            get => this.str_current_price;
            set => this.str_current_price = value;
        }

        public void updatePrice() {
            this.PriceTextBox.Text = this.str_current_price;
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

        private void ResetButton_Click(object sender, EventArgs e) {
            this.cpu = null;
            this.disk = null;
            this.monitor = null;
            this.PRICE = 0;
            this.STR_PRICE = "0";
            this.updatePrice();
        }

        private void SaveToFile(object sender, EventArgs e) {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Serial_Items));
            var subReq = new Serial_Items(this.cpus, this.monitors);

            using (var sww = new StringWriter()) {
                using (XmlWriter writer = XmlWriter.Create("data.xml")) {
                    xsSubmit.Serialize(writer, subReq);
                }
            }
        }

        private void ReadFromFile(object sender, EventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(Serial_Items));
            try {
                using (var reader = XmlReader.Create("data.xml")) {
                    Serial_Items items = (Serial_Items)serializer.Deserialize(reader);
                    this.cpus = items.cpus;
                    this.monitors = items.monitors;
                }
            } catch (FileNotFoundException) {

            }
            
        }
    }
}
