using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book> {
            new Book("Pan Tadeusz", "n1"),
            new Book("Lalka", "n2"),
            new Book("Ferdydurke", "n3"),
            new Book("1984", "n4"),
            new Book("Ojciec Chrzestny", "n5"),
            new Book("Metro 2033", "n6"),
        };
        private ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person> {
            new Person("Kowalski", "n1"),
            new Person("Koniecpolski", "n2"),
            new Person("Kaczmarek", "n3"),
            new Person("InnyKowalski", "n4"),
            new Person("Zdziarski", "n5"),
        };

        public MainWindow() {
            InitializeComponent();
            this.BooksDataGrid.ItemsSource = this.Books;
            this.PersonDataGrid.ItemsSource = this.People;
        }

        private void LoanButton_Click(object sender, RoutedEventArgs e) {
            Person loaner = this.PersonDataGrid.SelectedItem as Person;
            if(loaner != null && this.BooksDataGrid.SelectedItems != null) {
                foreach (Book book in this.BooksDataGrid.SelectedItems) {
                    if(book.Loaner is null) {
                        if(loaner.CurrentLoanedBooks.Count < 3) {
                            loaner.CurrentLoanedBooks.Add(book);
                            book.Loaner = loaner;
                        } else {
                            MessageBox.Show("Can't loan more than 3 books");
                            break;
                        }
                    } else if (object.ReferenceEquals(book.Loaner, loaner)) {
                        MessageBox.Show($"{book.Loaner.Name} has already loaned {book.Title}.");
                    } else {
                        MessageBox.Show($"{book.Title} is loaned by {book.Loaner.Name}");
                    }
                }
                MessageBox.Show($"Loaned books: {string.Join(", ", loaner.CurrentLoanedBooks.Select(b => b.Title))}");
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            if(this.BooksDataGrid.SelectedItems.Count != 0 && this.PersonDataGrid.SelectedItem != null) {
                MessageBox.Show($"For returning select only 1 person or multpile books.");
            } else if(this.PersonDataGrid.SelectedItem != null) {
                Person loaner = this.PersonDataGrid.SelectedItem as Person;
                foreach (Book book in loaner.CurrentLoanedBooks) {
                    book.Loaner = null;
                }
                loaner.CurrentLoanedBooks.Clear();
                MessageBox.Show($"Succesfully returned all of {loaner.Name} books.");
            } else {
                foreach (Book book in this.BooksDataGrid.SelectedItems) {
                    if(book.Loaner is null) {
                        MessageBox.Show($"Can't return book {book.Title} cause it's not on loan");
                        continue;
                    }
                    book.Loaner.CurrentLoanedBooks.Remove(book);
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
                return;
            }
            Book chosen = books[0];
            if(chosen != null) {
                List<Person> filtered = this.People.Where(p => p.CurrentLoanedBooks.Contains(chosen)).ToList();
                PersonWindow pw = new PersonWindow(filtered);
                pw.Show();
            }
        }

        private void BooksListButton_Click(object sender, RoutedEventArgs e) {
            string idk = this.PersonIDKTextBox.Text?.Trim();
            Person[] people = this.People.Where(p => p.IDK == idk)?.ToArray();
            if (people.Count() == 0) {
                return;
            }
            Person chosen = people[0];
            if (chosen != null) {
                List<Book> filtered = this.Books.Where(b => object.ReferenceEquals(b.Loaner, chosen)).ToList();
                BooksWindow bw = new BooksWindow(filtered);
                bw.Show();
            }
        }
    }
}
