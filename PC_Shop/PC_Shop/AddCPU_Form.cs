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
    public partial class AddCPU_Form : Form {

        MainWindow mainWindow;

        public AddCPU_Form(MainWindow main_window) {
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

        private void AddCPUButton_Click(object sender, EventArgs e) {
            if(this.ModelTextBox.Text.Length == 0 || this.PriceTextBox.Text.Length == 0) {
                MessageBox.Show("Data is not full. Lack of model or price!");
                return;
            }
            var model = this.ModelTextBox.Text;
            var price = double.Parse(this.PriceTextBox.Text.Replace('.', ','));
            this.mainWindow.CPUS.Add(new CPU(model, price));
            MessageBox.Show("New CPU added!");
            this.ModelTextBox.ResetText();
            this.PriceTextBox.ResetText();
        }

        private void DeleteCPUButton_Click(object sender, EventArgs e) {
            if (this.ModelTextBox.Text.Length == 0) {
                MessageBox.Show("Can't delete model with no name!");
                return;
            }
            var model = this.ModelTextBox.Text;
            foreach(var cpu in this.mainWindow.CPUS) {
                if(cpu.MODEL == model) {
                    this.mainWindow.CPUS.Remove(cpu);
                    MessageBox.Show(string.Format("CPU: {0} has been deleted!", model));
                    return;
                }
            }
            MessageBox.Show(string.Format("CPU {0} is not present! Can't be deleted!", model));
            return;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
