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
        public delegate void DataGridViewCellMouseEventHandler(object sender, EventArgs e);
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);

        public DetailProjectUC()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _updateProjectBtn.Click += new EventHandler(OnUpdateButtonClicked);
            _removeMemberInProjectBtn.Click += new EventHandler(OnRemoveButtonClicked);
            _addToProjectBtn.Click += new EventHandler(OnAddButtonClicked);
            _refreshPageBtn.Click += new EventHandler(OnRefreshButtonClicked);
            _changeLeaderBtn.Click += new EventHandler(OnChangeProjectManager);
            _dgTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellTaskChanged);
        }


        private void UpdateProjectButonClick(object sender, EventArgs e)
        {
            
        }
        public event DataGridViewCellMouseEventHandler CellTaskClick;
        private void CellTaskChanged(object sender, EventArgs e) => CellTaskClick?.Invoke(this, e);

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
