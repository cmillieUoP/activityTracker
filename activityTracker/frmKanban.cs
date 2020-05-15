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
    public partial class frmKanban : Form
    {

        List<Task> toDoTasks = new List<Task>();
        List<Task> wiPTasks = new List<Task>();
        List<Task> fRTasks = new List<Task>();
        List<Task> comTasks = new List<Task>();
        List<SubTask> toDoSubTasks = new List<SubTask>();
        List<SubTask> wiPSubTasks = new List<SubTask>();
        List<SubTask> fRSubTasks = new List<SubTask>();
        List<SubTask> comSubTasks = new List<SubTask>();

        public frmKanban()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void frmKanban_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            toDoTasks = db.GetToDoKanbanTasks();
            toDoSubTasks = db.GetToDoKanbanSubTasks();
            wiPTasks = db.GetWiPKanbanTasks();
            wiPSubTasks = db.GetWiPKanbanSubTasks();
            fRTasks = db.GetFRKanbanTasks();
            fRSubTasks = db.GetFRKanbanSubTasks();
            comTasks = db.GetComKanbanTasks();
            comSubTasks = db.GetComKanbanSubTasks();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            lstBoxToDoTasks.HorizontalScrollbar = true;
            lstBoxToDoTasks.DataSource = toDoTasks;
            lstBoxToDoTasks.DisplayMember = "FullManageTaskInfo";
            lstBoxWiPTasks.HorizontalScrollbar = true;
            lstBoxWiPTasks.DataSource = wiPTasks;
            lstBoxWiPTasks.DisplayMember = "FullManageTaskInfo";
            lstBoxFRTasks.HorizontalScrollbar = true;
            lstBoxFRTasks.DataSource = fRTasks;
            lstBoxFRTasks.DisplayMember = "FullManageTaskInfo";
            lstBoxComTasks.HorizontalScrollbar = true;
            lstBoxComTasks.DataSource = comTasks;
            lstBoxComTasks.DisplayMember = "FullManageTaskInfo";

            lstBoxToDoSubTasks.HorizontalScrollbar = true;
            lstBoxToDoSubTasks.DataSource = toDoSubTasks;
            lstBoxToDoSubTasks.DisplayMember = "FullSubTaskInfo";
            lstBoxWiPSubTasks.HorizontalScrollbar = true;
            lstBoxWiPSubTasks.DataSource = wiPSubTasks;
            lstBoxWiPSubTasks.DisplayMember = "FullSubTaskInfo";
            lstBoxFRSubTasks.HorizontalScrollbar = true;
            lstBoxFRSubTasks.DataSource = fRSubTasks;
            lstBoxFRSubTasks.DisplayMember = "FullSubTaskInfo";
            lstBoxComSubTasks.HorizontalScrollbar = true;
            lstBoxComSubTasks.DataSource = comSubTasks;
            lstBoxComSubTasks.DisplayMember = "FullSubTaskInfo";

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
    }
}
