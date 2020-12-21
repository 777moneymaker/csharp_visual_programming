using System.Data;
using System.Windows;

namespace Charting {
    /// <summary>
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window {
        public DataTable DTable { get; }

        public TableWindow(DataTable table) { 
            InitializeComponent();
            DTable = table;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            LoadedDataGrid.ItemsSource = DTable.DefaultView;
        }
    }
}
