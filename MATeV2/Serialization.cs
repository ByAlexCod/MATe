using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace MATeV2
{
    public class Serialization
    {
        public static bool Success = false;
        public static void Serialize(Context c)
        {

            FileStream fs = new FileStream("-Context.MATe", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(fs, c);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
        public static object Deserialize()
        {
           
            if (!File.Exists("-Context.MATe")) return null;
            FileStream fs = new FileStream("-Context.MATe", FileMode.Open);
            object obj;
            BinaryFormatter bf = new BinaryFormatter();
            obj = bf.Deserialize(fs);
            fs.Close();
            Context temp = (Context)obj;
            return obj;
        }
        //public static object DeserializeByFileName(string fileName)
        //{
        //    if (String.IsNullOrEmpty(fileName)) throw new ArgumentNullException("Context name cannot be null", nameof(fileName));
        //    if (!File.Exists( fileName)) return null;
        //    FileStream fs = new FileStream("-Context.MATe", FileMode.Open);
        //    object obj;
        //    BinaryFormatter bf = new BinaryFormatter();
        //    obj = bf.Deserialize(fs);
        //    fs.Close();
        //    Context temp = (Context)obj;
        //    return obj;
        //}

    }
}
