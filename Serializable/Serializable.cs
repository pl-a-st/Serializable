using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serializable {
    public enum MethodResultStatus {
        Ok,
        Fault
    }
    public static class Serializable {
        public static MethodResultStatus binWriteObjectToFile<Type>(Type serObject, string fileName) {
            try {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream stream = new FileStream(fileName, FileMode.Create)) {
                    bf.Serialize(stream, serObject);
                }
                return MethodResultStatus.Ok;
            }
            catch (Exception ex) {
            }
            return MethodResultStatus.Fault;
        }
        public static Type binReadFileToObject<Type>(Type serObject, string fullPathFileName, out MethodResultStatus methodResultStatus) {
            BinaryFormatter bf = new BinaryFormatter();
            try {
                using (FileStream stream = new FileStream(fullPathFileName, FileMode.Open)) {
                    serObject = (Type)bf.Deserialize(stream);
                }
                methodResultStatus = MethodResultStatus.Ok;
            }
            catch (Exception ex) {
                methodResultStatus = MethodResultStatus.Fault;
            }
            return serObject;
        }
    }
}
