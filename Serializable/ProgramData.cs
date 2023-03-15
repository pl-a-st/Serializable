using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable {
    static class ProgramData {
        public static Entries Entries;
        static ProgramData() {
            Entries newEntries = Serializable.binReadFileToObject(new Entries(), "C:\\Users\\ВеринСГ\\source\\repos\\Serializable\\Serializable\\bin\\Debug\\ProgramData.bin", out MethodResultStatus methodResultStatus);
            if(methodResultStatus == MethodResultStatus.Fault) {
                Entries = new Entries();
                return;
            }
            Entries = newEntries;
        }
    }
}
