using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Models;
using DAL;


namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private StudentClassService objStuClassService = new StudentClassService();
        private StudentService objStuService = new StudentService();
        List<Student> stuList = new List<Student>();

        public FrmStudentManage()
        {
            InitializeComponent();

            // class name dropdown menu
            this.cboClass.DataSource = objStuClassService.GetAllStudentClass();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";

            this.cboClass.SelectedIndex =-1;

            this.dgvStudentList.AutoGenerateColumns = false;
        
        }
        //search by class name
        private void btnQuery_Click(object sender, EventArgs e)
        {

            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Class Name","Warning");
                this.cboClass.Focus();
                return;
            }

            this.stuList= objStuService.GetStudentByClassName(this.cboClass.Text);
            this.dgvStudentList.DataSource = this.stuList;
            new DataGridViewStyle().DgvStyle1(this.dgvStudentList);

        
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
            if (this.dgvStudentList.RowCount == 0) return;

            this.stuList.Sort(new StuNameDESC());
            this.dgvStudentList.Refresh();

        }
        //sort by stuId
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;
            this.stuList.Sort(new StuIdDESC());
            this.dgvStudentList.Refresh();
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

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    #region stuId StuName sort

    class StuNameDESC : IComparer<Student>
    {

        public int Compare(Student x,Student y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }


    class StuIdDESC : IComparer<Student>
    {
        public int Compare(Student x,Student y)
        {
            return y.StudentId.CompareTo(x.StudentId);
        }
    }
    #endregion


}