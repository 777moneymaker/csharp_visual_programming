using System;
using System.Collections.ObjectModel;

namespace Library {
    [Serializable]
    public class Book {
        public static ObservableCollection<Pair<string, string>> People { get; set; } = new ObservableCollection<Pair<string, string>> {
            new Pair<string, string>("Kowalski", "n1"),
            new Pair<string, string>("Koniecpolski", "n2"),
            new Pair<string, string>("Kaczmarek", "n3"),
            new Pair<string, string>("InnyKowalski", "n4"),
            new Pair<string, string>("Zdziarski", "n5"),
        };

        public string Title { get; set; }
        public string IDC { get; set; }
        public Pair<string, string> Loaner { get; set; }
        
        public Book() {
        }

        public Book(string title, string idc) {
            this.Title = title;
            this.IDC = idc;
        }
    }
    [Serializable]
    public class Pair<T1, T2> {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair() { }
        public Pair(T1 first, T2 second) {
            this.First = first;
            this.Second = second;
        }
    }
}
