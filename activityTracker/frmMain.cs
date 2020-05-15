using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activityTracker
{
    public partial class frmMain : Form
    {
        List<Task> tasks = new List<Task>();
        List<Task> tasksByUser = new List<Task>();
        List<Task> tasksByStatus = new List<Task>();
        List<Task> tasksByProject = new List<Task>();
        List<Task> tasksByDateSelected = new List<Task>();
        List<Task> tasksByDateOverdue = new List<Task>();
        List<SubTask> subTasks = new List<SubTask>();
        List<User> users = new List<User>();
        List<Project> projects = new List<Project>();

        public frmMain()
        {
            InitializeComponent();
            UpdateBinding();
        }

        //Navigation Buttons
        private void btnKanban_Click(object sender, EventArgs e)
        {
            frmKanban objFrmKanban = new frmKanban();
            this.Hide();
            objFrmKanban.Show();
        }

        private void UpdateBinding()
        {
            lstBoxTaskView.DataSource = tasks;
            lstBoxTaskView.DisplayMember = "FullSelectedTaskInfo";

            lstBoxUserView.DataSource = users;
            lstBoxUserView.DisplayMember = "MainViewUserInfo";

            lstBoxProjectView.DataSource = projects;
            lstBoxProjectView.DisplayMember = "ProjectTitle";

            lstBoxSubTaskView.DataSource = subTasks;
            lstBoxSubTaskView.DisplayMember = "FullSelectedSubTaskInfo";

            txtTaskProject.DataSource = projects;
            txtTaskProject.DisplayMember = "ProjectTitle";

            txtTaskUser.DataSource = users;
            txtTaskUser.DisplayMember = "Username";


            
        }

        private void btnSearchTaskByUser_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            tasksByUser = db.GetTasksByUser(txtTaskUser.Text);
            lstBoxTaskView.DataSource = tasksByUser;
            lstBoxTaskView.DisplayMember = "FullSelectedTaskInfo";

            //UpdateBinding();

        }

        private void btnSearchTaskByProject_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            tasksByProject = db.GetTasksByProject(txtTaskProject.Text);
            lstBoxTaskView.DataSource = tasksByProject;
            lstBoxTaskView.DisplayMember = "FullSelectedTaskInfo";
            //UpdateBinding();
        }

        private void btnSearchTaskByStatus_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            tasksByStatus = db.GetTasksByTaskStatus(cmbTaskStatus.Text);
            lstBoxTaskView.DataSource = tasksByStatus;
            lstBoxTaskView.DisplayMember = "FullSelectedTaskInfo";
            //UpdateBinding();
        }

        private void btnTaskByDateSelected_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            tasksByDateSelected = db.GetTasksByDateSelected(txtSelectedDate.Text);
            lstBoxTaskView.DataSource = tasksByDateSelected;
            lstBoxTaskView.DisplayMember = "FullSelectedTaskInfo";

        }

        private void btnTasksByOverdue_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            tasksByDateOverdue = db.GetTasksByDateOverdue(txtBoxTodaysDate.Text);
            lstBoxTaskView.DataSource = tasksByDateOverdue;
            lstBoxTaskView.DisplayMember = "FullSelectedTaskInfo";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            tasks = db.GetManageTasks();
            subTasks = db.GetManageSubTasks();
            projects = db.GetManageProjects();
            users = db.GetUsers();

            UpdateBinding();
        }

        private void btnManageProjects_Click_1(object sender, EventArgs e)
        {
            frmManageProjects objFrmManageProjects = new frmManageProjects();
            this.Hide();
            objFrmManageProjects.Show();
        }

        private void btnManageTasks_Click_1(object sender, EventArgs e)
        {
            frmManageTasks objFrmManageTasks = new frmManageTasks();
            this.Hide();
            objFrmManageTasks.Show();
        }

        private void btnViewMain_Click_1(object sender, EventArgs e)
        {
            frmMain objFrmMain = new frmMain();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnManageSubTasks_Click_1(object sender, EventArgs e)
        {
            frmManageSubTasks objFrmManageSubTasks = new frmManageSubTasks();
            this.Hide();
            objFrmManageSubTasks.Show();
        }


    }
}
