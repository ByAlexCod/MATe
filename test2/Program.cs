using System;
using System.IO;
using MATeV2;
using System.Collections.Generic;

namespace FileOperationsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Project p4 = new Project("Dev web",new DateTime(2017,11,11), new DateTime(2017, 12, 15));
            Project p1 = new Project("ITI world", new DateTime(2016, 10, 09), new DateTime(2016, 12, 15));
            Project p2 = new Project("Dev C#", new DateTime(2014, 07, 01), new DateTime(2015, 03, 07));
            Project p3 = new Project("First Project", new DateTime(2013, 02, 18), new DateTime(2014, 09, 15));
            ICollection<Project> projects = new List<Project>();
            projects.Add(p1);
            projects.Add(p2);
            projects.Add(p3);
            projects.Add(p4);
            // Create the new, empty data file.
            string fileName = @"Z:\DossierIntech\ITI.MATe\MATe-PI\Temp.bin";
            if (File.Exists(fileName))
            {
                Console.WriteLine(fileName + " already exists!");
                Console.ReadLine();
                return;
            }
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);
            // Create the writer for data.
            BinaryWriter w = new BinaryWriter(fs);
            // Write data to Test.data.
            foreach (Project p in projects)
            {
                w.Write(p.Name);
            }
            w.Close();
            fs.Close();
            // Create the reader for data.
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            // Read data from Test.data.
            foreach (Project p in projects)
            {
                Console.WriteLine(r.ReadString());
                Console.ReadLine();
            }
            r.Close();
            fs.Close();
        }
    }
}