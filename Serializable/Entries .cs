using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable {
    [Serializable]
    class Entries : List<Entry> {
        public static DateTime DateLastAdd {
            get;
            private set;
        }
        public new void Add(Entry entry) {
            base.Add(entry);
            DateLastAdd = DateTime.Now;
        }
    }
}
