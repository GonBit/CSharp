using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace SerializationApp
{
    public class SerialiserBinary
    {
        public void SerializeToFile<T>(string filePath, T item)
        {
            FileStream fileStream = File.Create(filePath);
            //Create a binary formatter object - used to serialize item to file
            BinaryFormatter writer = new BinaryFormatter();
            writer.Serialize(fileStream, item);
            fileStream.Close();
        }

        public T DeserializeFromFile<T>(string filePath)
        { 
            //create a string
            Stream fileStream = File.OpenRead(filePath);
            BinaryFormatter reader = new BinaryFormatter();
            var desiralisedItem = (T)reader.Deserialize(fileStream);
            fileStream.Close();
            return desiralisedItem;
        }
    }
}
