using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;

namespace Charting {
    /// <summary>
    /// Interaction logic for ChartWindow.xaml
    /// </summary>
    public partial class ChartWindow : Window {

        public DataTable DTable { get; }
        public BindingList<Tuple<string, int>> Values { get; set; }

        public ChartWindow(DataTable table) {
            InitializeComponent();
            DTable = table;
        }

        public void LoadPlot() {
            var pairs = from row in DTable.AsEnumerable()
                        select new KeyValuePair<string, double>((string)row[1], double.Parse(row[3].ToString()));
            BarPlot.ItemsSource = pairs.ToArray();
            BarPlot.LegendItems.Clear();
            BarPlot.LegendItems.Add("% of People");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            LoadPlot();
        }
    }
}
