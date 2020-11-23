using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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

namespace StudentsDB {
    /// <summary>
    /// Interaction logic for FilteredStudents.xaml
    /// </summary>
    public partial class FilteredStudents : Window {
        public FilteredStudents(int semester) {
            InitializeComponent();
            
            var _itemSourceList = new CollectionViewSource() { 
                Source = App.Students 
            };
            ICollectionView Itemlist = _itemSourceList.View;

            this.FilteredStudentsDataGrid.Items.Filter = new Predicate<object>(obj => {
                Student s = obj as Student;
                return (s.Semester == semester);
            });
            this.FilteredStudentsDataGrid.ItemsSource = Itemlist;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
