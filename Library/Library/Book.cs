using System.Runtime.Serialization;

namespace Library {
    [DataContract(IsReference = true)]
    public class Book {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string IDK { get; set; }
        [DataMember]
        public Person Borrower { get; set; }
        
        public Book() {
        }

        public Book(string title, string idk) {
            this.Title = title;
            this.IDK = idk;
        }

        public override string ToString() {
            return this.Title;
        }
    }
}
