using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public partial class Boss : Person
    {
        /// <summary>
        /// boss create a new project by fill the name, date begin,date limit of the project
        /// and can add a projectmanager for the first time if he want
        /// if not by default the project has no projectmanager
        /// </summary>
        /// <param name="name"></param>
        /// <param name="datebegin"></param>
        /// <param name="datelimit"></param>
        /// <param name="leader"></param>
        /// <returns></returns>
        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader = null)
        {
            if (this.Context.ProjectsList.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(name, datebegin, datelimit, leader);
            this.Context.ProjectsList.Add(newproject.Name, newproject);
            //newproject.Contx = this.Contx;
            return newproject;
        }

        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader, List<Employee> listperson)
        {
            if (this.Context.ProjectsList.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(name, datebegin, datelimit, leader);
            foreach (Employee e in listperson)
            {
                newproject.Members.Add(e);
            }
            this.Context.ProjectsList.Add(newproject.Name, newproject);
            //newproject.Contx = this.Contx;
            return newproject;
        }

        /// <summary>
        /// modify name, datebegin and datelimit of a project
        /// </summary>
        /// <param name="p"></param>
        /// <param name="name"></param>
        /// <param name="datebegin"></param>
        /// <param name="datelimit"></param>
        /// <returns></returns>
        public Project ModifyProject(Project p, string name, DateTime datebegin, DateTime datelimit)
        {
            if (name != null) p.Name = name;
            if (datebegin != DateTime.MinValue) p.DateBegin = datebegin;
            if (datelimit != DateTime.MinValue) p.DateLimit = datelimit;
            return p;
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
                    p.Members.Add(e);
                    e.CurrentWorkingProject = p;
                }
            }
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
        public Project DeleteMember(Project p,Employee e)
        {
            e.CurrentWorkingProject = null;
            p.Members.Remove(e);
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
            foreach (Employee e in p.Members)
            {
                e.CurrentWorkingProject = null;
            }
            foreach (Tasker t in p.Tasks)
            {
                t.DeleteTask();
            }
            MATeV2.Context.GetContext().ProjectsList.Remove(p.Name);
            return true;
        }
    }
}
