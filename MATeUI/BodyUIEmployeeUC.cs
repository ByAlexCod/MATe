using System;
using System.Linq;
using System.Windows.Forms;
using MATeV2;
using static MATeUI.DetailProjectEmployeeUC;


namespace MATeUI
{
    public partial class BodyUIEmployeeUC : UserControl
    {
        public BodyUIEmployeeUC()
        {
            InitializeComponent();
        }
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
     
        public Person CurrentUser { get; set; }
        
        Project p = null;
        Tasker task = null;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (var ct = _ctxuser.ObtainAccessor())
            {
                detailProjectEmployeeUC1._taskGbx.Visible = false;
                detailProjectEmployeeUC1._subTaskGbx.Visible = false;

                Context ctx = ct.Context;
                
                foreach (Project item in ctx.ProjectsDictionary.Values)
                {
                    Employee emp = item.Members.Values.Where(em => em.Mail.Equals(_ctxuser.CurrentUser.Mail)).FirstOrDefault();
                    if(emp != null)
                    {
                        projectManagement1._projectListCbx.Items.Add(item);
                    }
                    
                }
            }

            projectManagement1._addProjectBtn.Visible = false;
            projectManagement1._deleteProjectBtn.Visible = false;

            detailProjectEmployeeUC1.ModifyTaskButtonClickeds += new ButtonClickedEventHandler(ModifyTask);
            detailProjectEmployeeUC1.ModifyTaskButtonClickeds += new ButtonClickedEventHandler(ModifySubTask);

            projectManagement1.ProjectItemChanged += new EventHandler(ShowDetailProject);
            detailProjectEmployeeUC1.CellTaskClick += new DetailProjectEmployeeUC.DataGridViewCellMouseEventHandler(ShowDetailTask);
            detailProjectEmployeeUC1.CellSubTaskClick += new DetailProjectEmployeeUC.DataGridViewCellMouseEventHandler(ChangeSubTaskItem);
            detailProjectEmployeeUC1.ChangeSubTaskButtonClicked += new ButtonClickedEventHandler(ChangeStateSubTaskButtonClicked);
            projectManagement1.MyAccountManagementEvent += new ProjectManagement.ButtonClickedEvent(ShowFormChangeAccount);

            detailProjectEmployeeUC1.CreateTaskButtonClicked += new ButtonClickedEventHandler(CreateTask);
            detailProjectEmployeeUC1.CreateSubTaskButtonClicked += new ButtonClickedEventHandler(CreateSubTask);

            detailProjectEmployeeUC1.ValidateTaskButtonClicked += new ButtonClickedEventHandler(ValidateTask);
            detailProjectEmployeeUC1.ValidateProjectButtonClicked += new ButtonClickedEventHandler(ValidateProject);
            detailProjectEmployeeUC1.DeleteTaskButtonClicked += new ButtonClickedEventHandler(DeleteSelectedTask);
            detailProjectEmployeeUC1.DeleteSubTaskButtonClicked += new ButtonClickedEventHandler(DeleteSelectedSubTask);

        }

