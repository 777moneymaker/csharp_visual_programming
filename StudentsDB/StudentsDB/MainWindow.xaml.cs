using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;

namespace StudentsDB {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void NewStudentButton_Click(object sender, RoutedEventArgs e) {
            App.Students.Add(new Student());
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e) {
            foreach(Student st in App.Students?.Where<Student>(st => st.IsSelected).ToList()) {
                App.Students.Remove(st);
            }
        }

        private void SearchSemesterButton_Click(object sender, RoutedEventArgs e) {
            if(this.SemesterSearchTextBox.Text == "") {
                MessageBox.Show("You didn't specify any semeter");
                return;
            }

            if(int.TryParse(this.SemesterSearchTextBox.Text, out int semester) 
                && App.Students.Where<Student>(st => st.Semester == semester).Count() != 0) {
                FilteredStudents fs = new FilteredStudents(semester);
                fs.Show();
            } else {
                MessageBox.Show("Problem parsing semester or no student on given semester.");
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Student>));
            try {
                using (StreamReader sw = new StreamReader("./students.xml")) {
                    App.Students = serializer.Deserialize(sw) as ObservableCollection<Student>;
                    this.studentsDataGrid.ItemsSource = App.Students;
                }
            } catch (FileNotFoundException) {
                App.Students = new ObservableCollection<Student>();
                this.studentsDataGrid.ItemsSource = App.Students;
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Student>));
            foreach(Student st in App.Students) {
                st.IsSelected = false;
            }
            try {
                using (StreamWriter sw = new StreamWriter("./students.xml")) {
                   serializer.Serialize(sw, App.Students);
                }
            } catch (Exception) { }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

    }
}
