using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable {
    public enum TypeChange {
        Creation,
        Change,
        Removal,
        Recovery
    }
    [Serializable]
    class ActionWithEntry {
        public DateTime DateAction;
        public TypeChange TypeChange;
        public ActionWithEntry(DateTime dateAction, TypeChange typeChange) {
            DateAction = dateAction;
            TypeChange = typeChange;
        }
    }
}
