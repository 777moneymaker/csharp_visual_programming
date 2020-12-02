using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Library {
    [DataContract(IsReference = true)]
    public class DataSaver {
        [DataMember]
        public List<Person> Readers { get; set; }
        [DataMember]
        public List<Book> Books { get; set; }

        public DataSaver(List<Person> readers, List<Book> books) {
            this.Readers = readers;
            this.Books = books;
        }
    }
}
