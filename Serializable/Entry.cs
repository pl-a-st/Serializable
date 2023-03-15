using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable {
    [Serializable]
    class Entry {
        public Person Person {
            get;
            private set;
        }
        public List<ActionWithEntry> Actions {
            get;
            private set;
        } = new List<ActionWithEntry>();
        public Entry(Person person) {
            Person = person;
            Actions.Add(new ActionWithEntry(dateAction: DateTime.Now, TypeChange.Creation));
        }
        public void SetPerson(Person person) {
            Person = person;
        }
        public void AddAction(TypeChange typeChange) {
            Actions.Add(new ActionWithEntry(dateAction: DateTime.Now, typeChange));
        }
    }
}
