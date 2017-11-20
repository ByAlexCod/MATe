using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Employee: Person
    {
        Project _workingproject;
        /// <summary>
        /// Ce champs permet de savoir si l'employee est à sa première connexion
        /// pour initialiser son compte et l'envoyer le fichier contexte une fois ses données reinitialisées
        /// </summary>
        bool _firstConnexion;

        public Employee(Context c,string firstname, string lastname, string mail, string password) : base(c,firstname, lastname, mail, password)
        {
            _workingproject = null;
            _firstConnexion = true;
        }

        public Employee() : base()
        {
            _workingproject = null;
            _firstConnexion = true;
        }

        public Project CurrentWorkingProject
        {
            get { return _workingproject; }
            set { _workingproject = value; }
        }

        public bool FirstConnexion
        {
            get { return _firstConnexion; }
            set { _firstConnexion = value; }
        }
        
        /// <summary>
        /// need write after.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public SubTask ModifyStateSubTask(int i)
        {
            return null;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}
