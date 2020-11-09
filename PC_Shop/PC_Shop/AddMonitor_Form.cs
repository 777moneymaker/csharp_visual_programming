using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Shop {
    public partial class AddMonitor_Form : Form {

        MainWindow mainWindow;

        public AddMonitor_Form(MainWindow main_window) {
            InitializeComponent();
            this.mainWindow = main_window;
        }

        private void ModelTextBox_TextChanged(object sender, EventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ModelTextBox.Text, @"^[a-zA-Z0-9 ]*$")) {
                MessageBox.Show("This textbox accepts only alphabetical characters and numbers!");
                ModelTextBox.ResetText();
            }
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(PriceTextBox.Text, @"^[0-9]*[.,]?[0-9]*$")) {
                MessageBox.Show("This textbox accepts only integers or decimal numbers!");
                PriceTextBox.ResetText();
            }
        }

        private void AddMonitorButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0 || this.PriceTextBox.Text.Length == 0) {
                MessageBox.Show("Data is not full. Lack of model or price!");
                return;
            }
            var model = this.ModelTextBox.Text;
            var price = double.Parse(this.PriceTextBox.Text.Replace('.', ','));
            this.mainWindow.MONITORS.Add(new Monitor(model, price));
            MessageBox.Show("New monitor added!");
            this.ModelTextBox.ResetText();
            this.PriceTextBox.ResetText();
        }

        private void DeleteMonitorButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0) {
                MessageBox.Show("Can't delete model with no name!");
                return;
            }
            var model = this.ModelTextBox.Text;
            foreach (var monitor in this.mainWindow.MONITORS) {
                if (monitor.MODEL == model) {
                    this.mainWindow.MONITORS.Remove(monitor);
                    MessageBox.Show(string.Format("Monitor: {0} has been deleted!", model));
                    return;
                }
            }
            MessageBox.Show(string.Format("Monitor {0} is not present! Can't be deleted!", model));
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
