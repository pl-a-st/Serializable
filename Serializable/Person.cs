using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable {
    [Serializable]
    class Person {
        public string Name {
            get;
            private set;
        }
        public string Surname {
            get;
            private set;
        }
        public DateTime Birthday {
            get;
            private set;
        }

        public Person(string name, string surname, DateTime birthday) {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }
    }
}
