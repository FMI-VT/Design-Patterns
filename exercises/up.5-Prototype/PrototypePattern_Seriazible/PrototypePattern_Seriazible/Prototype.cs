using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern_Seriazible
{
    [Serializable()]
    public abstract class Prototype<T>
    {

        // Performs Shallow copy

        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }


        // Performs Deep Copy        
        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}
