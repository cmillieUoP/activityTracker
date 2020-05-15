namespace activityTracker
{
    partial class frmManageTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTasks));
            this.lblManageTasks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewMain = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageSubTasks = new System.Windows.Forms.Button();
            this.lstBoxTasksFound = new System.Windows.Forms.ListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTaskUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstProjectsFound = new System.Windows.Forms.ListBox();
            this.lstUsersFound = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnViewSelectedTask = new System.Windows.Forms.Button();
            this.txtTaskComment = new System.Windows.Forms.ComboBox();
            this.txtTaskDescription = new System.Windows.Forms.ComboBox();
            this.cmbTaskStatus = new System.Windows.Forms.ListBox();
            this.txtTaskProgression = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTaskPriority = new System.Windows.Forms.ListBox();
            this.txtTaskFileLink = new System.Windows.Forms.ComboBox();
            this.txtTaskDeadline = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lstBoxSelectedTaskInfo = new System.Windows.Forms.ListBox();
            this.lstSelectTask = new System.Windows.Forms.ComboBox();
            this.btnManageTasks = new System.Windows.Forms.Button();
            this.btnKanban = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageTasks
            // 
            this.lblManageTasks.AutoSize = true;
            this.lblManageTasks.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageTasks.ForeColor = System.Drawing.Color.White;
            this.lblManageTasks.Location = new System.Drawing.Point(481, 11);
            this.lblManageTasks.Name = "lblManageTasks";
            this.lblManageTasks.Size = new System.Drawing.Size(144, 23);
            this.lblManageTasks.TabIndex = 8;
            this.lblManageTasks.Text = "MANAGE TASKS";
            this.lblManageTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.lblManageTasks);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 40);
            this.panel2.TabIndex = 11;
            // 
            // btnViewMain
            // 
            this.btnViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnViewMain.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnViewMain.FlatAppearance.BorderSize = 5;
            this.btnViewMain.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMain.ForeColor = System.Drawing.Color.White;
            this.btnViewMain.Location = new System.Drawing.Point(25, 486);
            this.btnViewMain.Name = "btnViewMain";
            this.btnViewMain.Size = new System.Drawing.Size(120, 36);
            this.btnViewMain.TabIndex = 10;
            this.btnViewMain.Text = "Main View";
            this.btnViewMain.UseVisualStyleBackColor = false;
            this.btnViewMain.Click += new System.EventHandler(this.btnViewMain_Click);
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageProjects.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageProjects.FlatAppearance.BorderSize = 5;
            this.btnManageProjects.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProjects.ForeColor = System.Drawing.Color.White;
            this.btnManageProjects.Location = new System.Drawing.Point(25, 528);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(120, 36);
            this.btnManageProjects.TabIndex = 9;
            this.btnManageProjects.Text = "Manage Projects";
            this.btnManageProjects.UseVisualStyleBackColor = false;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click);
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
            this.panel1.Location = new System.Drawing.Point(949, -269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 882);
            this.panel1.TabIndex = 8;
            // 
            // btnManageSubTasks
            // 
            this.btnManageSubTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageSubTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageSubTasks.FlatAppearance.BorderSize = 5;
            this.btnManageSubTasks.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSubTasks.ForeColor = System.Drawing.Color.White;
            this.btnManageSubTasks.Location = new System.Drawing.Point(25, 611);
            this.btnManageSubTasks.Name = "btnManageSubTasks";
            this.btnManageSubTasks.Size = new System.Drawing.Size(120, 36);
            this.btnManageSubTasks.TabIndex = 41;
            this.btnManageSubTasks.Text = "Manage Sub Tasks";
            this.btnManageSubTasks.UseVisualStyleBackColor = false;
            this.btnManageSubTasks.Click += new System.EventHandler(this.btnManageSubTasks_Click);
            // 
            // lstBoxTasksFound
            // 
            this.lstBoxTasksFound.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxTasksFound.FormattingEnabled = true;
            this.lstBoxTasksFound.ItemHeight = 16;
            this.lstBoxTasksFound.Location = new System.Drawing.Point(331, 86);
            this.lstBoxTasksFound.Name = "lstBoxTasksFound";
            this.lstBoxTasksFound.Size = new System.Drawing.Size(612, 68);
            this.lstBoxTasksFound.TabIndex = 12;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(646, 559);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(61, 23);
            this.btnAddTask.TabIndex = 21;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(372, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Parent Project Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(564, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(585, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Tasks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(565, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Task Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(565, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Task Deadline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(372, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Task Priority";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(565, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Task Comment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(372, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Task Progression";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(372, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Task Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(565, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Task File Link";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(372, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Task Assigned User";
            // 
            // btnTaskUpdate
            // 
            this.btnTaskUpdate.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskUpdate.Location = new System.Drawing.Point(713, 559);
            this.btnTaskUpdate.Name = "btnTaskUpdate";
            this.btnTaskUpdate.Size = new System.Drawing.Size(61, 23);
            this.btnTaskUpdate.TabIndex = 39;
            this.btnTaskUpdate.Text = "Update";
            this.btnTaskUpdate.UseVisualStyleBackColor = true;
            this.btnTaskUpdate.Click += new System.EventHandler(this.btnTaskUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(782, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstProjectsFound
            // 
            this.lstProjectsFound.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProjectsFound.FormattingEnabled = true;
            this.lstProjectsFound.ItemHeight = 16;
            this.lstProjectsFound.Location = new System.Drawing.Point(375, 381);
            this.lstProjectsFound.Name = "lstProjectsFound";
            this.lstProjectsFound.Size = new System.Drawing.Size(156, 20);
            this.lstProjectsFound.TabIndex = 42;
            // 
            // lstUsersFound
            // 
            this.lstUsersFound.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsersFound.FormattingEnabled = true;
            this.lstUsersFound.ItemHeight = 16;
            this.lstUsersFound.Location = new System.Drawing.Point(375, 562);
            this.lstUsersFound.Name = "lstUsersFound";
            this.lstUsersFound.Size = new System.Drawing.Size(156, 20);
            this.lstUsersFound.TabIndex = 43;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(21, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(276, 256);
            this.richTextBox1.TabIndex = 73;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(730, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 79;
            this.label12.Text = "Select TaskID";
            // 
            // btnViewSelectedTask
            // 
            this.btnViewSelectedTask.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSelectedTask.Location = new System.Drawing.Point(882, 313);
            this.btnViewSelectedTask.Name = "btnViewSelectedTask";
            this.btnViewSelectedTask.Size = new System.Drawing.Size(61, 23);
            this.btnViewSelectedTask.TabIndex = 84;
            this.btnViewSelectedTask.Text = "View";
            this.btnViewSelectedTask.UseVisualStyleBackColor = true;
            this.btnViewSelectedTask.Click += new System.EventHandler(this.btnViewSelectedTask_Click);
            // 
            // txtTaskComment
            // 
            this.txtTaskComment.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskComment.FormattingEnabled = true;
            this.txtTaskComment.Items.AddRange(new object[] {
            "-"});
            this.txtTaskComment.Location = new System.Drawing.Point(568, 423);
            this.txtTaskComment.Name = "txtTaskComment";
            this.txtTaskComment.Size = new System.Drawing.Size(275, 24);
            this.txtTaskComment.TabIndex = 95;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.FormattingEnabled = true;
            this.txtTaskDescription.Items.AddRange(new object[] {
            "-"});
            this.txtTaskDescription.Location = new System.Drawing.Point(568, 381);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(275, 24);
            this.txtTaskDescription.TabIndex = 94;
            // 
            // cmbTaskStatus
            // 
            this.cmbTaskStatus.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskStatus.FormattingEnabled = true;
            this.cmbTaskStatus.ItemHeight = 16;
            this.cmbTaskStatus.Items.AddRange(new object[] {
            "To Do",
            "Work In Progress",
            "For Review",
            "Complete"});
            this.cmbTaskStatus.Location = new System.Drawing.Point(375, 516);
            this.cmbTaskStatus.Name = "cmbTaskStatus";
            this.cmbTaskStatus.Size = new System.Drawing.Size(156, 20);
            this.cmbTaskStatus.TabIndex = 96;
            // 
            // txtTaskProgression
            // 
            this.txtTaskProgression.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskProgression.FormattingEnabled = true;
            this.txtTaskProgression.ItemHeight = 16;
            this.txtTaskProgression.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.txtTaskProgression.Location = new System.Drawing.Point(375, 473);
            this.txtTaskProgression.Name = "txtTaskProgression";
            this.txtTaskProgression.Size = new System.Drawing.Size(156, 20);
            this.txtTaskProgression.TabIndex = 97;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(693, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "(for Update and Delete)";
            // 
            // txtTaskPriority
            // 
            this.txtTaskPriority.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskPriority.FormattingEnabled = true;
            this.txtTaskPriority.ItemHeight = 16;
            this.txtTaskPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtTaskPriority.Location = new System.Drawing.Point(375, 427);
            this.txtTaskPriority.Name = "txtTaskPriority";
            this.txtTaskPriority.Size = new System.Drawing.Size(156, 20);
            this.txtTaskPriority.TabIndex = 103;
            // 
            // txtTaskFileLink
            // 
            this.txtTaskFileLink.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskFileLink.FormattingEnabled = true;
            this.txtTaskFileLink.Items.AddRange(new object[] {
            "-"});
            this.txtTaskFileLink.Location = new System.Drawing.Point(568, 469);
            this.txtTaskFileLink.Name = "txtTaskFileLink";
            this.txtTaskFileLink.Size = new System.Drawing.Size(275, 24);
            this.txtTaskFileLink.TabIndex = 104;
            // 
            // txtTaskDeadline
            // 
            this.txtTaskDeadline.FormattingEnabled = true;
            this.txtTaskDeadline.Items.AddRange(new object[] {
            "DD/MM/YYYY"});
            this.txtTaskDeadline.Location = new System.Drawing.Point(568, 515);
            this.txtTaskDeadline.Name = "txtTaskDeadline";
            this.txtTaskDeadline.Size = new System.Drawing.Size(275, 21);
            this.txtTaskDeadline.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(564, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 23);
            this.label16.TabIndex = 108;
            this.label16.Text = "Selected Task Info";
            // 
            // lstBoxSelectedTaskInfo
            // 
            this.lstBoxSelectedTaskInfo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxSelectedTaskInfo.FormattingEnabled = true;
            this.lstBoxSelectedTaskInfo.ItemHeight = 16;
            this.lstBoxSelectedTaskInfo.Location = new System.Drawing.Point(331, 199);
            this.lstBoxSelectedTaskInfo.Name = "lstBoxSelectedTaskInfo";
            this.lstBoxSelectedTaskInfo.Size = new System.Drawing.Size(612, 68);
            this.lstBoxSelectedTaskInfo.TabIndex = 107;
            // 
            // lstSelectTask
            // 
            this.lstSelectTask.FormattingEnabled = true;
            this.lstSelectTask.Location = new System.Drawing.Point(822, 283);
            this.lstSelectTask.Name = "lstSelectTask";
            this.lstSelectTask.Size = new System.Drawing.Size(121, 21);
            this.lstSelectTask.TabIndex = 109;
            // 
            // btnManageTasks
            // 
            this.btnManageTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageTasks.FlatAppearance.BorderSize = 5;
            this.btnManageTasks.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTasks.ForeColor = System.Drawing.Color.White;
            this.btnManageTasks.Location = new System.Drawing.Point(25, 569);
            this.btnManageTasks.Name = "btnManageTasks";
            this.btnManageTasks.Size = new System.Drawing.Size(120, 36);
            this.btnManageTasks.TabIndex = 42;
            this.btnManageTasks.Text = "Manage Tasks";
            this.btnManageTasks.UseVisualStyleBackColor = false;
            this.btnManageTasks.Click += new System.EventHandler(this.btnManageTasks_Click);
            // 
            // btnKanban
            // 
            this.btnKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnKanban.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKanban.FlatAppearance.BorderSize = 5;
            this.btnKanban.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanban.ForeColor = System.Drawing.Color.White;
            this.btnKanban.Location = new System.Drawing.Point(25, 653);
            this.btnKanban.Name = "btnKanban";
            this.btnKanban.Size = new System.Drawing.Size(120, 36);
            this.btnKanban.TabIndex = 43;
            this.btnKanban.Text = "Kanban Board";
            this.btnKanban.UseVisualStyleBackColor = false;
            this.btnKanban.Click += new System.EventHandler(this.btnKanban_Click);
            // 
            // frmManageTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1106, 613);
            this.Controls.Add(this.lstSelectTask);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lstBoxSelectedTaskInfo);
            this.Controls.Add(this.txtTaskDeadline);
            this.Controls.Add(this.txtTaskFileLink);
            this.Controls.Add(this.txtTaskPriority);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTaskProgression);
            this.Controls.Add(this.cmbTaskStatus);
            this.Controls.Add(this.txtTaskComment);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.btnViewSelectedTask);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lstUsersFound);
            this.Controls.Add(this.lstProjectsFound);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTaskUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxTasksFound);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmManageTasks";
            this.Text = "frmManageTasks";
            this.Load += new System.EventHandler(this.frmManageTasks_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewMain;
        private System.Windows.Forms.Button btnManageProjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBoxTasksFound;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTaskUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnManageSubTasks;
        private System.Windows.Forms.ListBox lstProjectsFound;
        private System.Windows.Forms.ListBox lstUsersFound;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnViewSelectedTask;
        private System.Windows.Forms.ComboBox txtTaskComment;
        private System.Windows.Forms.ComboBox txtTaskDescription;
        private System.Windows.Forms.ListBox cmbTaskStatus;
        private System.Windows.Forms.ListBox txtTaskProgression;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox txtTaskPriority;
        private System.Windows.Forms.ComboBox txtTaskFileLink;
        private System.Windows.Forms.ComboBox txtTaskDeadline;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstBoxSelectedTaskInfo;
        private System.Windows.Forms.ComboBox lstSelectTask;
        private System.Windows.Forms.Button btnKanban;
        private System.Windows.Forms.Button btnManageTasks;
    }
}