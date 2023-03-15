using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable {
    static class ProgramData {
        public static Entries Entries;
        static ProgramData() {
            Entries = new Entries();
        }
    }
}
