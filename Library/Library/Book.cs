using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    [Serializable]
    public class Book {
        public string Title { get; set; }
        public string IDC { get; set; }
        public Person Loaner { get; set; }

        public Book() {
        }

        public Book(string title, string idc) {
            this.Title = title;
            this.IDC = idc;
        }
    }
}
