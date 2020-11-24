using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

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

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }
    }
}