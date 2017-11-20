using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATeV2;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize init = new Initialize("user");
            init.Init();
            Boss boss = Person.getBoss();
            boss.ModifyProfile("A", null, "newadmmin", "123456789");
            boss = Person.getBoss();
            Console.WriteLine(boss.Mail);
            Console.WriteLine(boss.Password);
            Employee employ1 = new Employee("employ", "1", "1@em", "1");
            Employee employ2 = new Employee("employ", "2", "2@em", "2");
            Employee employ;
            Project p1 = boss.AddProject("project1", DateTime.Now, new DateTime(2017, 11, 20));
            Project p2 = boss.AddProject("project2", DateTime.Now, new DateTime(2017, 11, 30), employ2);
            boss.ModifyProject(p1, null, DateTime.MinValue,DateTime.MinValue, employ1, null);
            foreach (Project p in boss.Projects.Values)
            {
                Console.WriteLine(p.Name);
            }

            for (int i = 0; i < 5; i++)
            {
                employ = new Employee("A", i.ToString(), string.Concat("A", i.ToString(), "@"), i.ToString());
                boss.ModifyProject(p1, null, DateTime.MinValue, DateTime.MinValue, null, employ);
            }
            for (int i = 0; i < 5; i++)
            {
                employ = new Employee("B", i.ToString(), string.Concat("B", i.ToString(), "@"), i.ToString());
                boss.ModifyProject(p2, null, DateTime.MinValue, DateTime.MinValue, null, employ);
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    
            //    boss.ModifyGroup(group2, null, null, employ, null);
            //}
            //foreach(Employee e in group1.Members)
            //{
            //    Console.WriteLine(e.Mail);
            //}
            //foreach (Employee e in group2.Members) Console.WriteLine(e.Mail);
            //Project project1 = boss.AddProject("project1", DateTime.Now, new DateTime(2017, 12, 31), group1);
            //Project project2 = boss.AddProject("project2", DateTime.Now, new DateTime(2017, 11, 30), group2);
            foreach (Project p in boss.Projects.Values)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.DateBegin);
                Console.WriteLine(p.DateLimit);
                Console.WriteLine(p.Leader.Mail);
                foreach (Employee e in p.Members)
                {
                    Console.WriteLine(e.Mail);
                }
            }
            Console.ReadLine(); 
        }
    }
}
