using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PC_Shop {
    public partial class AddMonitor_Form : Form {

        // Ref to base window.
        private readonly MainWindow mainWindow;

        public AddMonitor_Form(MainWindow main_window) {
            InitializeComponent();
            this.mainWindow = main_window;
            // Add range of models for autocomplete.
            string[] models = main_window.Monitors.Select(s => s.Model).ToArray();
            this.ModelTextBox.AutoCompleteCustomSource.AddRange(models);
            this.ModelTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.ModelTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Test input text to be only numbers, letters and spaces.
        private void ModelTextBox_TextChanged(object sender, EventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ModelTextBox.Text, @"^[a-zA-Z0-9 ]*$")) {
                MessageBox.Show("This textbox accepts only alphabetical characters and numbers!");
                ModelTextBox.ResetText();
            }
        }

        // Test input text to be only ints or decimal numbers.
        private void PriceTextBox_TextChanged(object sender, EventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(PriceTextBox.Text, @"^[0-9]*[.,]?[0-9]*$")) {
                MessageBox.Show("This textbox accepts only integers or decimal numbers!");
                PriceTextBox.ResetText();
            }
        }

        // Add new monitor from given data.
        // Warn if wrong data.
        private void AddMonitorButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0 || this.PriceTextBox.Text.Length == 0) {
                MessageBox.Show("Data is not full. Lack of model or price!");
                return;
            }
            var model = this.ModelTextBox.Text;
            var price = double.Parse(this.PriceTextBox.Text.Replace('.', ','));
            this.mainWindow.Monitors.Add(new Monitor(model, price));

            MessageBox.Show("New monitor added!");

            this.ModelTextBox.AutoCompleteCustomSource.Add(model);
            this.ModelTextBox.ResetText();
            this.PriceTextBox.ResetText();
        }

        // Delete given monitor. No price needed.
        // Warn if bad model or no model in DB.
        private void DeleteMonitorButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0) {
                MessageBox.Show("Can't delete model with no name!");
                return;
            }
            var model = this.ModelTextBox.Text;
            foreach (var monitor in this.mainWindow.Monitors) {
                if (monitor.Model == model) {
                    this.mainWindow.Monitors.Remove(monitor);
                    this.ModelTextBox.AutoCompleteCustomSource.Remove(model);
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
