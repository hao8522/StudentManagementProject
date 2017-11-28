using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;


namespace StudentManager
{
    public partial class FrmScoreManage : Form
    {
        private StudentClassService objStuClassService = new StudentClassService();
        private ScoreListService objScoreListService = new ScoreListService();
        private DataSet ds = null;

        public FrmScoreManage()
        {

            InitializeComponent();
            
            this.dgvScoreList.AutoGenerateColumns = false;
           //this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
           DataTable dt= objStuClassService.GetAllClassesName().Tables[0];
         
           this.cboClass.DataSource = dt;
           
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";


            this.cboClass.SelectedIndex = -1;



        }     
        //search by class 
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            //if (this.cboClass.SelectedIndex != -1)
            //{
            //    MessageBox.Show("Please select Class Name", "Warning");
            //    return;
            //}

     
            this.dgvScoreList.DataSource = objScoreListService.QueryScoreListByClassName(this.cboClass.Text.Trim());
          
        }
        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //all the students score
        private void btnStat_Click(object sender, EventArgs e)
        {
            this.dgvScoreList.DataSource = objScoreListService.QueryScoreListByClassName("");
        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Common.DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

    
     
        //
        private void dgvScoreList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
         
        }

       
    }
}