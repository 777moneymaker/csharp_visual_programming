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
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window {
        public PersonWindow(List<Person> people) {
            InitializeComponent();
            this.PersonTextBox.Text = string.Join(Environment.NewLine, people.Select(p => p.Name));
        }

        private void PersonOkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
