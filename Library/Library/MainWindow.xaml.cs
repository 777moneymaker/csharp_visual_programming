using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window {
        private ObservableCollection<Book> Books { get; set; }
        private ObservableCollection<Person> Readers { get; set; }

        public MainWindow() {
            InitializeComponent();
            string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        private async void LoanButton_Click(object sender, RoutedEventArgs e) {
            if(this.BooksDataGrid.SelectedItems.Count > 3 || this.BooksDataGrid.SelectedItems.Count == 0) {
                MessageBox.Show("Select only between 1 and 3 books.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(this.PersonDataGrid.SelectedItems.Count == 0) {
                MessageBox.Show("Select person.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using(var db = new DataContext()) {
                var booksIds = this.BooksDataGrid.SelectedItems.OfType<Book>().Where(b => b.Borrower == null).Select(b => b.IDK);
                var readerId = ((Person)this.PersonDataGrid.SelectedItem).IDC;
                
                if(booksIds.Count() == 0) {
                    MessageBox.Show("Unable to borrow books.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var books = db.Books.Where(b => booksIds.Contains(b.IDK));
                var reader = db.Readers.Single(r => r.IDC == readerId);

                await books.ForEachAsync(b => b.Borrower = reader);
                db.SaveChanges();
                MessageBox.Show("Operation successful!", "Succes", MessageBoxButton.OK);
            }

        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            if(this.PersonDataGrid.SelectedItems.Count == 0) {
                MessageBox.Show("Select person.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using(var db = new DataContext()) {
                var readerId = ((Person)this.PersonDataGrid.SelectedItem).IDC;
                var reader = db.Readers.Single(r => r.IDC == readerId);
                reader.Books.ForEach(b => b.Borrower = null);
                db.SaveChanges();
                MessageBox.Show("Operation successful!", "Succes", MessageBoxButton.OK);
            }
        }

        private void PersonDataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            (sender as DataGrid)?.UnselectAll();
        }

        private void BooksDataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            (sender as DataGrid)?.UnselectAll();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.BooksDataGrid?.UnselectAll();
            this.PersonDataGrid?.UnselectAll();
        }

        private void PersonListButton_Click(object sender, RoutedEventArgs e) {
            if(int.TryParse(this.BookIDCTextBox.Text?.Trim(), out int idk)) {
                using(var db = new DataContext()) {
                    var filtered = db.Books.Single(b => b.IDK == idk);
                    if(filtered == null) {
                        MessageBox.Show("No book with given IDK", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    if(filtered.Borrower == null) {
                        MessageBox.Show("Book has no borrower", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    PersonWindow pw = new PersonWindow(filtered.Borrower);
                    pw.ShowDialog();
                }
            } else {
                MessageBox.Show("Error while parsing IDK", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BooksListButton_Click(object sender, RoutedEventArgs e) {
            if(int.TryParse(this.PersonIDKTextBox.Text?.Trim(), out int idc)) {
                using(var db = new DataContext()) {
                    var filtered = db.Books.Where(b => b.Borrower.IDC == idc);
                    if(filtered.Count() == 0) {
                        MessageBox.Show("This person has no books or doesn't exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    BooksWindow bw = new BooksWindow(filtered.ToList());
                    bw.ShowDialog();
                }
            } else {
                MessageBox.Show("Error while parsing IDC", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            this.SaveData();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e) {
            this.LoadData();
        }

        private void SaveData() {
            
        }

        private void LoadData() {
            using(var db = new DataContext()) {
                this.Books = new ObservableCollection<Book>(db.Books.ToList());
                this.Readers = new ObservableCollection<Person>(db.Readers.ToList());
                this.PersonDataGrid.ItemsSource = this.Readers;
                this.BooksDataGrid.ItemsSource = this.Books;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            this.SaveData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            this.LoadData();
        }

        private void PersonDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e) {
            using(var db = new DataContext()) {
                var reader = e.EditingElement.DataContext as Person;
                if(reader.IDC == 0) {
                    string name = (e.EditingElement as TextBox).Text;
                    if(db.Readers.Any(r => r.Name == name)) {
                        MessageBox.Show("No two same names allowed!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        LoadData();
                        return;
                    }
                    Person p = new Person {
                       Name = (e.EditingElement as TextBox).Text,
                    };
                    db.Readers.Add(p);
                } else {
                    var rd = db.Readers.Single(r => r.IDC == reader.IDC);
                    rd.Name = (e.EditingElement as TextBox).Text;
                }
                db.SaveChanges();
                this.LoadData();
            }
        }

        private void BooksDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e) {
            using(var db = new DataContext()) {
                var book = e.EditingElement.DataContext as Book;
                if(book.IDK == 0) {
                    Book b = new Book {
                        Title = (e.EditingElement as TextBox).Text,
                    };
                    db.Books.Add(b);
                } else {
                    var bk = db.Books.Single(r => r.IDK == book.IDK);
                    bk.Title = (e.EditingElement as TextBox).Text;
                }
                db.SaveChanges();
                this.LoadData();
            }
        }
    }

    public sealed class DataContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Readers { get; set; }

        public DataContext() : base(ConfigurationManager.ConnectionStrings["Library.Properties.Settings.MainConnection"].ConnectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Book>().HasKey(u => u.IDK);
            modelBuilder.Entity<Book>().Property(u => u.IDK).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Person>().HasKey(p => p.IDC);
            modelBuilder.Entity<Person>().Property(u => u.IDC).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Person>().HasMany(p => p.Books).WithOptional(b => b.Borrower);
        }
    }
}
