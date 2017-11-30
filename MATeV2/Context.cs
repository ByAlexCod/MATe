using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class Context
    {
        DateTime _modifyTime;
        readonly Dictionary<string, Employee> _personsDictionary = new Dictionary<string, Employee>();
        readonly Dictionary<string, Project> _projectsDictionary = new Dictionary<string, Project>();
        Boss _boss;
        string _companyName;
        readonly int _firstExchangePort;
        bool _isDirty;

        readonly Dictionary<string, Employee> _waitingPersonsList = new Dictionary<string, Employee>();
        /// <summary>
        /// Create context and create initialize first Exchange port as a random number.
        /// </summary>
        internal Context(string name)
        {
            _companyName = name;
            _firstExchangePort = new Random().Next(1, 6666);
            _boss = new Boss(this, "default", "boss", "b");
            CreateEmployee("Alex", "Spitz", "a@ex.com");

            
        }

        public DateTime SetDirty( bool reset = false )
        {
            if( reset )
            {
                _isDirty = false;
            }
            else
            {
                _modifyTime = DateTime.Now;
                _isDirty = true;
            }
            return _modifyTime;
        }

        public bool IsDirty => _isDirty;

        public DateTime ModifyDate => _modifyTime;


        /*public Employee FindOrCreateEmployee( string email )
        { }*/
         

        public Dictionary<string, Project> ProjectsDictionary => _projectsDictionary;
        
        public Dictionary<string, Employee> PersonsDictionary => _personsDictionary;
        public int FirstExchangePort => _firstExchangePort;
        public string CompanyName => _companyName;

        /// <summary>
        /// Login user (Boss or Employee) and return person or null if mail or password is not correct
        /// </summary>
        /// <param name="mail">Mail to Tes</param>
        /// <param name="password">Password to Test</param>
        /// <returns></returns>
        public Person Login(string mail)
        {
            Employee value;
            if (Boss.Mail == mail) return Boss;
            if (PersonsDictionary.TryGetValue(mail, out value)) return value;
            return null;
        }

        public Boss Boss
        {
            get { return _boss; }
        }





        ///


        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader = null)
        {
            if (ProjectsDictionary.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(name, datebegin, datelimit, leader);
            ProjectsDictionary.Add(newproject.Name, newproject);
            //newproject.Contx = this.Contx;
            return newproject;
        }

        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader, List<Employee> listperson)
        {
            if (ProjectsDictionary.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(name, datebegin, datelimit, leader);
            foreach (Employee e in listperson)
            {
                newproject.Members.Add(e.Mail,e);
            }
            ProjectsDictionary.Add(newproject.Name, newproject);
            //newproject.Contx = this.Contx;
            return newproject;
        }
        /// <summary>
        /// modify project by adding a new projectmanager or new members
        /// </summary>
        /// <param name="p"></param>
        /// <param name="projectmanager"></param>
        /// <param name="listem"></param>
        /// <returns></returns>
        public Project ModifyProject(Project p, Employee projectmanager, List<Employee> listem)
        {
            if (projectmanager != null)
            {
                if (projectmanager.CurrentWorkingProject != null) throw new ArgumentException("this employee is having a project remove him from his project before continue");
                if (p.Projectmanager != null) p.Projectmanager.CurrentWorkingProject = null;
                projectmanager.CurrentWorkingProject = p;
                p.Projectmanager = projectmanager;
            }
            if (listem != null)
            {
                foreach (Employee e in listem)
                {
                    p.Members.Add(e.Mail,e);
                    e.CurrentWorkingProject = p;
                }
            }
            return p;
        }

        public Project ModifyProject(Project p, string name, DateTime datebegin, DateTime datelimit)
        {
            if (name != null) p.Name = name;
            if (datebegin != DateTime.MinValue) p.DateBegin = datebegin;
            if (datelimit != DateTime.MinValue) p.DateLimit = datelimit;
            return p;
        }
        /// <summary>
        /// Remove a project manager from a project.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="projectmanager"></param>
        /// <returns></returns>
        public Project DeleteProjectManager(Project p, Employee projectmanager)
        {
            p.Projectmanager = null;
            projectmanager.CurrentWorkingProject = null;
            return p;
        }

        /// <summary>
        /// Remove a member from a project.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public Project RemoveMemberFromProject(Project p, Employee e)
        {
            e.CurrentWorkingProject = null;
            p.Members.Remove(e.Mail);
            return p;
        }
        /// <summary>
        /// Delete a project = remove references to this project from projectmanagers,employees.
        /// Also remove itself from list projects in context.
        /// And also deletes the tasks in this project.
        /// still not finish for first version because the fonctions deletetask(), deletesubtask() not write.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Boolean DeleteProject(Project p)
        {
            if (p == null) return false;
            p.Projectmanager.CurrentWorkingProject = null;
            foreach (Employee e in p.Members.Values)
            {
                e.CurrentWorkingProject = null;
            }
            foreach (Tasker t in p.Tasks.Values)
            {
                t.DeleteTask();
            }
            ProjectsDictionary.Remove(p.Name);
            return true;
        }













        ///



        /// <summary>
        /// boss create a new employee. Fill in first name, lastname and email of the employee
        /// and get a random password made by fonction RandomPassword();
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        public Employee CreateEmployee(string firstname, string lastname, string mail)
        {
            Employee e;
            
            e = new Employee(this, firstname, lastname, mail);
            PersonsDictionary.Add(e.Mail, e);
            return e;
        }

        /// <summary>
        /// Remove an employee in the company
        /// need add later: remove task,subtask linked with the employee
        /// </summary>
        /// <param name="e"></param>
        public void DeleteEmployee(Employee e)
        {
            _personsDictionary.Remove(e.Mail);
            if (e.CurrentWorkingProject != null)
            {
                if (e.CurrentWorkingProject.Projectmanager == e) this.DeleteProjectManager(e.CurrentWorkingProject, e);
                else this.RemoveMemberFromProject(e.CurrentWorkingProject, e);
            }
        }

        /// <summary>
        /// create a random password with the length of 6
        /// </summary>
        /// <returns></returns>
        
    }
    




}
