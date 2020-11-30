using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Serialization;

namespace Library {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window {

        private ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book> {
            new Book("Pan Tadeusz", "n1"),
            new Book("Lalka", "n2"),
            new Book("Ferdydurke", "n3"),
            new Book("1984", "n4"),
            new Book("Ojciec Chrzestny", "n5"),
            new Book("Metro 2033", "n6"),
        };

        public MainWindow() {
            InitializeComponent();
            this.BooksDataGrid.ItemsSource = this.Books;
            this.PersonDataGrid.ItemsSource = Book.People;
        }

        private void LoanButton_Click(object sender, RoutedEventArgs e) {
            Pair<string, string> loaner = this.PersonDataGrid.SelectedItem as Pair<string, string>;
            if(loaner != null && this.BooksDataGrid.SelectedItems.Count > 0) {
                foreach (Book book in this.BooksDataGrid.SelectedItems) {
                    if(book.Loaner is null) {
                        int loaner_count = this.Books
                                            .Where(b => b.Loaner != null &&
                                                  b.Loaner.First == loaner.First)
                                            .Count();
                        if(loaner_count < 3) {
                            book.Loaner = loaner;
                        } else {
                            MessageBox.Show("Can't loan more than 3 books");
                            break;
                        }
                    } else if (book.Loaner == loaner) {
                        MessageBox.Show($"{loaner.First} has already loaned {book.Title}.");
                    } else {
                        MessageBox.Show($"{book.Title} is loaned by {loaner.First}");
                    }
                }
                MessageBox.Show("Operation completed.");
            } else {
                MessageBox.Show("Either loaner or any book is not selected.");
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            if(this.BooksDataGrid.SelectedItems.Count > 0 && this.PersonDataGrid.SelectedItem != null) {
                MessageBox.Show($"For returning select only 1 person or multpile books.");
            } else if(this.PersonDataGrid.SelectedItem != null) {
                Pair<string, string> loaner = this.PersonDataGrid.SelectedItem as Pair<string, string>;
                List<Book> filtered_books = this.Books
                                                 .Where(b => b.Loaner != null &&
                                                        b.Loaner.First == loaner.First)
                                                 .ToList();
                if(filtered_books.Count > 0) {
                    foreach (Book book in filtered_books) {
                        book.Loaner = null;
                    }
                    MessageBox.Show($"Succesfully returned all of {loaner.First} books.");
                }else {
                    MessageBox.Show("This person doesn't have any books.");
                }
                
            } else {
                foreach (Book book in this.BooksDataGrid.SelectedItems) {
                    if(book.Loaner is null) {
                        MessageBox.Show($"Can't return book {book.Title} cause it's not on loan");
                        continue;
                    }
                    book.Loaner = null;
                }
                MessageBox.Show("Operation completed");
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
            string idc = this.BookIDCTextBox.Text?.Trim();
            Book[] books = this.Books.Where(b => b.IDC == idc)?.ToArray();
            if(books.Count() == 0) {
                MessageBox.Show("No book with given idc");
                return;
            }
            Book chosen = books[0];
            if (chosen.Loaner is null) {
                MessageBox.Show("Given book has no loaners");
                return;
            }
            List<string> filtered = Book.People
                                    .Where(p => p != null && p.First == chosen.Loaner.First)
                                    .Select(p => p.First)
                                    .ToList();
            PersonWindow pw = new PersonWindow(filtered);
            pw.Show();
        }

        private void BooksListButton_Click(object sender, RoutedEventArgs e) {
            string idk = this.PersonIDKTextBox.Text?.Trim();
            string[] people = Book.People
                              .Where(p => p != null && p.Second == idk)
                              .Select(p => p.First)
                              .ToArray();
            if (people.Count() == 0) {
                MessageBox.Show("No person with given idk");
                return;
            }
            string chosen = people[0];
            List<Book> filtered = this.Books.Where(b => b.Loaner != null && b.Loaner.First == chosen).ToList();
            if(filtered.Count == 0) {
                MessageBox.Show("Given person has no books");
                return;
            }
            BooksWindow bw = new BooksWindow(filtered);
            bw.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            this.SaveData();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e) {
            this.LoadData();
        }

        private void SaveData() {
            XmlSerializer book_ser = new XmlSerializer(typeof(ObservableCollection<Book>));
            using (StreamWriter b_sw = new StreamWriter("book.xml")) {
                book_ser.Serialize(b_sw, this.Books);
                MessageBox.Show("Successfully saved!");
            }
        }

        private void LoadData() {
            XmlSerializer book_ser = new XmlSerializer(typeof(ObservableCollection<Book>));
            using (StreamReader b_sr = new StreamReader("book.xml")) {
                try {
                    this.Books = book_ser.Deserialize(b_sr) as ObservableCollection<Book>;
                    this.BooksDataGrid.ItemsSource = this.Books;
                    this.PersonDataGrid.ItemsSource = Book.People;
                    MessageBox.Show("Successfully loaded!");
                } catch (System.InvalidOperationException) {
                    this.Books = new ObservableCollection<Book> {
                        new Book("Pan Tadeusz", "n1"),
                        new Book("Lalka", "n2"),
                        new Book("Ferdydurke", "n3"),
                        new Book("1984", "n4"),
                        new Book("Ojciec Chrzestny", "n5"),
                        new Book("Metro 2033", "n6"),
                    };
                    MessageBox.Show("Error loading data. Using default...");
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            this.SaveData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            this.LoadData();
        }

    }
}
