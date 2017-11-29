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

            DataTable dt = objStuClassService.GetAllClassesName().Tables[0];
            this.cboClass.DataSource = dt;
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedValue = -1;

            this.ds = objScoreListService.GetAllScoreList();
            this.dgvScoreList.DataSource = ds.Tables[0];
            new DataGridViewStyle().DgvStyle1(this.dgvScoreList);
        }     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //search by class
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds == null) return;
            this.ds.Tables[0].DefaultView.RowFilter = string.Format("ClassName='{0}'",this.cboClass.Text.Trim());
            new DataGridViewStyle().DgvStyle1(this.dgvScoreList);
        }
        //display all the score
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName like '%%'";
            new DataGridViewStyle().DgvStyle1(this.dgvScoreList);
        }
        //search by c#
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (this.txtScore.Text.Trim().Length == 0) return;

            if (DataValidation.IsInteger(this.txtScore.Text.Trim()))
            {
                this.ds.Tables[0].DefaultView.RowFilter = "CSharp>" + this.txtScore.Text.Trim();
                new DataGridViewStyle().DgvStyle1(this.dgvScoreList);

            }
         
        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

        //print 
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
        }
    }
}
