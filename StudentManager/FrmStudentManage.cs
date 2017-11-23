using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {

        public FrmStudentManage()
        {
            InitializeComponent();
        
        }
        //search by class 
        private void btnQuery_Click(object sender, EventArgs e)
        {
        
        }
        //search by student Id
        private void btnQueryById_Click(object sender, EventArgs e)
        {
          
        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
        //double click to demonstrate students
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //modify student
        private void btnEidt_Click(object sender, EventArgs e)
        {
          
        }
        //delete student
        private void btnDel_Click(object sender, EventArgs e)
        {
           
        }
        //sort by name
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
         
        }
        //sort by stuId
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
         
        }
        //add line number
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        
        }
        //print
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
        }

        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //import to Excel
        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }

   
}