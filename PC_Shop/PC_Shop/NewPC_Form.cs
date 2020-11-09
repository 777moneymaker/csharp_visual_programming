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

namespace PC_Shop {
    public partial class NewPC_Form : Form {

        public List<CPU> cpus_list;
        public Dictionary<string, Disk> disks = new Dictionary<string, Disk>();

        private MainWindow mainWindow;

        public NewPC_Form(MainWindow main_window) {
            InitializeComponent();
            this.cpus_list = main_window.CPUS;
            this.mainWindow = main_window;

            this.DiskPriceTextBox.TextChanged += SumPrice_Ready;
            this.CPUPriceTextBox.TextChanged += SumPrice_Ready;
            // Add some CPUs at init.
            this.updateCPUS();

            // Add disks to dict.
            this.disks.Add("240 GB SSD", new Disk("240 GB SSD", 119.99));
            this.disks.Add("500 GB SATA", new Disk("500 GB SATA", 89.99));
            this.disks.Add("1000 GB SATA", new Disk("1000 GB SATA", 129.99));
        }

        public void updateCPUS() {
            foreach (CPU cpu in this.mainWindow.CPUS) {
                if(!this.CPUsComboBox.Items.Contains(cpu))
                    this.CPUsComboBox.Items.Add(cpu);
            }
        }

        private void SumPriceTextBox_TextChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void CPUsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            CPU selected = (CPU)this.CPUsComboBox.SelectedItem;
            this.CPUPriceTextBox.Text = selected.PRICE.ToString();
        }

        private void DiskRadio1_CheckedChanged(object sender, EventArgs e) {
            var button = (RadioButton)sender;
            if (button.Checked) {
                this.DiskPriceTextBox.Text = this.disks[button.Text].PRICE.ToString();
            }
        }

        private void DiskRadio2_CheckedChanged(object sender, EventArgs e) {
            var button = (RadioButton)sender;
            if (button.Checked) {
                this.DiskPriceTextBox.Text = this.disks[button.Text].PRICE.ToString();
            }
        }

        private void DiskRadio3_CheckedChanged(object sender, EventArgs e) {
            var button = (RadioButton)sender;
            if (button.Checked) {
                this.DiskPriceTextBox.Text = this.disks[button.Text].PRICE.ToString();
            }
        }

        private void SumPrice_Ready(object sender, EventArgs e) {
            double? cpu_price;
            double? disk_price;

            if (this.CPUPriceTextBox.Text.Length != 0 && this.DiskPriceTextBox.Text.Length != 0) {
                try {
                    cpu_price = double.Parse(this.CPUPriceTextBox.Text);
                    disk_price = double.Parse(this.DiskPriceTextBox.Text);
                } catch(FormatException ex) {
                    cpu_price = 0;
                    disk_price = 0;

                    TextWriter errorWriter = Console.Error;
                    errorWriter.WriteLine(ex.Message);
                }
            } else {
                return;
            }

            this.SumPriceTextBox.Text = (cpu_price + disk_price).ToString();
        }

        private void CancelPCButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AcceptPCButton_Click(object sender, EventArgs e) {
            double sum;
            try {
                sum = double.Parse(this.SumPriceTextBox.Text);
            }catch(FormatException ex) {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(ex.Message);
                sum = 0;
            }

            this.mainWindow.PRICE += sum;

            if (this.mainWindow.STR_PRICE == "") {
                this.mainWindow.STR_PRICE = sum.ToString();
            } else {
                double current_sum = 0;
                try {
                    current_sum = double.Parse(this.mainWindow.STR_PRICE);
                    current_sum += sum;
                    this.mainWindow.STR_PRICE = current_sum.ToString();
                } catch (FormatException) {
                    this.mainWindow.STR_PRICE = "0";
                }
            }

            
            try { 
                string selected_r = this.DiskRadiosGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                this.mainWindow.DISK = this.disks[selected_r];
            } catch (NullReferenceException) {
                MessageBox.Show("Disk is not selected!");
                return;
            }

            
            if(this.CPUsComboBox.SelectedItem == null) {
                MessageBox.Show("CPU is not selected!");
                return;
            }

            this.mainWindow.CPU = (CPU)this.CPUsComboBox.SelectedItem;
            this.mainWindow.updatePrice();
            this.Close();
        }
    }
}
