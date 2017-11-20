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
            if (this.Contx.ProjectsList.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(name, datebegin, datelimit, leader);
            this.Contx.ProjectsList.Add(newproject.Name, newproject);
            newproject.Contx = this.Contx;
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
        public Project AddEmployeToProject(Project p, Employee projectmanager, List<Employee> listem)
        {
            if (projectmanager != null)
            {
                if (projectmanager.Project != null) throw new ArgumentException("this employee is having a project remove him from his project before continue");
                p.Projectmanager.Project = null;
                projectmanager.Project = p;
                p.Projectmanager = (ProjectManager)projectmanager;
            }
            if (listem != null)
            {
                foreach (Employee e in listem)
                {
                    p.Members.Add(e);
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
            projectmanager.Project = null;
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
            e.Project = null;
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
            p.Projectmanager.Project = null;
            foreach (Employee e in p.Members)
            {
                e.Project = null;
            }
            foreach (Tasker t in p.Tasks)
            {
                t.DeleteTask();
            }
            p.Contx.ProjectsList.Remove(p.Name);
            return true;
        }
    }
}
