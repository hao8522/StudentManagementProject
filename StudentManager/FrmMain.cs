using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.lblCurrentUser.Text = Program.currentAdmin.AdminName + "]";

            this.lblVersion.Text = "Version:" + ConfigurationManager.AppSettings["version"].ToString();
        }
         
        // close form
        private void CloseForm()
        {

            foreach(Control item in this.spContainer.Panel2.Controls)
            {
                if(item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }

        // open form
        private void OpenForm(Form objForm)
        {
            CloseForm();
            objForm.TopLevel = false;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Parent = this.spContainer.Panel2;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        #region student details

    
        //display added student info       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent objForm = new FrmAddStudent();

            OpenForm(objForm);
          
        }
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        //import student details
        private void tsmi_Import_Click(object sender, EventArgs e)
        {
            FrmImportData objForm = new FrmImportData();
            OpenForm(objForm);
        }
        private void btnImportStu_Click(object sender, EventArgs e)
        {
            tsmi_Import_Click(null, null);
        }
        //attendance card     
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
            OpenForm(objForm);
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            tsmi_Card_Click(null, null);
        }
        //score search
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            FrmScoreQuery objForm = new FrmScoreQuery();
            OpenForm(objForm);
        }
        private void btnScoreQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }
        //student mangement
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
            FrmStudentManage objForm = new FrmStudentManage();
            OpenForm(objForm);
        }
        private void btnStuManage_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        //display score  
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
            OpenForm(objForm);
        }
        private void btnScoreAnalasys_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        //attendance search
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
            OpenForm(objForm);
        }
        private void btnAttendanceQuery_Click(object sender, EventArgs e)
        {
            tsmi_AQuery_Click(null, null);
        }

        #endregion

        #region logout system

        //logout system
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to logout?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result!= DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region other

        //modify password
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        //switch account
        private void btnChangeAccount_Click(object sender, EventArgs e)
        {

        }
        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }

        //web site
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
         
        }
        private void btnGoXiketang_Click(object sender, EventArgs e)
        {
            tsmi_linkxkt_Click(null, null);
        }
        //syste update
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}