using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activityTracker
{
    public partial class frmManageSubTasks : Form
    {
        List<SubTask> subTasks = new List<SubTask>();
        List<Task> tasks = new List<Task>();
        List<User> users = new List<User>();
        List<SubTask> selectedSubTasks = new List<SubTask>();

        public frmManageSubTasks()
        {
            InitializeComponent();
            UpdateBinding();
        }

        //Navigation buttons
        private void btnViewMain_Click_1(object sender, EventArgs e)
        {
            frmMain objFrmMain = new frmMain();
            this.Hide();
            objFrmMain.Show();
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

        private void btnManageSubTasks_Click_1(object sender, EventArgs e)
        {
            frmManageSubTasks objFrmManageSubTasks = new frmManageSubTasks();
            this.Hide();
            objFrmManageSubTasks.Show();
        }

        private void btnKanban_Click_1(object sender, EventArgs e)
        {
            frmKanban objFrmKanban = new frmKanban();
            this.Hide();
            objFrmKanban.Show();
        }

        private void UpdateBinding()
        {
            lstBoxTasksFound.DataSource = tasks;
            lstBoxTasksFound.DisplayMember = "FullManageTaskInfo";

            lstBoxSubTasksFound.DataSource = subTasks;
            lstBoxSubTasksFound.DisplayMember = "FullSubTaskInfo";

            lstUsersFound.DataSource = users;
            lstUsersFound.DisplayMember = "Username";

            lstSelectSubTask.DataSource = subTasks;
            lstSelectSubTask.DisplayMember = "SubTaskID";

            lstBoxParentTaskID.DataSource = tasks;
            lstBoxParentTaskID.DisplayMember = "TaskID";
        }

        private void frmManageSubTasks_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            tasks = db.GetManageTasks();
            subTasks = db.GetManageSubTasks();
            users = db.GetUsers();

            UpdateBinding();

        }

        private void btnAddSubTask_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.AddSubTask(lstBoxParentTaskID.Text, txtSubTaskDeadline.Text, txtSubTaskDescription.Text, txtSubTaskPriority.Text, txtSubTaskProgression.Text, txtSubTaskComment.Text, txtSubTaskFileLink.Text, lstSubTaskStatus.Text, lstUsersFound.Text);
            lstBoxParentTaskID.Text = "";
            txtSubTaskDeadline.Text = "";
            txtSubTaskDescription.Text = "";
            txtSubTaskPriority.Text = "";
            txtSubTaskProgression.Text = "";
            txtSubTaskComment.Text = "";
            txtSubTaskFileLink.Text = "";
            lstSubTaskStatus.Text = "";
            lstUsersFound.Text = "";
            lstSelectSubTask.Text = "";

        }

        private void btnSubTaskUpdate_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.UpdateSubTask(lstBoxParentTaskID.Text, txtSubTaskDeadline.Text, txtSubTaskDescription.Text, txtSubTaskPriority.Text, txtSubTaskProgression.Text, txtSubTaskComment.Text, txtSubTaskFileLink.Text, lstSubTaskStatus.Text, lstUsersFound.Text, lstSelectSubTask.Text);
            lstBoxParentTaskID.Text = "";
            txtSubTaskDeadline.Text = "";
            txtSubTaskDescription.Text = "";
            txtSubTaskPriority.Text = "";
            txtSubTaskProgression.Text = "";
            txtSubTaskComment.Text = "";
            txtSubTaskFileLink.Text = "";
            lstSubTaskStatus.Text = "";
            lstUsersFound.Text = "";
            lstSelectSubTask.Text = "";

        }

        private void btnDeleteSubTask_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteSubTask(lstSelectSubTask.Text);
            lstSelectSubTask.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void btnViewSelectedSubTask_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();

            selectedSubTasks = db.GetSelectedSubTasks(lstSelectSubTask.Text);

            lstBoxSelectedSubTaskInfo.DataSource = selectedSubTasks;
            lstBoxSelectedSubTaskInfo.DisplayMember = "FullSelectedSubTaskInfo";

            txtSubTaskDeadline.DataSource = selectedSubTasks;
            txtSubTaskDeadline.DisplayMember = "Deadline";

            txtSubTaskDescription.DataSource = selectedSubTasks;
            txtSubTaskDescription.DisplayMember = "Description";

            txtSubTaskComment.DataSource = selectedSubTasks;
            txtSubTaskComment.DisplayMember = "Comment";

            txtSubTaskFileLink.DataSource = selectedSubTasks;
            txtSubTaskFileLink.DisplayMember = "FileLink";
        }


    }
}
