using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window {
        // Books collection used in DataGrid binding.
        private ObservableCollection<Book> Books { get; set; }
        // Reades collection used in DataGrid binding.
        private ObservableCollection<Person> Readers { get; set; }

        /// <summary>
        /// Main window constructor. Creates controls and sets "DataDirectory".
        /// </summary>
        public MainWindow() {
            InitializeComponent();
            // Gets main projects directory.
            string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            // Sets "DataDirectory" to main project directory, so the app can work on original DB.
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        /// <summary>
        /// Callback for LoanButton_Click. Performs book borrow logic.
        /// </summary>
        /// <param name="sender">Clicked buton</param>
        /// <param name="e">Event args</param>
        private async void LoanButton_Click(object sender, RoutedEventArgs e) {
            // If no book or too many books selected.
            if(this.BooksDataGrid.SelectedItems.Count > 3 || this.BooksDataGrid.SelectedItems.Count == 0) {
                MessageBox.Show("Select only between 1 and 3 books.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // If no person selected.
            if(this.PersonDataGrid.SelectedItems.Count == 0) {
                MessageBox.Show("Select person.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Using "new connection".
            using(var db = new DataContext()) {
                // Get all binded objects from selected rows (type is Book).
                // Get all id of books, which are not borrower "borrower is null".
                var booksIds = this.BooksDataGrid.SelectedItems.OfType<Book>().Where(b => b.Borrower == null).Select(b => b.IDK);
                var readerId = ((Person)this.PersonDataGrid.SelectedItem).IDC;
                
                // If ther is no book that can be borrowed.
                if(booksIds.Count() == 0) {
                    MessageBox.Show("Unable to borrow books.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Select book from DB. Select only these which ID is in selected IDs.
                var books = db.Books.Where(b => booksIds.Contains(b.IDK));
                // Select reader which id eq selected ID.
                var reader = db.Readers.Single(r => r.IDC == readerId);
                // Async perform action on every book.
                await books.ForEachAsync(b => {
                    if(b.Borrower?.Books.Count < 3 || b.Borrower == null)
                        b.Borrower = reader;
                });
                // Save changes to db.
                db.SaveChanges();
                MessageBox.Show("Operation successful!", "Succes", MessageBoxButton.OK);
            }
        }
        /// <summary>
        /// Callback for ReturnButton_Click. Performs book's return logic.
        /// Books are returned by single person, and single person always returns every book.
        /// </summary>
        /// <param name="sender">ReturnButton</param>
        /// <param name="e">EventArgs</param>
        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            // If no person selected.
            if(this.PersonDataGrid.SelectedItems.Count == 0) {
                MessageBox.Show("Select person.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // Using new connection.
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
                        this.BookIDCTextBox.Clear();
                        return;
                    }
                    if(filtered.Borrower == null) {
                        MessageBox.Show("Book has no borrower", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        this.BookIDCTextBox.Clear();
                        return;
                    }
                    PersonWindow pw = new PersonWindow(filtered.Borrower);
                    pw.ShowDialog();
                }
            } else {
                MessageBox.Show("Error while parsing IDK", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.BookIDCTextBox.Clear();
        }

        private void BooksListButton_Click(object sender, RoutedEventArgs e) {
            if(int.TryParse(this.PersonIDKTextBox.Text?.Trim(), out int idc)) {
                using(var db = new DataContext()) {
                    var filtered = db.Books.Where(b => b.Borrower.IDC == idc);
                    if(filtered.Count() == 0) {
                        MessageBox.Show("This person has no books or doesn't exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        this.PersonIDKTextBox.Clear();
                        return;
                    }
                    BooksWindow bw = new BooksWindow(filtered.ToList());
                    bw.ShowDialog();
                }
            } else {
                MessageBox.Show("Error while parsing IDC", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.PersonIDKTextBox.Clear();
        }

        private async void LoadData() {
            using(var db = new DataContext()) {
                this.Books = new ObservableCollection<Book>(await db.Books.ToListAsync());
                this.Readers = new ObservableCollection<Person>(await db.Readers.ToListAsync());
                this.PersonDataGrid.ItemsSource = this.Readers;
                this.BooksDataGrid.ItemsSource = this.Books;
            }
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

        private void PersonDataGrid_KeyDown(object sender, KeyEventArgs e) {
            if(e.Key == Key.Delete) {
                using(var db = new DataContext()) {
                    var readerID = ((Person)((DataGrid)(sender)).SelectedItem).IDC;
                    var reader = db.Readers.Single(r => r.IDC == readerID);
                    if(reader.Books.Count > 0) {
                        MessageBox.Show("Can't delete user if he has borrowed books.", "Error", MessageBoxButton.OK);
                        e.Handled = true;
                    } else {
                        db.Readers.Remove(reader);
                    }
                    db.SaveChanges();
                    this.LoadData();
                }
            }
        }

        private void BooksDataGrid_PreviewKeyDown(object sender, KeyEventArgs e) {
            if(e.Key == Key.Delete) {
                using(var db = new DataContext()) {
                    var bookID = ((Book)((DataGrid)(sender)).SelectedItem).IDK;
                    var book = db.Books.Single(b => b.IDK == bookID);
                    if(book.Borrower != null) {
                        MessageBox.Show("Can't delete book if it's borrowed.", "Error", MessageBoxButton.OK);
                        e.Handled = true;
                    } else {
                        db.Books.Remove(book);
                    }
                    db.SaveChanges();
                    this.LoadData();
                }
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
