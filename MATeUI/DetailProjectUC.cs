using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;


namespace MATeUI
{
    public partial class DetailProjectUC : UserControl
    {
        
        public DetailProjectUC()
        {
           
            //_updateProjectBtn.Click += new ButtonClickedEventHandler(UpdateProjectButonClick);
            InitializeComponent();
        }

        

        private void DetailProjectUC_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _updateProjectBtn.Click += new EventHandler(OnUpdateButtonClicked);
            _removeMemberInProjectBtn.Click += new EventHandler(OnRemoveButtonClicked);
            _addToProjectBtn.Click += new EventHandler(OnAddButtonClicked);
            _refreshPageBtn.Click += new EventHandler(OnRefreshButtonClicked);
            _addTaskToProject.Click += new EventHandler(OnAddTaskToProject);
            _changeLeaderBtn.Click += new EventHandler(OnChangeProjectManager);

            //Employee emp1 = new Employee(Context.GetContext(), "Alass", "Tra", "mate@0255.com", "bla");
            //Employee emp2 = new Employee(Context.GetContext(), "Fat", "Diarra", "mate@16.com", "bla");
            //Employee emp3 = new Employee(Context.GetContext(), "Gaston", "Diarra", "mate@36.com", "bla");
            //Employee emp4 = new Employee(Context.GetContext(), "Pape", "Konate", "mate@141.com", "bla");
            //Employee emp5 = new Employee(Context.GetContext(), "Sadian", "Malle", "mate@152.com", "bla");
            //Employee emp6 = new Employee(Context.GetContext(), "Paul", "Walker", "mate@676.com", "bla");
            //Employee emp7 = new Employee(Context.GetContext(), "Pierre", "Ferro", "mate@96.com", "bla");
            //Employee emp8 = new Employee(Context.GetContext(), "Moussa", "Berthe", "mate105@.com", "bla");
            //Employee emp9 = new Employee(Context.GetContext(), "Mamou", "Diakiss", "diakiss@.com", "bla");
            //Employee emp10 = new Employee(Context.GetContext(), "Dado", "Tra", "tra@.com", "bla");
            //Context.GetContext().PersonList.Add(emp1.Mail, emp1); Context.GetContext().PersonList.Add(emp6.Mail, emp6);
            //Context.GetContext().PersonList.Add(emp2.Mail, emp2); Context.GetContext().PersonList.Add(emp7.Mail, emp7);
            //Context.GetContext().PersonList.Add(emp3.Mail, emp3); Context.GetContext().PersonList.Add(emp8.Mail, emp8);
            //Context.GetContext().PersonList.Add(emp4.Mail, emp4); Context.GetContext().PersonList.Add(emp9.Mail, emp9);
            //Context.GetContext().PersonList.Add(emp5.Mail, emp5);

            //foreach (Employee emp in Context.GetContext().PersonList.Values)
            //{
            //    _dgEmployees.Rows.Add(emp.Firstname, emp.Lastname, emp.Mail);
            //}


            //_updateProjectBtn.Click += new EventHandler(updateProjectButonClick);
        }

        
        private void UpdateProjectButonClick(object sender, EventArgs e)
        {
            
        }

        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler UpdateProjectButtonClicked;

        /// <summary>
        /// Appel du delegate avec une expression Lambda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnUpdateButtonClicked(object sender, EventArgs e) => UpdateProjectButtonClicked?.Invoke(this, e);

        public event ButtonClickedEventHandler AddMemberInProjectButtonClicked;

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            AddMemberInProjectButtonClicked?.Invoke(this, e);
        }
        public event ButtonClickedEventHandler RefreshPageButtonClicked;

        private void OnRefreshButtonClicked(object sender, EventArgs e)
        {
            RefreshPageButtonClicked?.Invoke(this, e);
        }


        //public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler ButtonRemoveFromProjectClicked;

        private void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            ButtonRemoveFromProjectClicked?.Invoke(this, e);
        }

        public event ButtonClickedEventHandler ButtonChangeProjectManager;

        private void OnChangeProjectManager(object sender, EventArgs e)
        {
            if (ButtonChangeProjectManager != null)
                ButtonChangeProjectManager(this, e);
        }

        public event ButtonClickedEventHandler AddTaskButton;

        private void OnAddTaskToProject(object sender, EventArgs e)
        {
            if (AddTaskButton != null)
                AddTaskButton(this, e);
        }
    }
}
