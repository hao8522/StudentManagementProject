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
    public partial class FrmAddStudent : Form
    {
        public StudentClassService objStuClassService = new StudentClassService();
        public StudentService objStuService = new StudentService();
        List<Student> stuList = new List<Student>();

        public FrmAddStudent()
        {
            InitializeComponent();
            // class name dropdown menu
            this.cboClassName.DataSource = objStuClassService.GetAllStudentClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;

            this.dgvStudentList.AutoGenerateColumns = false;
      
        }
        //add student
        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region Data validation
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("The Student Name can not be null","Warning");
                this.txtStudentName.Focus();
                return;
            }

            if( !this.rdoFemale.Checked && !this.rdoMale.Checked)
            {
                MessageBox.Show("Please select Gender","Warning");
                this.rdoMale.Focus();
                return;
            }

            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if( age<18 || age > 35)
            {
                MessageBox.Show("The age should be between 18 and 35","Warning");
                this.dtpBirthday.Focus();
                return;

            }

            if(this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("Plesas select Class Name");
                this.cboClassName.Focus();
                return;
            }

            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in Student id no card","Warning");
                this.txtStudentIdNo.Focus();
                return;
            }

            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in Attendance Card No","Warning");
                this.txtCardNo.Focus();
                return;
            }

            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in phone number","Warning");
                this.txtPhoneNumber.Focus();
                return;
            }

            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in address","Warning");
                this.txtAddress.Focus();
                return;
            }


            if (!DataValidation.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("The Student Id No format is incorrect", "Warning");
                    this.txtStudentIdNo.Focus();
                return;
            }


            string birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()).ToString("yyyyMMdd");

            if (!this.txtStudentIdNo.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("The Birthday is not sams as The Student Id no format ");
                this.txtStudentIdNo.Focus();
                return;
            }

            // check Student Id no

            if (objStuService.IsIdNoExisted(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("The StudentIdNo is exist,please check the Student Id No","Warning");
                this.txtStudentIdNo.Focus();
                return;
            }

            // check Card No
            if (objStuService.IsCardNoExist(this.txtCardNo.Text.Trim()))
            {
                MessageBox.Show("The attendance card no is eixsted,please check Attendance Card No","Warning");
                this.txtCardNo.Focus();
                return;
            }

            #endregion

            #region  instializing Student object
            Student objStu = new Student()
            {
                StudentName= this.txtStudentName.Text.Trim(),
                Gender= this.rdoMale.Checked?"M":"F",
                Birthday= Convert.ToDateTime(this.dtpBirthday.Text.Trim()),
                StudentIdNo= this.txtStudentIdNo.Text.Trim(),
                CardNo= this.txtCardNo.Text.Trim(),
                Age = DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber= this.txtPhoneNumber.Text.Trim(),
                StudentAddress= this.txtAddress.Text.Trim(),
                ClassId= Convert.ToInt32(this.cboClassName.SelectedValue),
                StuImage= this.pbStu.Image!=null? new SerializeObjectToString().SerializeObject(this.pbStu.Image):"",
                ClassName= this.cboClassName.Text.Trim()

            };
            #endregion

            #region connecting database

            try
            {
                int studentId = objStuService.AddStudent(objStu);

                if (studentId > 1)
                {
                    objStu.StudentId = studentId;
                    this.stuList.Add(objStu);
                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = this.stuList;
                }
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
        }
        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddStudent_KeyDown(object sender, KeyEventArgs e)
        {
       

        }
        //select photo
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            DialogResult result = objOpenFileDialog.ShowDialog();

            if(result== DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(objOpenFileDialog.FileName);
            }
        }
        //start camera
        private void btnStartVideo_Click(object sender, EventArgs e)
        {
         
        }
        //take photo
        private void btnTake_Click(object sender, EventArgs e)
        {
        
        }
        //clear photo
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear photo
            this.pbStu.Image = null;
            
        }

     
    }
}