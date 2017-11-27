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
    public partial class FrmEditStudent : Form
    {

        private StudentClassService objStuClassService = new StudentClassService();
        private StudentService objStuService = new StudentService();


        public FrmEditStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStuClassService.GetAllStudentClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
        }

        public FrmEditStudent(Student objStu):this()
        {

            this.txtStudentId.Text = objStu.StudentId.ToString();
            this.txtStudentName.Text = objStu.StudentName;
            if (objStu.Gender == "M") this.rdoMale.Checked = true;
            else this.rdoFemale.Checked = true;

            this.dtpBirthday.Text = objStu.Birthday.ToShortDateString();
            this.txtStudentIdNo.Text = objStu.StudentIdNo;
            this.txtCardNo.Text = objStu.CardNo;
            this.txtPhoneNumber.Text = objStu.PhoneNumber;
            this.txtAddress.Text = objStu.StudentAddress;
            this.cboClassName.Text = objStu.ClassName;
            this.pbStu.Image = objStu.StuImage.Length != 0 ? (Image)new SerializeObjectToString().DeserializeObject(objStu.StuImage) : Image.FromFile("default.png");

           
        }

        //submit 
        private void btnModify_Click(object sender, EventArgs e)
        {

            #region data validation
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("The Student Name can not be null","Warning");
                this.txtStudentName.Focus();
                return;
            }

            if(!this.rdoMale.Checked  && !this.rdoFemale.Checked)
            {
                MessageBox.Show("Please select Gender","Warning");
                return;

            }

            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("Please select Class Name","Warning");
                this.cboClassName.Focus();
                return;
            }

            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("The Student Id No can not be null","Warning");
                this.txtStudentIdNo.Focus();
                return;
            }

            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("The card no can not be null", "Warning");
                this.txtCardNo.Focus();
                return;
            }

            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("The phone number can not be null", "Warning");
                this.txtPhoneNumber.Focus();
                return;
            }

            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("The address can not be null", "Warning");
                this.txtAddress.Focus();
                return;
            }

            // check the student id no exist

            if (objStuService.IsIdNoExisted(this.txtStudentIdNo.Text.Trim(), this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("The Student Id No is used by other Student ,please check student Id No","Warning");
                this.txtStudentIdNo.Focus();
                return;
            }

            #endregion

            #region connection database


            try
            {

                Student objStu = new Student()
                {
                    StudentName = this.txtStudentName.Text.Trim(),
                    Gender = this.rdoMale.Checked ? "M" : "F",
                    Birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()),
                    StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                    CardNo = this.txtCardNo.Text.Trim(),
                    Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                    PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                    StudentAddress = this.txtAddress.Text.Trim(),
                    ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                    StuImage = this.pbStu.Image != null ? new SerializeObjectToString().SerializeObject(this.pbStu.Image) : "",
                 
                    StudentId= Convert.ToInt32(this.txtStudentId.Text.Trim())

                };

                if (objStuService.ModifyStudent(objStu) == 1)
                {
                    MessageBox.Show("The Student Details is modified","Warning");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning");
                
            }

            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //select photo
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog objFileDialog = new OpenFileDialog();

            DialogResult result = objFileDialog.ShowDialog();

            if(result== DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(objFileDialog.FileName);
            }
        }
    }
}