namespace activityTracker
{
    partial class frmKanban
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKanbanView = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKanban = new System.Windows.Forms.Button();
            this.btnManageTasks = new System.Windows.Forms.Button();
            this.btnManageSubTasks = new System.Windows.Forms.Button();
            this.btnViewMain = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBoxToDoSubTasks = new System.Windows.Forms.ListBox();
            this.lstBoxToDoTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBoxWiPSubTasks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxWiPTasks = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstBoxFRSubTasks = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxFRTasks = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBoxComSubTasks = new System.Windows.Forms.ListBox();
            this.lstBoxComTasks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.lblKanbanView);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 40);
            this.panel2.TabIndex = 13;
            // 
            // lblKanbanView
            // 
            this.lblKanbanView.AutoSize = true;
            this.lblKanbanView.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanbanView.ForeColor = System.Drawing.Color.White;
            this.lblKanbanView.Location = new System.Drawing.Point(494, 9);
            this.lblKanbanView.Name = "lblKanbanView";
            this.lblKanbanView.Size = new System.Drawing.Size(148, 23);
            this.lblKanbanView.TabIndex = 8;
            this.lblKanbanView.Text = "KANBAN BOARD";
            this.lblKanbanView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Location = new System.Drawing.Point(1041, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 683);
            this.panel1.TabIndex = 12;
            // 
            // btnKanban
            // 
            this.btnKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnKanban.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKanban.FlatAppearance.BorderSize = 5;
            this.btnKanban.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanban.ForeColor = System.Drawing.Color.White;
            this.btnKanban.Location = new System.Drawing.Point(20, 384);
            this.btnKanban.Name = "btnKanban";
            this.btnKanban.Size = new System.Drawing.Size(120, 36);
            this.btnKanban.TabIndex = 48;
            this.btnKanban.Text = "Kanban Board";
            this.btnKanban.UseVisualStyleBackColor = false;
            this.btnKanban.Click += new System.EventHandler(this.btnKanban_Click_1);
            // 
            // btnManageTasks
            // 
            this.btnManageTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnManageTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnManageTasks.FlatAppearance.BorderSize = 5;
            this.btnManageTasks.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTasks.ForeColor = System.Drawing.Color.White;
            this.btnManageTasks.Location = new System.Drawing.Point(20, 300);
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
            this.btnManageSubTasks.Location = new System.Drawing.Point(20, 342);
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
            this.btnViewMain.Location = new System.Drawing.Point(20, 217);
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
            this.btnManageProjects.Location = new System.Drawing.Point(20, 259);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(120, 36);
            this.btnManageProjects.TabIndex = 44;
            this.btnManageProjects.Text = "Manage Projects";
            this.btnManageProjects.UseVisualStyleBackColor = false;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lstBoxToDoSubTasks);
            this.panel3.Controls.Add(this.lstBoxToDoTasks);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 612);
            this.panel3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(83, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sub Tasks";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tasks";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxToDoSubTasks
            // 
            this.lstBoxToDoSubTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxToDoSubTasks.FormattingEnabled = true;
            this.lstBoxToDoSubTasks.ItemHeight = 16;
            this.lstBoxToDoSubTasks.Location = new System.Drawing.Point(16, 329);
            this.lstBoxToDoSubTasks.Name = "lstBoxToDoSubTasks";
            this.lstBoxToDoSubTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxToDoSubTasks.TabIndex = 20;
            // 
            // lstBoxToDoTasks
            // 
            this.lstBoxToDoTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxToDoTasks.FormattingEnabled = true;
            this.lstBoxToDoTasks.ItemHeight = 16;
            this.lstBoxToDoTasks.Location = new System.Drawing.Point(16, 82);
            this.lstBoxToDoTasks.Name = "lstBoxToDoTasks";
            this.lstBoxToDoTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxToDoTasks.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "TO DO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lstBoxWiPSubTasks);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lstBoxWiPTasks);
            this.panel4.Location = new System.Drawing.Point(270, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 612);
            this.panel4.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(79, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sub Tasks";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tasks";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxWiPSubTasks
            // 
            this.lstBoxWiPSubTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxWiPSubTasks.FormattingEnabled = true;
            this.lstBoxWiPSubTasks.ItemHeight = 16;
            this.lstBoxWiPSubTasks.Location = new System.Drawing.Point(17, 329);
            this.lstBoxWiPSubTasks.Name = "lstBoxWiPSubTasks";
            this.lstBoxWiPSubTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxWiPSubTasks.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "WORK IN PROGRESS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxWiPTasks
            // 
            this.lstBoxWiPTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxWiPTasks.FormattingEnabled = true;
            this.lstBoxWiPTasks.ItemHeight = 16;
            this.lstBoxWiPTasks.Location = new System.Drawing.Point(17, 82);
            this.lstBoxWiPTasks.Name = "lstBoxWiPTasks";
            this.lstBoxWiPTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxWiPTasks.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lstBoxFRSubTasks);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lstBoxFRTasks);
            this.panel5.Location = new System.Drawing.Point(524, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 612);
            this.panel5.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(87, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sub Tasks";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(101, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tasks";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxFRSubTasks
            // 
            this.lstBoxFRSubTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxFRSubTasks.FormattingEnabled = true;
            this.lstBoxFRSubTasks.ItemHeight = 16;
            this.lstBoxFRSubTasks.Location = new System.Drawing.Point(15, 329);
            this.lstBoxFRSubTasks.Name = "lstBoxFRSubTasks";
            this.lstBoxFRSubTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxFRSubTasks.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "FOR REVIEW";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxFRTasks
            // 
            this.lstBoxFRTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxFRTasks.FormattingEnabled = true;
            this.lstBoxFRTasks.ItemHeight = 16;
            this.lstBoxFRTasks.Location = new System.Drawing.Point(15, 82);
            this.lstBoxFRTasks.Name = "lstBoxFRTasks";
            this.lstBoxFRTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxFRTasks.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lstBoxComSubTasks);
            this.panel6.Controls.Add(this.lstBoxComTasks);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(778, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 612);
            this.panel6.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(89, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Sub Tasks";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(100, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tasks";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxComSubTasks
            // 
            this.lstBoxComSubTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxComSubTasks.FormattingEnabled = true;
            this.lstBoxComSubTasks.ItemHeight = 16;
            this.lstBoxComSubTasks.Location = new System.Drawing.Point(15, 329);
            this.lstBoxComSubTasks.Name = "lstBoxComSubTasks";
            this.lstBoxComSubTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxComSubTasks.TabIndex = 26;
            // 
            // lstBoxComTasks
            // 
            this.lstBoxComTasks.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxComTasks.FormattingEnabled = true;
            this.lstBoxComTasks.ItemHeight = 16;
            this.lstBoxComTasks.Location = new System.Drawing.Point(15, 82);
            this.lstBoxComTasks.Name = "lstBoxComTasks";
            this.lstBoxComTasks.Size = new System.Drawing.Size(219, 212);
            this.lstBoxComTasks.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "COMPLETE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1193, 679);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmKanban";
            this.Text = "frmKanban";
            this.Load += new System.EventHandler(this.frmKanban_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKanbanView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKanban;
        private System.Windows.Forms.Button btnManageTasks;
        private System.Windows.Forms.Button btnManageSubTasks;
        private System.Windows.Forms.Button btnViewMain;
        private System.Windows.Forms.Button btnManageProjects;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstBoxToDoSubTasks;
        private System.Windows.Forms.ListBox lstBoxToDoTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lstBoxWiPSubTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxWiPTasks;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lstBoxFRSubTasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxFRTasks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lstBoxComSubTasks;
        private System.Windows.Forms.ListBox lstBoxComTasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}