using System;
using System.Collections.Generic;
using System.Windows;

namespace Library {
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window {
        public PersonWindow(List<string> people) {
            InitializeComponent();
            this.PersonTextBox.Text = string.Join(Environment.NewLine, people);
        }

        private void PersonOkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
