using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
            this.BooksDataGrid.ItemsSource = this.Books;
            this.PersonDataGrid.ItemsSource = this.Readers;
        }

        private void LoanButton_Click(object sender, RoutedEventArgs e) {
            Person borrower = this.PersonDataGrid.SelectedItem as Person;
            if(borrower != null && this.BooksDataGrid.SelectedItems.Count > 0) {
                foreach (Book book in this.BooksDataGrid.SelectedItems) {
                    if (book.Borrower is null && borrower.Books.Count < 3) {
                        borrower.Books.Add(book);
                        book.Borrower = borrower;
                    } else if (borrower.Books.Count >= 3) {
                        MessageBox.Show($"{borrower.Name} can't borrow more than 3 books.");
                    } else if (object.ReferenceEquals(book.Borrower, borrower)) {
                        MessageBox.Show($"{borrower.Name} has already borrowed {book.Title}.");
                    } else {
                        MessageBox.Show($"{book.Title} is borrowed by {book.Borrower}");
                    }
                }
                MessageBox.Show("Operation completed.");
            } else {
                MessageBox.Show("Either borrower or any book is not selected.");
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e) {
            if(this.BooksDataGrid.SelectedItems.Count > 0 && this.PersonDataGrid.SelectedItem != null) {
                MessageBox.Show("For returning select only 1 person or multpile books.");
            } else if(this.PersonDataGrid.SelectedItem != null) {
                Person borrower = this.PersonDataGrid.SelectedItem as Person;
                if(borrower.Books.Count > 0) {
                    borrower.Books.ForEach(book => book.Borrower = null);
                    borrower.Books.Clear();
                    MessageBox.Show($"Succesfully returned all of {borrower.Name} books.");
                }else {
                    MessageBox.Show("This person doesn't have any books.");
                }
            } else {
                foreach (Book book in this.BooksDataGrid.SelectedItems) {
                    if(book.Borrower is null) {
                        MessageBox.Show($"Can't return book {book.Title} cause it's not borrowed.");
                        continue;
                    }
                    book.Borrower.Books.Remove(book);
                    book.Borrower = null;
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
            string idk = this.BookIDCTextBox.Text?.Trim();
            Book book = this.Books.FirstOrDefault(b => b.IDK == idk);

            if(book is null) {
                MessageBox.Show("No book with given idk");
                return;
            }
            if (book.Borrower is null) {
                MessageBox.Show("Given book has no borrower");
                return;
            }

            Person borrower = this.Readers.FirstOrDefault(reader => reader.Name == book.Borrower.Name);
            PersonWindow pw = new PersonWindow(borrower);
            pw.Show();
        }

        private void BooksListButton_Click(object sender, RoutedEventArgs e) {
            string idc = this.PersonIDKTextBox.Text?.Trim();
            Person borrower = this.Readers.FirstOrDefault(r => r.IDC == idc);
            if(borrower is null) {
                MessageBox.Show("No borrower with given idc.");
                return;
            }
            if(borrower.Books.Count == 0) {
                MessageBox.Show("Given person has no books");
                return;
            }
            BooksWindow bw = new BooksWindow(borrower.Books);
            bw.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            this.SaveData();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e) {
            this.LoadData();
        }

        private void SaveData() {
            DataContractSerializer serializer = new DataContractSerializer(typeof(DataSaver));
            DataSaver saver = new DataSaver(this.Readers.ToList(), this.Books.ToList());
            using (FileStream fs = File.OpenWrite("data.xml;")) {
                try {
                    serializer.WriteObject(fs, saver);
                    MessageBox.Show("Save completed.");
                } catch (Exception ex) when (ex is SerializationException || ex is InvalidDataContractException) {
                    MessageBox.Show("Error during saving process.");
                }
            }
        }

        private void LoadData() {
            DataContractSerializer serializer = new DataContractSerializer(typeof(DataSaver));
            try {
                using (FileStream fs = File.OpenRead("data.xml;")) {
                    DataSaver saver = serializer.ReadObject(fs) as DataSaver;
                    this.Books = new ObservableCollection<Book>(saver.Books);
                    this.Readers = new ObservableCollection<Person>(saver.Readers);
                    this.BooksDataGrid.ItemsSource = this.Books;
                    this.PersonDataGrid.ItemsSource = this.Readers;
                    MessageBox.Show("Load completed.");
                }
            } catch (Exception) {
                this.Readers = new ObservableCollection<Person> {
                    new Person("Kowalski", "1"),
                    new Person("Lubonski", "2"),
                    new Person("Koniecpolski", "3"),
                    new Person("Drejewski", "4"),
                    new Person("Ostrowski", "5"),
                };
                this.Books = new ObservableCollection<Book> {
                    new Book("Pan Tadeusz", "n1"),
                    new Book("Lalka", "n2"),
                    new Book("Ferdydurke", "n3"),
                    new Book("1984", "n4"),
                    new Book("Ojciec Chrzestny", "n5"),
                    new Book("Metro 2033", "n6"),
                };
                MessageBox.Show("Error during load process. Using default values...");
            } finally {
                this.BooksDataGrid.ItemsSource = this.Books;
                this.PersonDataGrid.ItemsSource = this.Readers;
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
