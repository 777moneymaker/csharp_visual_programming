using System.Collections.Generic;

namespace Library {

    public class Person {

        public int IDC { get; set; }

        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }

        public Person() { }

        public Person(string name, int idc) {
            this.IDC = idc;
            this.Name = name;
        }

        public override string ToString() {
            return this.Name;
        }
    }
}
