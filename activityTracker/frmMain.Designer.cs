namespace activityTracker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKanban = new System.Windows.Forms.Button();
            this.btnManageTasks = new System.Windows.Forms.Button();
            this.btnManageSubTasks = new System.Windows.Forms.Button();
            this.btnViewMain = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWIP = new System.Windows.Forms.Label();
            this.lstBoxTaskView = new System.Windows.Forms.ListBox();
            this.lblTaskUser = new System.Windows.Forms.Label();
            this.lblTaskProject = new System.Windows.Forms.Label();
            this.btnSearchTaskByUser = new System.Windows.Forms.Button();
            this.lstBoxUserView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBoxSubTaskView = new System.Windows.Forms.ListBox();
            this.lstBoxProjectView = new System.Windows.Forms.ListBox();
            this.txtTaskProject = new System.Windows.Forms.ComboBox();
            this.txtTaskUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchTaskByProject = new System.Windows.Forms.Button();
            this.btnSearchTaskByStatus = new System.Windows.Forms.Button();
            this.cmbTaskStatus = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectedDate = new System.Windows.Forms.MaskedTextBox();
            this.btnTaskByDateSelected = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTasksByOverdue = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxTodaysDate = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnKanban);
            this.panel1.Controls.Add(this.btnManageTasks);
            this.panel1.Controls.Add(this.btnManageSubTasks);
            this.panel1.Controls.Add(this.btnViewMain);
            this.panel1.Controls.Add(this.btnManageProjects);
            this.panel1.Location = new System.Drawing.Point(902, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 791);
            this.panel1.TabIndex = 0;
            // 
            // btnKanban
            // 
            this.btnKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnKanban.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKanban.FlatAppearance.BorderSize = 5;
            this.btnKanban.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanban.ForeColor = System.Drawing.Color.White;
            this.btnKanban.Location = new System.Drawing.Point(18, 461);
            this.btnKanban.Name = "btnKanban";
            this.btnKanban.Size = new System.Drawing.Size(120, 36);
            this.btnKanban.TabIndex = 48;
            this.btnKanban.Text = "Kanban Board";
            this.btnKanban.UseVisualStyleBackColor = false;
            this.btnKanban.Click += new System.EventHandler(this.btnKanban_Click);
            // 
            // btnManageTasks
            // 
            this.btnManageTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageTasks.FlatAppearance.BorderSize = 5;
            this.btnManageTasks.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTasks.ForeColor = System.Drawing.Color.White;
            this.btnManageTasks.Location = new System.Drawing.Point(18, 377);
            this.btnManageTasks.Name = "btnManageTasks";
            this.btnManageTasks.Size = new System.Drawing.Size(120, 36);
            this.btnManageTasks.TabIndex = 47;
            this.btnManageTasks.Text = "Manage Tasks";
            this.btnManageTasks.UseVisualStyleBackColor = false;
            this.btnManageTasks.Click += new System.EventHandler(this.btnManageTasks_Click_1);
            // 
            // btnManageSubTasks
            // 
            this.btnManageSubTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageSubTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageSubTasks.FlatAppearance.BorderSize = 5;
            this.btnManageSubTasks.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSubTasks.ForeColor = System.Drawing.Color.White;
            this.btnManageSubTasks.Location = new System.Drawing.Point(18, 419);
            this.btnManageSubTasks.Name = "btnManageSubTasks";
            this.btnManageSubTasks.Size = new System.Drawing.Size(120, 36);
            this.btnManageSubTasks.TabIndex = 46;
            this.btnManageSubTasks.Text = "Manage Sub Tasks";
            this.btnManageSubTasks.UseVisualStyleBackColor = false;
            this.btnManageSubTasks.Click += new System.EventHandler(this.btnManageSubTasks_Click_1);
            // 
            // btnViewMain
            // 
            this.btnViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnViewMain.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnViewMain.FlatAppearance.BorderSize = 5;
            this.btnViewMain.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMain.ForeColor = System.Drawing.Color.White;
            this.btnViewMain.Location = new System.Drawing.Point(18, 294);
            this.btnViewMain.Name = "btnViewMain";
            this.btnViewMain.Size = new System.Drawing.Size(120, 36);
            this.btnViewMain.TabIndex = 45;
            this.btnViewMain.Text = "Main View";
            this.btnViewMain.UseVisualStyleBackColor = false;
            this.btnViewMain.Click += new System.EventHandler(this.btnViewMain_Click_1);
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageProjects.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageProjects.FlatAppearance.BorderSize = 5;
            this.btnManageProjects.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProjects.ForeColor = System.Drawing.Color.White;
            this.btnManageProjects.Location = new System.Drawing.Point(18, 336);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(120, 36);
            this.btnManageProjects.TabIndex = 44;
            this.btnManageProjects.Text = "Manage Projects";
            this.btnManageProjects.UseVisualStyleBackColor = false;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.lblWIP);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 40);
            this.panel2.TabIndex = 7;
            // 
            // lblWIP
            // 
            this.lblWIP.AutoSize = true;
            this.lblWIP.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWIP.ForeColor = System.Drawing.Color.White;
            this.lblWIP.Location = new System.Drawing.Point(392, 9);
            this.lblWIP.Name = "lblWIP";
            this.lblWIP.Size = new System.Drawing.Size(103, 23);
            this.lblWIP.TabIndex = 8;
            this.lblWIP.Text = "MAIN VIEW";
            this.lblWIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxTaskView
            // 
            this.lstBoxTaskView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxTaskView.FormattingEnabled = true;
            this.lstBoxTaskView.HorizontalScrollbar = true;
            this.lstBoxTaskView.ItemHeight = 16;
            this.lstBoxTaskView.Location = new System.Drawing.Point(18, 46);
            this.lstBoxTaskView.Name = "lstBoxTaskView";
            this.lstBoxTaskView.Size = new System.Drawing.Size(799, 100);
            this.lstBoxTaskView.TabIndex = 8;
            // 
            // lblTaskUser
            // 
            this.lblTaskUser.AutoSize = true;
            this.lblTaskUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.lblTaskUser.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskUser.ForeColor = System.Drawing.Color.White;
            this.lblTaskUser.Location = new System.Drawing.Point(15, 200);
            this.lblTaskUser.Name = "lblTaskUser";
            this.lblTaskUser.Size = new System.Drawing.Size(37, 16);
            this.lblTaskUser.TabIndex = 9;
            this.lblTaskUser.Text = "User";
            // 
            // lblTaskProject
            // 
            this.lblTaskProject.AutoSize = true;
            this.lblTaskProject.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskProject.ForeColor = System.Drawing.Color.White;
            this.lblTaskProject.Location = new System.Drawing.Point(320, 202);
            this.lblTaskProject.Name = "lblTaskProject";
            this.lblTaskProject.Size = new System.Drawing.Size(49, 16);
            this.lblTaskProject.TabIndex = 10;
            this.lblTaskProject.Text = "Project";
            // 
            // btnSearchTaskByUser
            // 
            this.btnSearchTaskByUser.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTaskByUser.Location = new System.Drawing.Point(125, 227);
            this.btnSearchTaskByUser.Name = "btnSearchTaskByUser";
            this.btnSearchTaskByUser.Size = new System.Drawing.Size(54, 23);
            this.btnSearchTaskByUser.TabIndex = 13;
            this.btnSearchTaskByUser.Text = "Search";
            this.btnSearchTaskByUser.UseVisualStyleBackColor = true;
            this.btnSearchTaskByUser.Click += new System.EventHandler(this.btnSearchTaskByUser_Click);
            // 
            // lstBoxUserView
            // 
            this.lstBoxUserView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxUserView.FormattingEnabled = true;
            this.lstBoxUserView.ItemHeight = 16;
            this.lstBoxUserView.Location = new System.Drawing.Point(476, 99);
            this.lstBoxUserView.Name = "lstBoxUserView";
            this.lstBoxUserView.Size = new System.Drawing.Size(371, 68);
            this.lstBoxUserView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(387, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(626, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Users";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Filter Tasks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(396, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Sub Tasks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(169, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Projects";
            // 
            // lstBoxSubTaskView
            // 
            this.lstBoxSubTaskView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxSubTaskView.FormattingEnabled = true;
            this.lstBoxSubTaskView.ItemHeight = 16;
            this.lstBoxSubTaskView.Location = new System.Drawing.Point(48, 640);
            this.lstBoxSubTaskView.Name = "lstBoxSubTaskView";
            this.lstBoxSubTaskView.Size = new System.Drawing.Size(799, 116);
            this.lstBoxSubTaskView.TabIndex = 49;
            // 
            // lstBoxProjectView
            // 
            this.lstBoxProjectView.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxProjectView.FormattingEnabled = true;
            this.lstBoxProjectView.ItemHeight = 16;
            this.lstBoxProjectView.Location = new System.Drawing.Point(18, 36);
            this.lstBoxProjectView.Name = "lstBoxProjectView";
            this.lstBoxProjectView.Size = new System.Drawing.Size(371, 68);
            this.lstBoxProjectView.TabIndex = 48;
            // 
            // txtTaskProject
            // 
            this.txtTaskProject.FormattingEnabled = true;
            this.txtTaskProject.Location = new System.Drawing.Point(375, 200);
            this.txtTaskProject.Name = "txtTaskProject";
            this.txtTaskProject.Size = new System.Drawing.Size(121, 21);
            this.txtTaskProject.TabIndex = 52;
            // 
            // txtTaskUser
            // 
            this.txtTaskUser.FormattingEnabled = true;
            this.txtTaskUser.Location = new System.Drawing.Point(58, 200);
            this.txtTaskUser.Name = "txtTaskUser";
            this.txtTaskUser.Size = new System.Drawing.Size(121, 21);
            this.txtTaskUser.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(617, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Task Status";
            // 
            // btnSearchTaskByProject
            // 
            this.btnSearchTaskByProject.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTaskByProject.Location = new System.Drawing.Point(437, 227);
            this.btnSearchTaskByProject.Name = "btnSearchTaskByProject";
            this.btnSearchTaskByProject.Size = new System.Drawing.Size(59, 23);
            this.btnSearchTaskByProject.TabIndex = 56;
            this.btnSearchTaskByProject.Text = "Search";
            this.btnSearchTaskByProject.UseVisualStyleBackColor = true;
            this.btnSearchTaskByProject.Click += new System.EventHandler(this.btnSearchTaskByProject_Click);
            // 
            // btnSearchTaskByStatus
            // 
            this.btnSearchTaskByStatus.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTaskByStatus.Location = new System.Drawing.Point(761, 222);
            this.btnSearchTaskByStatus.Name = "btnSearchTaskByStatus";
            this.btnSearchTaskByStatus.Size = new System.Drawing.Size(56, 23);
            this.btnSearchTaskByStatus.TabIndex = 57;
            this.btnSearchTaskByStatus.Text = "Search";
            this.btnSearchTaskByStatus.UseVisualStyleBackColor = true;
            this.btnSearchTaskByStatus.Click += new System.EventHandler(this.btnSearchTaskByStatus_Click);
            // 
            // cmbTaskStatus
            // 
            this.cmbTaskStatus.FormattingEnabled = true;
            this.cmbTaskStatus.Items.AddRange(new object[] {
            "To Do",
            "Work In Progress",
            "For Review",
            "Complete"});
            this.cmbTaskStatus.Location = new System.Drawing.Point(697, 199);
            this.cmbTaskStatus.Name = "cmbTaskStatus";
            this.cmbTaskStatus.Size = new System.Drawing.Size(120, 17);
            this.cmbTaskStatus.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(195, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Deadline";
            // 
            // txtSelectedDate
            // 
            this.txtSelectedDate.Location = new System.Drawing.Point(260, 276);
            this.txtSelectedDate.Mask = "00/00/0000";
            this.txtSelectedDate.Name = "txtSelectedDate";
            this.txtSelectedDate.Size = new System.Drawing.Size(71, 20);
            this.txtSelectedDate.TabIndex = 60;
            this.txtSelectedDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnTaskByDateSelected
            // 
            this.btnTaskByDateSelected.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskByDateSelected.Location = new System.Drawing.Point(277, 302);
            this.btnTaskByDateSelected.Name = "btnTaskByDateSelected";
            this.btnTaskByDateSelected.Size = new System.Drawing.Size(54, 23);
            this.btnTaskByDateSelected.TabIndex = 61;
            this.btnTaskByDateSelected.Text = "Search";
            this.btnTaskByDateSelected.UseVisualStyleBackColor = true;
            this.btnTaskByDateSelected.Click += new System.EventHandler(this.btnTaskByDateSelected_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(503, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Overdue Tasks";
            // 
            // btnTasksByOverdue
            // 
            this.btnTasksByOverdue.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasksByOverdue.Location = new System.Drawing.Point(620, 302);
            this.btnTasksByOverdue.Name = "btnTasksByOverdue";
            this.btnTasksByOverdue.Size = new System.Drawing.Size(54, 23);
            this.btnTasksByOverdue.TabIndex = 63;
            this.btnTasksByOverdue.Text = "Search";
            this.btnTasksByOverdue.UseVisualStyleBackColor = true;
            this.btnTasksByOverdue.Click += new System.EventHandler(this.btnTasksByOverdue_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.panel3.Controls.Add(this.txtTaskUser);
            this.panel3.Controls.Add(this.btnSearchTaskByProject);
            this.panel3.Controls.Add(this.cmbTaskStatus);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtTaskProject);
            this.panel3.Controls.Add(this.btnSearchTaskByUser);
            this.panel3.Controls.Add(this.btnSearchTaskByStatus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTaskUser);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lstBoxTaskView);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSelectedDate);
            this.panel3.Controls.Add(this.btnTaskByDateSelected);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnTasksByOverdue);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtBoxTodaysDate);
            this.panel3.Controls.Add(this.lblTaskProject);
            this.panel3.Location = new System.Drawing.Point(30, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 364);
            this.panel3.TabIndex = 64;
            // 
            // txtBoxTodaysDate
            // 
            this.txtBoxTodaysDate.Location = new System.Drawing.Point(602, 276);
            this.txtBoxTodaysDate.Mask = "00/00/0000";
            this.txtBoxTodaysDate.Name = "txtBoxTodaysDate";
            this.txtBoxTodaysDate.Size = new System.Drawing.Size(72, 20);
            this.txtBoxTodaysDate.TabIndex = 61;
            this.txtBoxTodaysDate.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(488, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "(Enter Today\'s Date)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(148, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "(Enter Due By Date)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.panel4.Controls.Add(this.lstBoxProjectView);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(30, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 134);
            this.panel4.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.panel5.Location = new System.Drawing.Point(455, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(414, 134);
            this.panel5.TabIndex = 66;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(103)))));
            this.panel6.Location = new System.Drawing.Point(30, 600);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(839, 176);
            this.panel6.TabIndex = 67;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1054, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxSubTaskView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBoxUserView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWIP;
        private System.Windows.Forms.ListBox lstBoxTaskView;
        private System.Windows.Forms.Label lblTaskUser;
        private System.Windows.Forms.Label lblTaskProject;
        private System.Windows.Forms.Button btnSearchTaskByUser;
        private System.Windows.Forms.ListBox lstBoxUserView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBoxSubTaskView;
        private System.Windows.Forms.ListBox lstBoxProjectView;
        private System.Windows.Forms.Button btnKanban;
        private System.Windows.Forms.Button btnManageTasks;
        private System.Windows.Forms.Button btnManageSubTasks;
        private System.Windows.Forms.Button btnViewMain;
        private System.Windows.Forms.Button btnManageProjects;
        private System.Windows.Forms.ComboBox txtTaskProject;
        private System.Windows.Forms.ComboBox txtTaskUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchTaskByProject;
        private System.Windows.Forms.Button btnSearchTaskByStatus;
        private System.Windows.Forms.ListBox cmbTaskStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtSelectedDate;
        private System.Windows.Forms.Button btnTaskByDateSelected;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTasksByOverdue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txtBoxTodaysDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}