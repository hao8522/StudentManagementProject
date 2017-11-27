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
            if (this.txtStudentId.Text.Trim().Length == 0)
            {
                MessageBox.Show("The Student Id can not be null!","Warning");
                this.txtStudentId.Focus();
                return;
            }

            Student objStu = objStuService.GetStudentById(this.txtStudentId.Text.Trim());

            if(objStu== null)
            {
                MessageBox.Show("The student is not exist!","Warning");
            }
            else
            {

                FrmStudentInfo frmStuInfo = new FrmStudentInfo(objStu);
                frmStuInfo.Show();
            }
          
        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.txtStudentId.Text.Trim().Length !=0 && e.KeyValue == 13)
            {
               btnQueryById_Click(null,null);
            }
        }
        //double click to demonstrate students
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(this.dgvStudentList.CurrentRow != null)
            {
                string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
                Student objstu = objStuService.GetStudentById(studentId);
                FrmStudentInfo objFrmStuInfo = new FrmStudentInfo(objstu);

                objFrmStuInfo.Show();
            }
        }
        //modify student
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("There is not student","Warning");
                this.cboClass.Focus();
                return;
            }

            if(this.dgvStudentList.CurrentRow== null)
            {

                MessageBox.Show("The Student is not selected","Warning");
                return;
            }

            // get student id
            string studentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();

            Student objStu = objStuService.GetStudentById(studentId);

            FrmEditStudent frmEditStu = new FrmEditStudent(objStu);

            if (frmEditStu.ShowDialog() == DialogResult.OK)
            {
                btnQuery_Click(null,null);
            }

            //frmEditStu.Show();


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

        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null,null);
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