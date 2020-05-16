using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activityTracker
{
    public partial class frmManageTasks : Form
    {
        List<Task> tasks = new List<Task>();
        List<Project> projects = new List<Project>();
        List<User> users = new List<User>();
        List<Task> selectedTasks = new List<Task>();

        public frmManageTasks()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            lstBoxTasksFound.DataSource = tasks;
            lstBoxTasksFound.DisplayMember = "FullManageTaskInfo";

            lstProjectsFound.DataSource = projects;
            lstProjectsFound.DisplayMember = "ProjectTitle";

            lstUsersFound.DataSource = users;
            lstUsersFound.DisplayMember = "Username";

            lstSelectTask.DataSource = tasks;
            lstSelectTask.DisplayMember = "TaskID";

        }

        private void taskRefresh()
        {
            DataAccess db = new DataAccess();

            tasks = db.GetManageTasks();
            projects = db.GetManageProjects();
            users = db.GetUsers();

            UpdateBinding();
        }

        private void frmManageTasks_Load(object sender, EventArgs e)
        {
            taskRefresh();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            taskRefresh();
        }

        //Navigation buttons
        private void btnViewMain_Click(object sender, EventArgs e)
        {
            frmMain objFrmMain = new frmMain();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            frmManageProjects objFrmManageProjects = new frmManageProjects();
            this.Hide();
            objFrmManageProjects.Show();
        }

        private void btnManageTasks_Click(object sender, EventArgs e)
        {
            frmManageTasks objFrmManageTasks = new frmManageTasks();
            this.Hide();
            objFrmManageTasks.Show();
        }

        private void btnManageSubTasks_Click(object sender, EventArgs e)
        {
            frmManageSubTasks objFrmManageSubTasks = new frmManageSubTasks();
            this.Hide();
            objFrmManageSubTasks.Show();
        }

        private void btnKanban_Click(object sender, EventArgs e)
        {
            frmKanban objFrmKanban = new frmKanban();
            this.Hide();
            objFrmKanban.Show();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.AddTask(lstProjectsFound.Text, txtTaskDeadline.Text, txtTaskDescription.Text, txtTaskPriority.Text, txtTaskProgression.Text, txtTaskComment.Text, txtTaskFileLink.Text, cmbTaskStatus.Text, lstUsersFound.Text);
            lstProjectsFound.Text = "";
            txtTaskDeadline.Text = "";
            txtTaskDescription.Text = "";
            txtTaskPriority.Text = "";
            txtTaskProgression.Text = "";
            txtTaskComment.Text = "";
            txtTaskFileLink.Text = "";
            cmbTaskStatus.Text = "";
            lstUsersFound.Text = "";

        }

        
        private void btnTaskUpdate_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();

            db.UpdateTask(lstProjectsFound.Text, txtTaskDeadline.Text, txtTaskDescription.Text, txtTaskPriority.Text, txtTaskProgression.Text, txtTaskComment.Text, txtTaskFileLink.Text, cmbTaskStatus.Text, lstUsersFound.Text, lstSelectTask.Text);
            lstProjectsFound.Text = "";
            txtTaskDeadline.Text = "";
            txtTaskDescription.Text = "";
            txtTaskPriority.Text = "";
            txtTaskProgression.Text = "";
            txtTaskComment.Text = "";
            txtTaskFileLink.Text = "";
            cmbTaskStatus.Text = "";
            lstUsersFound.Text = "";
            lstSelectTask.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeleteTask(lstSelectTask.Text);
            lstSelectTask.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void btnViewSelectedTask_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            selectedTasks = db.GetSelectedTasks(lstSelectTask.Text);

            lstBoxSelectedTaskInfo.DataSource = selectedTasks;
            lstBoxSelectedTaskInfo.DisplayMember = "FullSelectedTaskInfo";

            txtTaskDeadline.DataSource = selectedTasks;
            txtTaskDeadline.DisplayMember = "Deadline";

            txtTaskDescription.DataSource = selectedTasks;
            txtTaskDescription.DisplayMember = "Description";

            txtTaskComment.DataSource = selectedTasks;
            txtTaskComment.DisplayMember = "Comment";

            txtTaskFileLink.DataSource = selectedTasks;
            txtTaskFileLink.DisplayMember = "FileLink";
            UpdateBinding();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageTasks objFrmManageTasks = new frmManageTasks();
            this.Hide();
            objFrmManageTasks.Show();
        }


    }
}
