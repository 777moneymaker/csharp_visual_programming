using ExcelDataReader;
using Microsoft.Win32;
using System.Data;
using System.IO;
using System.Windows;

namespace Charting {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public DataTable DTable { get; set; }

        public MainWindow() {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "Excel Files (*.xls;*.xlsx)|*.XLS;*.XLSX|All files (*.*)|*.*",
                FilterIndex = 1
            };
            ofd.ShowDialog();

            if(ofd.FileName != "") {
                string filename = ofd.FileName; 
                FileLabel.Content = "File: " + filename;
                LoadDTable(filename);
            } else {
                return;
            }
        }

        private void TableButton_Click(object sender, RoutedEventArgs e) {
            if(DTable is null) {
                MessageBox.Show("You didn't load any file.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            TableWindow tw = new TableWindow(DTable);
            tw.ShowDialog();
        }

        private void ChartButton_Click(object sender, RoutedEventArgs e) {
            if(DTable is null) {
                MessageBox.Show("You didn't load any file.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ChartWindow cw = new ChartWindow(DTable);
            cw.ShowDialog();
        }

        private void LoadDTable(string filename) {
            using(var stream = File.Open(filename, FileMode.Open, FileAccess.Read)) 
            using(var reader = ExcelReaderFactory.CreateReader(stream)) {

                var result = reader.AsDataSet(new ExcelDataSetConfiguration {
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration() {
                        FilterColumn = (columnReader, columnIndex) => columnIndex < 2
                    }
                });

                if(result.Tables.Count > 0) {
                    DTable = result.Tables[0];
                    DTable.Columns.Add("ID").SetOrdinal(0);
                    DTable.Columns.Add("%");
                    DTable.Columns[1].ColumnName = "Airport";
                    DTable.Columns[2].ColumnName = "People";

                    int id = 0;
                    foreach(DataRow row in DTable.Rows)
                        row[0] = (++id).ToString();

                    double sum = 0;
                    foreach(DataRow row in DTable.Rows)
                        sum += double.Parse(row[2].ToString());
                    foreach(DataRow row in DTable.Rows)
                        row[3] = $"{(double.Parse(row[2].ToString()) / sum) * 100: 0.00}";
                } else {
                    return;
                }
            } 
        }
    }
}
