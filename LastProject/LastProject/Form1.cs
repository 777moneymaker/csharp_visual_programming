using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LastProject {
    public partial class MainWindow : Form {

        public DataTable readCSV(string filePath) {
            var dt = new DataTable();
            // Creating the columns
            File.ReadLines(filePath).Take(1)
                .SelectMany(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => dt.Columns.Add(x.Trim()));

            // Adding the rows
            File.ReadLines(filePath).Skip(1)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));
            return dt;
        }

        private DataTable DTable { get; set; }

        public MainWindow() {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MainDataGridView.AllowUserToAddRows = false;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void LoadCSVButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog() {
                Filter = "Csv files (CSV)|*.CSV;"
            };
            ofd.ShowDialog();
            if (ofd.FileName != "" && ofd.FileName.EndsWith(".csv")) {
                try {
                    DTable = readCSV(ofd.FileName); 
                } catch {
                    MessageBox.Show("Error while loading csv");
                }
                MainDataGridView.DataSource = DTable;
                int min_index = 0;
                int min = 10000;
                foreach (var row in MainDataGridView.Rows) {
                    var val = (row as DataGridViewRow).Cells["Value"].Value;
                    if(int.TryParse(val.ToString(), out int int_val) && int_val <= min) {
                        min = int_val;
                        min_index = (row as DataGridViewRow).Index;
                    }
                }
                MainDataGridView.Rows[min_index].Cells["Value"].Style.BackColor = Color.Green;

                int max_index = 0;
                int max = 0;
                foreach (var row in MainDataGridView.Rows) {
                    var val = (row as DataGridViewRow).Cells["Value"].Value;
                    if (int.TryParse(val.ToString(), out int int_val) && int_val >= max) {
                        max = int_val;
                        max_index = (row as DataGridViewRow).Index;
                    }
                }
                MainDataGridView.Rows[max_index].Cells["Value"].Style.BackColor = Color.Red;

            }
        }

        private bool CheckInputs() {
            return Regex.Match(FirstNumTextBox.Text, @"^\d+[,]?\d*$").Success && Regex.Match(SecondNumTextBox.Text, @"^\d+[,]?\d*$").Success;
        }

        private void tabPage4_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            if (CheckInputs()) {
                bool first_good = double.TryParse(FirstNumTextBox.Text, out double first);
                bool second_good = double.TryParse(SecondNumTextBox.Text, out double second);
                if (first_good && second_good)
                    MessageBox.Show((first - second).ToString());
            } else {
                MessageBox.Show("Wrong numbers or empty textbox. Remember to use \',\' instead of \'.\' as delim");
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (CheckInputs()) {
                bool first_good = double.TryParse(FirstNumTextBox.Text, out double first);
                bool second_good = double.TryParse(SecondNumTextBox.Text, out double second);
                if(first_good && second_good)
                    MessageBox.Show((first + second).ToString());
            } else {
                MessageBox.Show("Wrong numbers or empty textbox. Remember to use \',\' instead of \'.\' as delim");
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e) {
            if (CheckInputs()) {
                bool first_good = double.TryParse(FirstNumTextBox.Text, out double first);
                bool second_good = double.TryParse(SecondNumTextBox.Text, out double second);
                if (first_good && second_good)
                    MessageBox.Show((first * second).ToString());
            } else {
                MessageBox.Show("Wrong numbers or empty textbox. Remember to use \',\' instead of \'.\' as delim");
            }
        }

        private void DivideButton_Click(object sender, EventArgs e) {
            if (CheckInputs()) {
                bool first_good = double.TryParse(FirstNumTextBox.Text, out double first);
                bool second_good = double.TryParse(SecondNumTextBox.Text, out double second);
                if (first_good && second_good)
                    MessageBox.Show((first / second).ToString());
            } else {
                MessageBox.Show("Wrong numbers or empty textbox. Remember to use \',\' instead of \'.\' as delim");
            }
        }

        private void ModButton_Click(object sender, EventArgs e) {
            if(SecondNumTextBox.Text != "") {
                MessageBox.Show("For modulo 4 you have to inter number only in first text box");
            }
            if(FirstNumTextBox.Text != "") {
                if (Regex.Match(FirstNumTextBox.Text, @"^\d+$").Success) {
                    bool good = double.TryParse(FirstNumTextBox.Text, out double num);
                    if(good)
                        MessageBox.Show((num % 4).ToString());
                } else {
                    MessageBox.Show("Only integers allowed");
                }
            }
        }

        private void OperationButton_Click(object sender, EventArgs e) {
            if (SecondNumTextBox.Text != "") {
                MessageBox.Show("For this operation you have to inter number only in first text box");
            }
            if (FirstNumTextBox.Text != "") {
                if (Regex.Match(FirstNumTextBox.Text, @"^\d+$").Success) {
                    bool good = double.TryParse(FirstNumTextBox.Text, out double num);
                    if(good)
                        MessageBox.Show((num / Math.Sqrt((num + 1))).ToString());
                } else {
                    MessageBox.Show("Only integers allowed");
                }
            }
        }
    }
}