        /// <summary>
        /// Modify Selected SubTask of the board subtasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifySubTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modify  Selected Task of the board tasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Supprime la sous-tache selectionnée dans le datagrid  des tache et supprime toutes les
        /// Sous-tache ratachées à cette tache
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelectedSubTask(object sender, EventArgs e)
        {
           

            if (p == null) return;
            if (detailProjectEmployeeUC1._dgSubTasks.Rows.Count <= 1) return;
            if (p.Tasks.Count <= 0) return;
            int indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
            if (indexTask < 0) return;
            Tasker task = p.Tasks.Values.ToList().ElementAt(indexTask);
            if (task.SubTasks.Count < 1) return;
            int indexSubTask = detailProjectEmployeeUC1._dgSubTasks.CurrentRow.Index;
            if (indexSubTask < 0) return;

            SubTask sub = task.SubTasks.Values.ToList().ElementAt(indexSubTask);
            if(sub.State == 1)
            {
                DialogResult result = MessageBox.Show("THIS SUB-TASK IS IN PROGRESS, DO YOU WANT TO DELETE IT ?", "CONFIRMATION ", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }
            if (sub.State == 2)
            {
                DialogResult result = MessageBox.Show("THIS SUB-TASK IS ALREADY FINISHED , DO YOU WANT TO DELETE IT ?", "CONFIRMATION ", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }
            p.Tasks.Remove(sub.Name);
            detailProjectEmployeeUC1._dgSubTasks.Rows.RemoveAt(indexSubTask);
            projectManagement1._projectListCbx.SelectedItem = p;
            
        }

        /// <summary>
        /// Supprime la tache selectionnée dans le tableau des sous-taches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelectedTask(object sender, EventArgs e)
        {
            if (p == null) return;
            if (p.Tasks.Count <= 0) return;
            if (detailProjectEmployeeUC1._dgTasks.Rows.Count <= 1) return;
            int indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
            if (indexTask < 0) return;
            Tasker task = p.Tasks.Values.ToList().ElementAt(indexTask);
            DialogResult result = MessageBox.Show("DO YOU WANT TO DELETE THIS TASK ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            if(task.SubTasks.Count >= 1)
            {
                result = MessageBox.Show("THIS TASK CONTAINS AT LEAST ONE SUB-TASK, WANT YOU TO DELETE IT ?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }
            p.Tasks.Remove(task.Name);

            detailProjectEmployeeUC1._dgTasks.Rows.RemoveAt(indexTask);
            detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
            projectManagement1._projectListCbx.SelectedItem = p;
            //detailProjectEmployeeUC1._dgTasks.CurrentCell = null;
            return;
        }

        /// <summary>
        /// Methode pour valider le projet seleionné dans le combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateProject(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Methode pour valider la tache selectionnée dans le tableau des taches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateTask(object sender, EventArgs e)
        {
            if (p == null) return;
            if (p.Tasks.Count <= 0) return;
            //if (detailProjectEmployeeUC1._dgTasks.CurrentCell == null) return;
            int indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
            if (indexTask < 0) return;

            Tasker task = p.Tasks.Values.ToList().ElementAt(indexTask);
            if(task.SubTasks.Count < 1)
            {
                MessageBox.Show("This task contains any sub-task");
                return;
            }
            bool trouve = false;
            foreach (SubTask item in task.SubTasks.Values)
            {
                if(item.State != 2)
                {
                    trouve = true;
                    break;
                }
            }
            if(trouve)
            {
                DialogResult res = MessageBox.Show("Do you want to validate this task ? " +
                                                   "Because there are sub-task in progress or to be done in ", "Confirmation",
                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    return;
            }
            if (p.Tasks.Values.ToList().ElementAt(indexTask).IsValidated == true)
            {
                MessageBox.Show("This task is already committed!!!");
                return;
            }
            p.Tasks.Values.ElementAt(indexTask).IsValidated = true;
            projectManagement1._projectListCbx.SelectedItem = p;
            
            MessageBox.Show("TASK VALIDATED !!!");
        }


        /// <summary>
        /// Methode pour creer une sous-tache rattachée à une tache en y affectant un membre pour l'executer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSubTask(object sender, EventArgs e)
        {
            if (p == null)
            {
                MessageBox.Show("SELECT A PROJECT FIRST");
                return;
            }
            int idx = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
            task = p.Tasks.Values.ElementAt(idx);
            if (task == null) return;

            if (detailProjectEmployeeUC1.subTaskNameTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("fill in the field name of the task ");
                return;
            }
            if (detailProjectEmployeeUC1.endSubTaskDpk.Value > p.DateLimit)
            {
                MessageBox.Show("The End Date Of The Subtask Must Not Exceed That Of The Project ");
                return;
            }
            if (detailProjectEmployeeUC1.endSubTaskDpk.Value > p.DateLimit)
            {
                MessageBox.Show("The End Date Of The Subtask Must Exceed That Of The Project");
                return;
            }
            if (detailProjectEmployeeUC1.endSubTaskDpk.Value > task.DateLimit)
            {
                MessageBox.Show("The End Date Of The Subtask Must Not Exceed That Of The Task ");
                return;
            }
            if (detailProjectEmployeeUC1.endSubTaskDpk.Value > task.DateLimit)
            {
                MessageBox.Show("The End Date Of The Subtask Must Not Exceed That Of The Task");
                return;
            }

            Employee emp = Authentification.CurrentCtxUser.CurrentUser as Employee;
            emp = (Employee)detailProjectEmployeeUC1._projectMembers.SelectedItem;
            if (emp == null) return;
            using (var ct = _ctxuser.ObtainAccessor())
            {

                SubTask sub = task.CreateSubtask(task, detailProjectEmployeeUC1.subTaskNameTbx.Text, detailProjectEmployeeUC1.endSubTaskDpk.Value, emp);

                detailProjectEmployeeUC1._dgSubTasks.Rows.Add(sub.Name, sub.DateLimit, sub.Worker);
                projectManagement1._projectListCbx.SelectedItem = p;
            }
        }


        /// <summary>
        /// Methode pour créer une tache dans le projet selectionné dans le combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTask(object sender, EventArgs e)
        {
            if (p == null)
            {
                MessageBox.Show("SELECT A PROJECT FIRST");
                return;
            }
            if (detailProjectEmployeeUC1._taskNameTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("fill in the field name of the task ");
                return;
            }

            if (detailProjectEmployeeUC1.endDateTaskDpk.Value > p.DateLimit)
            {
                MessageBox.Show("The End Date Of The Task Must Not Exceed That Of The Project ");
                return;
            }
            if (detailProjectEmployeeUC1.endDateTaskDpk.Value < p.DateBegin)
            {
                MessageBox.Show("The End Date Of The Task Must Exceed That Of The Project");
                return;
            }

            Tasker task = new Tasker(p, detailProjectEmployeeUC1._taskNameTbx.Text, detailProjectEmployeeUC1.endDateTaskDpk.Value);
            detailProjectEmployeeUC1._dgTasks.Rows.Add(task.Name, task.DateLimit, task.Project);
            
        }


        /// <summary>
        /// Methode executée quand on clique sur une ligne du tableau des sous-tache
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSubTaskItem(object sender, EventArgs e)
        {
            int index = detailProjectEmployeeUC1._dgSubTasks.CurrentRow.Index;
            if (task == null) return;
            SubTask sub = task.SubTasks.Values.ToList()[index];
            if (p == null) return;
            if (sub == null) return;

            detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
            detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
            detailProjectEmployeeUC1._doRbtn.Enabled = true;

            if (sub.State == 0)
            {
                detailProjectEmployeeUC1._toDoRbtn.Checked = true;
            }

            if (sub.State == 2)
            {
                detailProjectEmployeeUC1._inProgressRbtn.Enabled = false;
                detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                detailProjectEmployeeUC1._doRbtn.Checked = true;
            }

            if (sub.State == 1)
            {
                detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                detailProjectEmployeeUC1._inProgressRbtn.Checked = true;
            }

        }

        /// <summary>
        /// Methode executée lors d'un clic sur le button de validation d'une sous-tache
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeStateSubTaskButtonClicked(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;

                if (detailProjectEmployeeUC1._dgSubTasks.Rows.Count == 1) return;

                int index = detailProjectEmployeeUC1._dgSubTasks.CurrentRow.Index;
                if (index < 0) return;

                if (task == null) return;
                SubTask sub = task.SubTasks.Values.ToList()[index];
                if (p == null) return;
                if(!Authentification.CurrentCtxUser.CurrentUser.Mail.Equals(sub.Worker.Mail))
                {
                    MessageBox.Show("This subtask did not give you");
                    return;
                }
                int currentState = p.Tasks.Values.ToList().ElementAt(indexTask).SubTasks.Values.ToList().ElementAt(index).State;

                if (detailProjectEmployeeUC1._toDoRbtn.Checked)
                {
                    p.Tasks.Values.ToList()[indexTask].SubTasks.Values.ToList()[index].State = 0;
                }
                if (detailProjectEmployeeUC1._doRbtn.Checked)
                {
                    if (currentState == 0)
                    {
                        MessageBox.Show("The subtask must start first");
                        detailProjectEmployeeUC1._toDoRbtn.Checked = true;
                        return;
                    }
                    p.Tasks.Values.ToList().ElementAt(indexTask).SubTasks.Values.ToList().ElementAt(index).State = 2;
                    detailProjectEmployeeUC1._inProgressRbtn.Enabled = false;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                    projectManagement1._projectListCbx.SelectedItem = p;
                }
                if (detailProjectEmployeeUC1._inProgressRbtn.Checked)
                {
                    p.Tasks.Values.ToList().ElementAt(indexTask).SubTasks.Values.ToList().ElementAt(index).State = 1;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                    projectManagement1._projectListCbx.SelectedItem = p;
                }
            }

        }

        /// <summary>
        /// Methode executée lors d'un click sur une ligne du tableau des tache et qui permet
        /// De remplir le tableau des sous-tache de la tache
        /// </summary>
        int indexTask;
        private void ShowDetailTask(object sender, EventArgs e)
        {
            if(p != null)
            {
                indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
                detailProjectEmployeeUC1._createSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._validateTaskBtn.Enabled = true;
                if (indexTask >= 0)
                {
                    task = p.Tasks.Values.ToList().ElementAt(indexTask);
                    //task = p.Tasks.Where(tt => tt.Name.Equals(name)).FirstOrDefault();
                    if (task != null)
                    {
                        if (task.SubTasks.Count < 1)
                            detailProjectEmployeeUC1._validateTaskBtn.Enabled = false;
                        if(task.IsValidated == true)
                        {
                            detailProjectEmployeeUC1._createSubTaskBtn.Enabled = false;
                            detailProjectEmployeeUC1._validateTaskBtn.Enabled = false;
                        }
                        detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
                        detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
                        detailProjectEmployeeUC1._doRbtn.Enabled = true;


                        detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
                        foreach (var item in task.SubTasks.Values)
                        {
                            detailProjectEmployeeUC1._dgSubTasks.Rows.Add(item.Name, item.DateLimit, item.Worker);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Methode permettant de remplir le tableau des tache du projet 
        /// Lors de changement du projet selectionné dans le combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDetailProject(object sender, EventArgs e)
        {
            p = sender as Project;
            
            if(p != null)
            {
                bool isValided = p.IsValidated;
                if (!isValided)
                    projectManagement1._projectStatusLbl.Text = "The "+p.Name+" Project Still Not Validated Started On "+p.DateBegin;
                else
                    projectManagement1._projectStatusLbl.Text = "The " +p +" Project Has Been Validated";

                detailProjectEmployeeUC1._createTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._createSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._createTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._validateTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._changeSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._validateProjectBtn.Enabled = true;
                detailProjectEmployeeUC1._deleteSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._deleteTaskBtn.Enabled = true;
                if (p.IsValidated)
                {
                    detailProjectEmployeeUC1._createTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._createSubTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._createTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._validateTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._changeSubTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._validateProjectBtn.Enabled = false;
                    detailProjectEmployeeUC1._deleteSubTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._deleteTaskBtn.Enabled = false;
                }

                if (p.Projectmanager == null) return;
                detailProjectEmployeeUC1._taskGbx.Visible = false;
                detailProjectEmployeeUC1._subTaskGbx.Visible = false;
                if (p.Projectmanager.Mail.Equals(Authentification.CurrentCtxUser.CurrentUser.Mail))
                {
                    detailProjectEmployeeUC1._taskGbx.Visible = true;
                    detailProjectEmployeeUC1._subTaskGbx.Visible = true;
                    detailProjectEmployeeUC1._projectMembers.DataSource = p.Members.Values.ToArray();
                }

                detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
                detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
                detailProjectEmployeeUC1._doRbtn.Enabled = true;

                detailProjectEmployeeUC1._dgTasks.Rows.Clear();
                detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
                foreach (Tasker item in p.Tasks.Values)
                {
                    detailProjectEmployeeUC1._dgTasks.Rows.Add(item.Name, item.DateLimit,item.Project);
                }
            }
        }

        private void ShowFormChangeAccount(object sender,EventArgs e)
        {
            ChangeCount changeCount = new ChangeCount(Authentification.CurrentCtxUser.CurrentUser);
            changeCount.ShowDialog();
        }
    }
}
