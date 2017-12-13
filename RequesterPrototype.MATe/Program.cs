using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using System.Net;
using System.Threading;
using MATeV2;

namespace RequesterPrototype.MATe
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Context 1 :");
            ContextAndUserManager uno = new ContextAndUserManager("Context", true);
            using(var ct = uno.ObtainAccessor())
            {
                Context un = ct.Context;
                List<Employee> emp = new List<Employee>();
                Employee Leader = un.CreateEmployee("Alexo", "Spitz", "a@ex.comi");
                Employee zulu = un.CreateEmployee("Alexi", "Spitzi", "a@ex.comii");
                emp.Add(zulu);
                emp.Add(un.CreateEmployee("Alexii", "Spitzii", "a@ex.comiii"));

                Project Alpha = un.CreateProject("Project 1", DateTime.Parse("12/12/2017"), DateTime.Parse("12/12/2018"), Leader, emp);

                Tasker Bravo = Alpha.CreateTask("Task oner", DateTime.Parse("12/12/2020"));

                SubTask Charlie = Bravo.CreateSubtask(Bravo, "Subtask oner", DateTime.Parse("12/12/2019"), zulu);



            }
            uno.Login("b");
            Thread.Sleep(2000);
            ContextAndUserManager dos = new ContextAndUserManager("Context", true);
            using (var ct = dos.ObtainAccessor())
            {
                Context un = ct.Context;
                List<Employee> emp = new List<Employee>();

                Employee i = un.CreateEmployee("Alex", "SPIR", "a@ex.comi");
                emp.Add(un.CreateEmployee("Alexi", "Spitzi", "a@ex.comii"));
                un.CreateProject("Project 1", DateTime.Parse("05/05/2017"), DateTime.Parse("05/05/2019"), i, emp);


            }
            dos.Login("a@ex.comii");
            using (var ct = dos.ObtainAccessor())
            using (var ct1 = uno.ObtainAccessor())
            {
                Context un = ct1.Context;
                Context dosi = ct.Context;

                un.Merge(dosi);
                foreach(var emp in un.PersonsDictionary)
                {
                    Console.WriteLine(emp.Value.Firstname + emp.Value.Lastname);
                }
                foreach(var prj in un.ProjectsDictionary)
                {
                    Console.WriteLine("================");
                    Console.WriteLine(prj.Value.Projectmanager.Firstname);
                }

            }
            Console.ReadKey();
            

        }
    }
}
