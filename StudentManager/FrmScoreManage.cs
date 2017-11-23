using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentManager
{
    public partial class FrmScoreManage : Form
    {     
        public FrmScoreManage()
        {
            InitializeComponent();
        
        }     
        //search by class 
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //all the students score
        private void btnStat_Click(object sender, EventArgs e)
        {          
          
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