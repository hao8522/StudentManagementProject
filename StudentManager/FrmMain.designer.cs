namespace StudentManager
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryAndAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AttendanceQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Card = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_linkxkt = new System.Windows.Forms.ToolStripMenuItem();
            this.txmi_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStuManage = new System.Windows.Forms.Button();
            this.btnScoreQuery = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGoXiketang = new System.Windows.Forms.Button();
            this.btnAttendanceQuery = new System.Windows.Forms.Button();
            this.btnScoreAnalasys = new System.Windows.Forms.Button();
            this.btnImportStu = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.学员管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.tsmi_AttendanceQuery,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiModifyPwd,
            this.toolStripSeparator3,
            this.tmiClose});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.SystemToolStripMenuItem.Text = "Sys(&S)";
            // 
            // tmiModifyPwd
            // 
            this.tmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tmiModifyPwd.Image")));
            this.tmiModifyPwd.Name = "tmiModifyPwd";
            this.tmiModifyPwd.Size = new System.Drawing.Size(154, 22);
            this.tmiModifyPwd.Text = "Modify Pwd(&C)";
            this.tmiModifyPwd.Click += new System.EventHandler(this.tmiModifyPwd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // tmiClose
            // 
            this.tmiClose.Image = ((System.Drawing.Image)(resources.GetObject("tmiClose.Image")));
            this.tmiClose.Name = "tmiClose";
            this.tmiClose.Size = new System.Drawing.Size(154, 22);
            this.tmiClose.Text = "Logout(&E)";
            this.tmiClose.Click += new System.EventHandler(this.tmiClose_Click);
            // 
            // 学员管理ToolStripMenuItem
            // 
            this.学员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmi_Import,
            this.toolStripSeparator2,
            this.tsmiManageStudent});
            this.学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            this.学员管理ToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.学员管理ToolStripMenuItem.Text = "Student Details(&M)";
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddStudent.Image")));
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(156, 22);
            this.tsmiAddStudent.Text = "Add Student(&A)";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // tsmi_Import
            // 
            this.tsmi_Import.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Import.Image")));
            this.tsmi_Import.Name = "tsmi_Import";
            this.tsmi_Import.Size = new System.Drawing.Size(156, 22);
            this.tsmi_Import.Text = "Import Student";
            this.tsmi_Import.Click += new System.EventHandler(this.tsmi_Import_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // tsmiManageStudent
            // 
            this.tsmiManageStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmiManageStudent.Image")));
            this.tsmiManageStudent.Name = "tsmiManageStudent";
            this.tsmiManageStudent.Size = new System.Drawing.Size(156, 22);
            this.tsmiManageStudent.Text = "Student Info(&Q)";
            this.tsmiManageStudent.Click += new System.EventHandler(this.tsmiManageStudent_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQueryAndAnalysis,
            this.toolStripSeparator1,
            this.tsmiQuery});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.成绩管理ToolStripMenuItem.Text = "Score(&J)";
            // 
            // tsmiQueryAndAnalysis
            // 
            this.tsmiQueryAndAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQueryAndAnalysis.Image")));
            this.tsmiQueryAndAnalysis.Name = "tsmiQueryAndAnalysis";
            this.tsmiQueryAndAnalysis.Size = new System.Drawing.Size(163, 22);
            this.tsmiQueryAndAnalysis.Text = "Score Search(&Q)";
            this.tsmiQueryAndAnalysis.Click += new System.EventHandler(this.tsmiQueryAndAnalysis_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // tsmiQuery
            // 
            this.tsmiQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQuery.Image")));
            this.tsmiQuery.Name = "tsmiQuery";
            this.tsmiQuery.Size = new System.Drawing.Size(163, 22);
            this.tsmiQuery.Text = "Score Analysis(&S)";
            this.tsmiQuery.Click += new System.EventHandler(this.tsmiQuery_Click);
            // 
            // tsmi_AttendanceQuery
            // 
            this.tsmi_AttendanceQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Card,
            this.toolStripSeparator7,
            this.tsmi_AQuery});
            this.tsmi_AttendanceQuery.Name = "tsmi_AttendanceQuery";
            this.tsmi_AttendanceQuery.Size = new System.Drawing.Size(96, 20);
            this.tsmi_AttendanceQuery.Text = "Attendance(&A)";
            // 
            // tsmi_Card
            // 
            this.tsmi_Card.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Card.Image")));
            this.tsmi_Card.Name = "tsmi_Card";
            this.tsmi_Card.Size = new System.Drawing.Size(173, 22);
            this.tsmi_Card.Text = "Swipe Card(&R)";
            this.tsmi_Card.Click += new System.EventHandler(this.tsmi_Card_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmi_AQuery
            // 
            this.tsmi_AQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AQuery.Image")));
            this.tsmi_AQuery.Name = "tsmi_AQuery";
            this.tsmi_AQuery.Size = new System.Drawing.Size(173, 22);
            this.tsmi_AQuery.Text = "Attendance Search";
            this.tsmi_AQuery.Click += new System.EventHandler(this.tsmi_AQuery_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_linkxkt,
            this.txmi_update,
            this.toolStripSeparator8,
            this.tsmi_about});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.帮助HToolStripMenuItem.Text = "Help(&H)";
            // 
            // tsmi_linkxkt
            // 
            this.tsmi_linkxkt.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_linkxkt.Image")));
            this.tsmi_linkxkt.Name = "tsmi_linkxkt";
            this.tsmi_linkxkt.Size = new System.Drawing.Size(169, 22);
            this.tsmi_linkxkt.Text = "Website(&X)";
            this.tsmi_linkxkt.Click += new System.EventHandler(this.tsmi_linkxkt_Click);
            // 
            // txmi_update
            // 
            this.txmi_update.Image = ((System.Drawing.Image)(resources.GetObject("txmi_update.Image")));
            this.txmi_update.Name = "txmi_update";
            this.txmi_update.Size = new System.Drawing.Size(169, 22);
            this.txmi_update.Text = "Update System(&U)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(166, 6);
            // 
            // tsmi_about
            // 
            this.tsmi_about.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_about.Image")));
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(169, 22);
            this.tsmi_about.Text = "About Us(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion,
            this.toolStripStatusLabel1,
            this.lblCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 17);
            this.lblVersion.Text = " 版本号：V2.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = " [Current User：";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(47, 17);
            this.lblCurrentUser.Text = "王晓军]";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 24);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.label3);
            this.spContainer.Panel1.Controls.Add(this.label2);
            this.spContainer.Panel1.Controls.Add(this.label1);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            this.spContainer.Panel1.Controls.Add(this.btnChangeAccount);
            this.spContainer.Panel1.Controls.Add(this.btnModifyPwd);
            this.spContainer.Panel1.Controls.Add(this.btnExit);
            this.spContainer.Panel1.Controls.Add(this.btnStuManage);
            this.spContainer.Panel1.Controls.Add(this.btnScoreQuery);
            this.spContainer.Panel1.Controls.Add(this.btnCard);
            this.spContainer.Panel1.Controls.Add(this.btnUpdate);
            this.spContainer.Panel1.Controls.Add(this.btnGoXiketang);
            this.spContainer.Panel1.Controls.Add(this.btnAttendanceQuery);
            this.spContainer.Panel1.Controls.Add(this.btnScoreAnalasys);
            this.spContainer.Panel1.Controls.Add(this.btnImportStu);
            this.spContainer.Panel1.Controls.Add(this.btnAddStu);
            this.spContainer.Size = new System.Drawing.Size(1264, 696);
            this.spContainer.SplitterDistance = 246;
            this.spContainer.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(29, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 3);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(29, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 3);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(29, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 3);
            this.label1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 38);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAccount.Image")));
            this.btnChangeAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeAccount.Location = new System.Drawing.Point(128, 466);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(111, 44);
            this.btnChangeAccount.TabIndex = 1;
            this.btnChangeAccount.Text = "Switch Account";
            this.btnChangeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            this.btnChangeAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(13, 466);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(98, 44);
            this.btnModifyPwd.TabIndex = 1;
            this.btnModifyPwd.Text = "Modify Pwd";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(129, 619);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStuManage
            // 
            this.btnStuManage.BackColor = System.Drawing.SystemColors.Control;
            this.btnStuManage.ForeColor = System.Drawing.Color.Black;
            this.btnStuManage.Image = ((System.Drawing.Image)(resources.GetObject("btnStuManage.Image")));
            this.btnStuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuManage.Location = new System.Drawing.Point(131, 262);
            this.btnStuManage.Name = "btnStuManage";
            this.btnStuManage.Size = new System.Drawing.Size(108, 44);
            this.btnStuManage.TabIndex = 1;
            this.btnStuManage.Text = "Student Details";
            this.btnStuManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuManage.UseVisualStyleBackColor = false;
            this.btnStuManage.Click += new System.EventHandler(this.btnStuManage_Click);
            // 
            // btnScoreQuery
            // 
            this.btnScoreQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnScoreQuery.ForeColor = System.Drawing.Color.Black;
            this.btnScoreQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnScoreQuery.Image")));
            this.btnScoreQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoreQuery.Location = new System.Drawing.Point(13, 384);
            this.btnScoreQuery.Name = "btnScoreQuery";
            this.btnScoreQuery.Size = new System.Drawing.Size(98, 44);
            this.btnScoreQuery.TabIndex = 1;
            this.btnScoreQuery.Text = "Score Search";
            this.btnScoreQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScoreQuery.UseVisualStyleBackColor = false;
            this.btnScoreQuery.Click += new System.EventHandler(this.btnScoreQuery_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.SystemColors.Control;
            this.btnCard.ForeColor = System.Drawing.Color.Black;
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCard.Location = new System.Drawing.Point(13, 323);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(98, 44);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "Attendance";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(13, 548);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update System";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGoXiketang
            // 
            this.btnGoXiketang.Image = ((System.Drawing.Image)(resources.GetObject("btnGoXiketang.Image")));
            this.btnGoXiketang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoXiketang.Location = new System.Drawing.Point(10, 619);
            this.btnGoXiketang.Name = "btnGoXiketang";
            this.btnGoXiketang.Size = new System.Drawing.Size(98, 44);
            this.btnGoXiketang.TabIndex = 1;
            this.btnGoXiketang.Text = "Visit Website";
            this.btnGoXiketang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoXiketang.UseVisualStyleBackColor = true;
            this.btnGoXiketang.Click += new System.EventHandler(this.btnGoXiketang_Click);
            // 
            // btnAttendanceQuery
            // 
            this.btnAttendanceQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnAttendanceQuery.ForeColor = System.Drawing.Color.Black;
            this.btnAttendanceQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendanceQuery.Image")));
            this.btnAttendanceQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendanceQuery.Location = new System.Drawing.Point(129, 323);
            this.btnAttendanceQuery.Name = "btnAttendanceQuery";
            this.btnAttendanceQuery.Size = new System.Drawing.Size(110, 44);
            this.btnAttendanceQuery.TabIndex = 1;
            this.btnAttendanceQuery.Text = " Attendance Search";
            this.btnAttendanceQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttendanceQuery.UseVisualStyleBackColor = false;
            this.btnAttendanceQuery.Click += new System.EventHandler(this.btnAttendanceQuery_Click);
            // 
            // btnScoreAnalasys
            // 
            this.btnScoreAnalasys.BackColor = System.Drawing.SystemColors.Control;
            this.btnScoreAnalasys.ForeColor = System.Drawing.Color.Black;
            this.btnScoreAnalasys.Image = ((System.Drawing.Image)(resources.GetObject("btnScoreAnalasys.Image")));
            this.btnScoreAnalasys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoreAnalasys.Location = new System.Drawing.Point(129, 384);
            this.btnScoreAnalasys.Name = "btnScoreAnalasys";
            this.btnScoreAnalasys.Size = new System.Drawing.Size(110, 44);
            this.btnScoreAnalasys.TabIndex = 1;
            this.btnScoreAnalasys.Text = "Score Analysis";
            this.btnScoreAnalasys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScoreAnalasys.UseVisualStyleBackColor = false;
            this.btnScoreAnalasys.Click += new System.EventHandler(this.btnScoreAnalasys_Click);
            // 
            // btnImportStu
            // 
            this.btnImportStu.BackColor = System.Drawing.SystemColors.Control;
            this.btnImportStu.Image = ((System.Drawing.Image)(resources.GetObject("btnImportStu.Image")));
            this.btnImportStu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportStu.Location = new System.Drawing.Point(131, 548);
            this.btnImportStu.Name = "btnImportStu";
            this.btnImportStu.Size = new System.Drawing.Size(108, 44);
            this.btnImportStu.TabIndex = 1;
            this.btnImportStu.Text = "Import Data";
            this.btnImportStu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportStu.UseVisualStyleBackColor = false;
            this.btnImportStu.Click += new System.EventHandler(this.btnImportStu_Click);
            // 
            // btnAddStu
            // 
            this.btnAddStu.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddStu.ForeColor = System.Drawing.Color.Black;
            this.btnAddStu.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStu.Image")));
            this.btnAddStu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStu.Location = new System.Drawing.Point(13, 262);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(98, 44);
            this.btnAddStu.TabIndex = 1;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStu.UseVisualStyleBackColor = false;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 742);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Student Management System]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tmiClose;
        private System.Windows.Forms.ToolStripMenuItem 学员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageStudent;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryAndAnalysis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AttendanceQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Card;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AQuery;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_linkxkt;
        private System.Windows.Forms.ToolStripMenuItem txmi_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Import;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.Button btnImportStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnStuManage;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScoreQuery;
        private System.Windows.Forms.Button btnScoreAnalasys;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGoXiketang;
        private System.Windows.Forms.Button btnAttendanceQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeAccount;


    }
}

