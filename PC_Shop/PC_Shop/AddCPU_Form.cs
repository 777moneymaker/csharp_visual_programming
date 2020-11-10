using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PC_Shop {
    public partial class AddCPU_Form : Form {

        // Ref to base window.
        private readonly MainWindow mainWindow;

        public AddCPU_Form(MainWindow main_window) {
            InitializeComponent();
            this.mainWindow = main_window;
            // Add range of models for autocomplete.
            string[] models = main_window.CPUs.Select(s => s.Model).ToArray();
            this.ModelTextBox.AutoCompleteCustomSource.AddRange(models);
            this.ModelTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.ModelTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Test input text to be only numbers, letters, spaces and dashes "-".
        private void ModelTextBox_TextChanged(object sender, EventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ModelTextBox.Text, @"^[a-zA-Z0-9 -]*$")) {
                MessageBox.Show("This textbox accepts only alphabetical characters and numbers!");
                ModelTextBox.ResetText();
            }
        }
        // Test input text to be only ints or decimals.
        private void PriceTextBox_TextChanged(object sender, EventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(PriceTextBox.Text, @"^[0-9]*[.,]?[0-9]*$")) {
                MessageBox.Show("This textbox accepts only integers or decimal numbers!");
                PriceTextBox.ResetText();
            }
        }

        // Add new CPU from given data.
        // Warn if wrong data.
        private void AddCPUButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0 || this.PriceTextBox.Text.Length == 0) {
                MessageBox.Show("Data is not full. Lack of model or price!");
                return;
            }
            var model = this.ModelTextBox.Text;
            var price = double.Parse(this.PriceTextBox.Text.Replace('.', ','));
            this.mainWindow.CPUs.Add(new CPU(model, price));
            MessageBox.Show("New CPU added!");
            this.ModelTextBox.AutoCompleteCustomSource.Add(model);
            this.ModelTextBox.ResetText();
            this.PriceTextBox.ResetText();
        }

        // Delete given CPU. No price needed.
        // Warn if bad model or no model in DB.
        private void DeleteCPUButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0) {
                MessageBox.Show("Can't delete model with no name!");
                return;
            }
            var model = this.ModelTextBox.Text;
            foreach (var cpu in this.mainWindow.CPUs.Where<CPU>(c => c.Model == model)) {
                this.mainWindow.CPUs.Remove(cpu);
                this.ModelTextBox.AutoCompleteCustomSource.Remove(model);
                MessageBox.Show(string.Format("CPU: {0} has been deleted!", model));
                return;
            }
            MessageBox.Show(string.Format("CPU {0} is not present! Can't be deleted!", model));
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
