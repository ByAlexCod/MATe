using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TestFichierBinaire
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static Context BuildInitialContext()
        {

            IFormatter format = new BinaryFormatter();
            Context c = new Context("Context 1");
            using (Stream flux = new FileStream("Contexte.bin", FileMode.OpenOrCreate, FileAccess.Read))
            {
                c = (Context)format.Deserialize(flux);
            }
            return c;
        }
    }
}

/*List<Truc> liste = new List<Truc>(5);
int num = 42;

            for (int i = 0; i< 5; i++)
            {
                Truc obj = new Truc();
obj.Str = "Hello" + num;
                obj.Num = num;
                obj.Dt = DateTime.Now;
                liste.Add(obj);
                num++;
            }
            IFormatter format = new BinaryFormatter();

            //serialisation
            using (Stream flux = new FileStream("Obj.bin", FileMode.OpenOrCreate, FileAccess.Write))
            {
                format.Serialize(flux, liste);
            }

            List<Truc> liste2;
            //deserialisation
            using (Stream flux = new FileStream("Obj.bin", FileMode.Open, FileAccess.Read))
            {
                liste2 = (List<Truc>) format.Deserialize(flux);
            }

            //affichage
            foreach (Truc item in liste2)
                Console.WriteLine(item.ToString());
        }*/
