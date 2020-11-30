using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    [Serializable]
    public class Person {
        public string Name { get; set; }
        public string IDK { get; set; }

        public ObservableCollection<Book> CurrentLoanedBooks { get; set; } = new ObservableCollection<Book>();

        public Person() { 
        }

        public Person(string name, string idk) {
            this.Name = name;
            this.IDK = idk;
        }
    }
}
