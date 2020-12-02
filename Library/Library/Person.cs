using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Library {
    [DataContract(IsReference =true)]
    public class Person {
        [DataMember]
        public string IDC { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Book> Books { get; set; } = new List<Book>();

        public Person(string name, string idc) {
            this.IDC = idc;
            this.Name = name;
        }

        public override string ToString() {
            return this.Name;
        }
    }
}
