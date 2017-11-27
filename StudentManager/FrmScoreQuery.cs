using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;


namespace StudentManager
{
    public partial class FrmScoreQuery : Form
    {
        private StudentClassService objStuClassService = new StudentClassService();
        private ScoreListService objScoreListService = new ScoreListService();
             private DataSet ds = null;//save result
        public FrmScoreQuery()
        {
            InitializeComponent();

            DataTable dt = objStuClassService.GetAllClasses().Tables[0];
            this.cboClass.DataSource = dt;
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedValue = -1;

            this.ds = objScoreListService.GetAllScoreList();
            this.dgvScoreList.DataSource = ds.Tables[0];
        }     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //search by class
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        //display all the score
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName like '%%'";
        }
        //search by c#
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           // Common.DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

        //print 
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
        }
    }
}
