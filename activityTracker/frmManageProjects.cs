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
    public partial class frmManageProjects : Form
    {
        List<Project> projects = new List<Project>();
        public frmManageProjects()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            lstBoxManageProjects.DataSource = projects;
            lstBoxManageProjects.DisplayMember = "ProjectTitle";

            lstBoxSelectProjects.DataSource = projects;
            lstBoxSelectProjects.DisplayMember = "ProjectTitle";
        }

        private void frmManageProjects_Load(object sender, EventArgs e)
        {
            projectRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            projectRefresh();
        }

        private void projectRefresh()
        {
            DataAccess db = new DataAccess();

            projects = db.GetManageProjects();
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

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.AddProject(txtProjectTitle.Text);
            txtProjectTitle.Text = "";

            UpdateBinding();

        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();

            db.UpdateProject(txtProjectTitle.Text, lstBoxSelectProjects.Text);
            txtProjectTitle.Text = "";
            lstBoxSelectProjects.Text = "";

            UpdateBinding();

        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeleteProject(lstBoxSelectProjects.Text);
            lstBoxSelectProjects.Text = "";

            UpdateBinding();
        }



    }
}
