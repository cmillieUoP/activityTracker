namespace activityTracker
{
    partial class frmManageProjects
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
            this.lblManageProjects = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKanban = new System.Windows.Forms.Button();
            this.btnManageTasks = new System.Windows.Forms.Button();
            this.btnManageSubTasks = new System.Windows.Forms.Button();
            this.btnViewMain = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.lstBoxManageProjects = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.lstBoxSelectProjects = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageProjects
            // 
            this.lblManageProjects.AutoSize = true;
            this.lblManageProjects.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProjects.ForeColor = System.Drawing.Color.White;
            this.lblManageProjects.Location = new System.Drawing.Point(349, 11);
            this.lblManageProjects.Name = "lblManageProjects";
            this.lblManageProjects.Size = new System.Drawing.Size(179, 23);
            this.lblManageProjects.TabIndex = 8;
            this.lblManageProjects.Text = "MANAGE PROJECTS";
            this.lblManageProjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.lblManageProjects);
            this.panel2.Location = new System.Drawing.Point(-6, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 40);
            this.panel2.TabIndex = 11;
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
            this.panel1.Location = new System.Drawing.Point(848, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 637);
            this.panel1.TabIndex = 8;
            // 
            // btnKanban
            // 
            this.btnKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.btnKanban.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKanban.FlatAppearance.BorderSize = 5;
            this.btnKanban.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanban.ForeColor = System.Drawing.Color.White;
            this.btnKanban.Location = new System.Drawing.Point(17, 384);
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
            this.btnManageTasks.Location = new System.Drawing.Point(17, 300);
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
            this.btnManageSubTasks.Location = new System.Drawing.Point(17, 342);
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
            this.btnViewMain.Location = new System.Drawing.Point(17, 217);
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
            this.btnManageProjects.Location = new System.Drawing.Point(17, 259);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(120, 36);
            this.btnManageProjects.TabIndex = 44;
            this.btnManageProjects.Text = "Manage Projects";
            this.btnManageProjects.UseVisualStyleBackColor = false;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click_1);
            // 
            // lstBoxManageProjects
            // 
            this.lstBoxManageProjects.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxManageProjects.FormattingEnabled = true;
            this.lstBoxManageProjects.ItemHeight = 16;
            this.lstBoxManageProjects.Location = new System.Drawing.Point(66, 98);
            this.lstBoxManageProjects.Name = "lstBoxManageProjects";
            this.lstBoxManageProjects.Size = new System.Drawing.Size(678, 132);
            this.lstBoxManageProjects.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(361, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(62, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Projects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter Project Title (Add and Update):";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(257, 428);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(61, 23);
            this.btnAddProject.TabIndex = 16;
            this.btnAddProject.Text = "Add";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectTitle.Location = new System.Drawing.Point(66, 351);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(252, 23);
            this.txtProjectTitle.TabIndex = 17;
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProject.Location = new System.Drawing.Point(347, 428);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(61, 23);
            this.btnUpdateProject.TabIndex = 18;
            this.btnUpdateProject.Text = "Update";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // lstBoxSelectProjects
            // 
            this.lstBoxSelectProjects.FormattingEnabled = true;
            this.lstBoxSelectProjects.Location = new System.Drawing.Point(375, 351);
            this.lstBoxSelectProjects.Name = "lstBoxSelectProjects";
            this.lstBoxSelectProjects.Size = new System.Drawing.Size(253, 30);
            this.lstBoxSelectProjects.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select Project Title (Update and Delete):";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProject.Location = new System.Drawing.Point(436, 428);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteProject.TabIndex = 21;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(683, 244);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 23);
            this.btnRefresh.TabIndex = 82;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(42)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1002, 633);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBoxSelectProjects);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.txtProjectTitle);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxManageProjects);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmManageProjects";
            this.Text = "frmManageProjects";
            this.Load += new System.EventHandler(this.frmManageProjects_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageProjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBoxManageProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.ListBox lstBoxSelectProjects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKanban;
        private System.Windows.Forms.Button btnManageTasks;
        private System.Windows.Forms.Button btnManageSubTasks;
        private System.Windows.Forms.Button btnViewMain;
        private System.Windows.Forms.Button btnManageProjects;
    }
}