using System.Windows;

namespace Library {
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window {
        public PersonWindow(Person borrower) {
            InitializeComponent();
            this.PersonTextBox.Text = borrower.ToString();
        }

        private void PersonOkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
