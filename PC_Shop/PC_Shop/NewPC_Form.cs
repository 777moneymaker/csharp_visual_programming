using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PC_Shop {
    public partial class NewPC_Form : Form {

        // List o all possible CPUs to choose from.
        public List<CPU> CPUs { get; set; }

        // Dictionary for better object handling while using radioBoxes.
        public Dictionary<string, Disk> Disks { get; set; } = new Dictionary<string, Disk>();

        // Ref to base window.
        private readonly MainWindow mainWindow;
        public NewPC_Form(MainWindow main_window) {
            InitializeComponent();
            this.CPUs = main_window.CPUs;
            this.mainWindow = main_window;

            // Whenever some component is check - try to calculater final price.
            this.DiskPriceTextBox.TextChanged += SumPrice_Ready;
            this.CPUPriceTextBox.TextChanged += SumPrice_Ready;

            // Add some CPUs at init.
            this.updateCPUS();
            // Hard code disks to dict.
            this.Disks.Add("240 GB SSD", new Disk("240 GB SSD", 119.99));
            this.Disks.Add("500 GB SATA", new Disk("500 GB SATA", 89.99));
            this.Disks.Add("1000 GB SATA", new Disk("1000 GB SATA", 129.99));
        }

        // Updates the cpus in the CPUs comboBox.
        public void updateCPUS() {
            foreach (var cpu in this.mainWindow.CPUs) {
                if (!this.CPUsComboBox.Items.Contains(cpu))
                    this.CPUsComboBox.Items.Add(cpu);
            }
        }

        // Event when final cost changes.
        private void SumPriceTextBox_TextChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        // Event when CPU is selected.
        private void CPUsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            CPU selected = (CPU)this.CPUsComboBox.SelectedItem;
            this.CPUPriceTextBox.Text = selected.Price.ToString();
        }

        // START: ComboGroupComment
        // Events when one of radioButtons is selected
        private void DiskRadio1_CheckedChanged(object sender, EventArgs e) {
            var button = (RadioButton)sender;
            if (button.Checked) {
                this.DiskPriceTextBox.Text = this.Disks[button.Text].Price.ToString();
            }
        }

        private void DiskRadio2_CheckedChanged(object sender, EventArgs e) {
            var button = (RadioButton)sender;
            if (button.Checked) {
                this.DiskPriceTextBox.Text = this.Disks[button.Text].Price.ToString();
            }
        }

        private void DiskRadio3_CheckedChanged(object sender, EventArgs e) {
            var button = (RadioButton)sender;
            if (button.Checked) {
                this.DiskPriceTextBox.Text = this.Disks[button.Text].Price.ToString();
            }
        }
        // END: ComboGroupComment

        // Whenever some component is check - try to calculater final price.
        private void SumPrice_Ready(object sender, EventArgs e) {
            double? cpu_price;
            double? disk_price;

            // If both CPU and Disk are selected.
            if (this.CPUPriceTextBox.Text.Length != 0 && this.DiskPriceTextBox.Text.Length != 0) {
                try {
                    cpu_price = double.Parse(this.CPUPriceTextBox.Text);
                    disk_price = double.Parse(this.DiskPriceTextBox.Text);
                } catch (FormatException ex) {
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

        // Close form on CancelButton click.
        private void CancelPCButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Accept selected items on AcceptButton click.
        private void AcceptPCButton_Click(object sender, EventArgs e) {
            // If CPU not selected.
            if (this.CPUsComboBox.SelectedItem is null) {
                MessageBox.Show("CPU is not selected!");
                return;
            }

            // If Disk not selected.
            try {
                string selected_r = this.DiskRadiosGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                this.mainWindow.Disk = (Disk)this.Disks[selected_r];
            } catch {
                MessageBox.Show("Disk is not selected!");
                return;
            }

            // Try to get summed price.
            double sum = 0;
            try {
                sum += double.Parse(this.SumPriceTextBox.Text);
            } catch (FormatException ex) {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(ex.Message);
            }

            // Final assignments
            this.mainWindow.CPU = (CPU)this.CPUsComboBox.SelectedItem;
            this.mainWindow.Price += sum;
            this.mainWindow.updatePrice();
            this.Close();
        }
    }
}
