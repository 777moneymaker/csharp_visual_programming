using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Library {

    public class Book {

        public string Title { get; set; }

        public int IDK { get; set; }

        public virtual Person Borrower { get; set; }
        
        public Book() {
        }

        public Book(string title, int idk) {
            this.Title = title;
            this.IDK = idk;
        }

        public override string ToString() {
            return this.Title;
        }
    }
}
