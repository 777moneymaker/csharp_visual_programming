using System;

namespace DB_Overlay {
    [Serializable]
    class Person {
        public string name;
        public string last_name;
        public string job;
        public string sex;
        public int day_birth;
        public int month_birth;
        public int years_birth;

        public Person(string name, string last, string job, string sex, int day_birth, int month_birth, int years_birth) {
            this.name = name;
            this.last_name = last;
            this.job = job;
            this.sex = sex;
            this.day_birth = day_birth;
            this.month_birth = month_birth;
            this.years_birth = years_birth;
        }
    }
}
