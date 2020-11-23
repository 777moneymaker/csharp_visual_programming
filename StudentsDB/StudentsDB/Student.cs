using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDB {
    [Serializable()]
    public class Student {
        public bool IsSelected { get; set; } = false;
        public string Name { get; set; }
        public uint Semester { get; set; }

        public Student(string name, uint semester) {
            this.Name = name;
            this.Semester = semester;
        }

        public Student() { }
    }
}
