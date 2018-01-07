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
        DateTime _bossModifyTime;
        readonly Dictionary<string, Employee> _personsDictionary = new Dictionary<string, Employee>();
        readonly Dictionary<string, Project> _projectsDictionary = new Dictionary<string, Project>();
        Boss _boss;
        string _companyName;
        readonly int _firstExchangePort;
        bool _isDirty;
        Person _owner;

        readonly Dictionary<string, Employee> _waitingPersonsList = new Dictionary<string, Employee>();
        /// <summary>
        /// Create context and create initialize first Exchange port as a random number.
        /// </summary>
        internal Context(string name)
        {
            SetBossModifyTime();
            _companyName = name;
            _firstExchangePort = new Random().Next(1, 6666);
            _boss = new Boss(this, "default", "boss", "b");
            CreateEmployee("Alex", "Spitz", "a@ex.com");
        }

        public DateTime SetDirty( bool reset = false )
        {
            //if (Owner == null) throw new ArgumentNullException("You have to login a member / boss to have an owner.", nameof(Owner));
            if( reset )
            {
                _isDirty = false;
            }
            else
            {
                _modifyTime = DateTime.Now;
                _isDirty = true;
                if (Owner == Boss) _bossModifyTime = DateTime.Now;
            }
            return _modifyTime;
        }


        public void ClearPersonDic()
        {
            SetDirty();

            _personsDictionary.Clear();
        }
        public void ClearProjectsDic()
        {
            SetDirty();

            _projectsDictionary.Clear();
        }

        public bool IsDirty => _isDirty;

        public DateTime ModifyDate => _modifyTime;
         
        public void SetBossModifyTime()
        {
            _bossModifyTime = DateTime.Now;
        }

        internal DateTime BossModifyTime
        {
            get { return _bossModifyTime; }
            set { _bossModifyTime = value; }
        }

        public Dictionary<string, Project> ProjectsDictionary => _projectsDictionary;
        
        public Dictionary<string, Employee> PersonsDictionary => _personsDictionary;
        public Person Owner => _owner;
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
            if (Boss.Mail == mail)
            {
               

                _owner = Boss;
                SetDirty();
                return Boss;
            }
            if (PersonsDictionary.TryGetValue(mail, out value))
            {

                _owner = value;
                SetDirty();
                return value;
            }
            return null;
        }

        public Boss Boss
        {
            get { return _boss; }
        }
      ///


        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader = null)

        {
            SetBossModifyTime();
            SetDirty();

            if (ProjectsDictionary.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(this, name, datebegin, datelimit, leader);
            ProjectsDictionary.Add(newproject.Name, newproject);
            return newproject;
        }

        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader, List<Employee> listperson)
        {
            SetBossModifyTime();
            if (ProjectsDictionary.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(this, name, datebegin, datelimit, leader);
            foreach (Employee e in listperson)
            {
                newproject.Members.Add(e.Mail,e);
            }
            ProjectsDictionary.Add(newproject.Name, newproject);
            //newproject.Contx = this.Contx;
            SetDirty();

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
            SetBossModifyTime();
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
            SetDirty();

            return p;
        }

        public Project ModifyProject(Project p, string name, DateTime datebegin, DateTime datelimit)
        {
            SetBossModifyTime();
            if (name != null) p.Name = name;
            if (datebegin != DateTime.MinValue) p.DateBegin = datebegin;
            if (datelimit != DateTime.MinValue) p.DateLimit = datelimit;
            SetDirty();

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
            SetBossModifyTime();
            p.Projectmanager = null;
            RemoveMemberFromProject(p, projectmanager);
            SetDirty();

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
            SetBossModifyTime();
            e.CurrentWorkingProject = null;
            p.Members.Remove(e.Mail);
            SetDirty();

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
            SetBossModifyTime();
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
            SetDirty();

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
            SetBossModifyTime();
            Employee e;
            
            e = new Employee(this, firstname, lastname, mail);
            PersonsDictionary.Add(e.Mail, e);
            SetDirty();

            return e;

        }

        /// <summary>
        /// Remove an employee in the company
        /// need add later: remove task,subtask linked with the employee
        /// </summary>
        /// <param name="e"></param>
        public void DeleteEmployee(Employee e)
        {
            SetBossModifyTime();
            foreach(var bb in PersonsDictionary)
            {
                if (bb.Value.ConversationDictionary.ContainsKey(e)) bb.Value.ConversationDictionary.Remove(e);
            }
            _personsDictionary.Remove(e.Mail);
            if (e.CurrentWorkingProject != null)
            {
                if (e.CurrentWorkingProject.Projectmanager == e) this.DeleteProjectManager(e.CurrentWorkingProject, e);
                else this.RemoveMemberFromProject(e.CurrentWorkingProject, e);
            }
            SetDirty();
        }

        /// <summary>
        /// create a random password with the length of 6
        /// </summary>
        /// <returns></returns>
        

        public MergeResult Merge(Context otherContext)
        {
            if (CompanyName != otherContext.CompanyName) return MergeResult.CompanyNameMismatch;
            //if (Boss.Mail == otherContext.Owner.Mail) _bossModifyTime = otherContext.ModifyDate;
            
            //Employee Dictionary Merge
            foreach(var e in PersonsDictionary.Values)
            {
                otherContext.PersonsDictionary.TryGetValue(e.Mail, out Employee value);
                if(value != null)
                {
                    e.Merge(value);
                }
                
                
            }
            Dictionary<string, Employee> copy = new Dictionary<string, Employee>(PersonsDictionary);

            foreach(var emp in copy)
            {
                if (otherContext.Owner.Mail == Boss.Mail || BossModifyTime < otherContext.BossModifyTime)
                {
                    if (!otherContext.PersonsDictionary.ContainsKey(emp.Value.Mail)) DeleteEmployee(emp.Value);
                }
            }
            foreach(var emp in otherContext.PersonsDictionary)
            {
                if (!PersonsDictionary.ContainsKey(emp.Key))
                {
                    Employee ep = emp.Value;
                    Employee ne = CreateEmployee(ep.Firstname, ep.Lastname, ep.Mail);
                    
                    if( ep.IP != null ) ne.IP = ep.IP; 
                    if(ep.IPString != null) ne.IPString = ep.IPString;



                }
            }


            //End Employee Dictionary Merge

            //PROJECTSDictionary MERGE
            List<string> projectToDeleteList = new List<string>();
            if (otherContext.Owner.Mail == Boss.Mail && otherContext.BossModifyTime > BossModifyTime)
            {
                BossModifyTime = otherContext.ModifyDate;
                foreach (var mp in ProjectsDictionary)
                {
                    Project MP = mp.Value;
                    if (!otherContext.ProjectsDictionary.ContainsKey(MP.Name))
                    {
                        DeleteProject(MP);
                    }
                }
            }

            foreach (var prj in ProjectsDictionary)
            {
                Project a = prj.Value;
                otherContext.ProjectsDictionary.TryGetValue(a.Name, out Project value);
                if (value != null)
                {
                    a.Merge(value);
                }

            }
            if (otherContext.Owner.Mail == Boss.Mail || otherContext.BossModifyTime > BossModifyTime)
            {


                foreach (var prj in otherContext.ProjectsDictionary)
                {
                    Project a = prj.Value;
                    if (!ProjectsDictionary.ContainsKey(prj.Key))
                    {
                        Project b = CreateProject(a.Name, a.DateBegin, a.DateLimit, FindEmployee(a.Projectmanager.Mail));
                        b.ProjectManagerModifyDate = a.ProjectManagerModifyDate;
                        b.Status = a.Status;
                        foreach (var aa in a.Members)
                        {
                            b.Members.Add(aa.Key, FindEmployee(aa.Key));
                        }
                    }
                }
            }

            //End ProjectsDictionary Merge

            SetDirty();
            return MergeResult.Success;
        }

        internal Employee FindEmployee(string mail)
        {
            PersonsDictionary.TryGetValue(mail, out Employee emp);
            return emp;
        }
    }
    




}
