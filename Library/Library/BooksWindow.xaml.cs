using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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
