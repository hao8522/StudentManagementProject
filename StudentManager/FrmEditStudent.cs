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

        private StudentClassService objStuService = new StudentClassService();


        public FrmEditStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStuService.GetAllStudentClass();
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
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //select photo
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog objFileDialog = new OpenFileDialog();
            //DialogResult result = objFileDialog.ShowDialog();
            //if (result == DialogResult.OK)
            //    this.pbStu.Image = Image.FromFile(objFileDialog.FileName);
        }
    }
}