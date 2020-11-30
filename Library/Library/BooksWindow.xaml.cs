using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library {
    /// <summary>
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window {
        public BooksWindow(List<Book> books) {
            InitializeComponent();
            this.BooksTextBox.Text = string.Join(Environment.NewLine, books.Select(p => p.Title));
        }

        private void BoooksOkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
