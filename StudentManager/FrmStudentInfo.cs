using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;


namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(Student objStu) :this()
        {
            this.lblStudentName.Text = objStu.StudentName;
            this.lblGender.Text = objStu.Gender;
            this.lblBirthday.Text = objStu.Birthday.ToShortDateString();
            this.lblClass.Text = objStu.ClassName;
            this.lblStudentIdNo.Text = objStu.StudentIdNo;
            this.lblCardNo.Text = objStu.CardNo;
            this.lblPhoneNumber.Text = objStu.PhoneNumber;
            this.lblAddress.Text = objStu.StudentAddress;
            this.pbStu.Image = objStu.StuImage.Length != 0 ? (Image)new SerializeObjectToString().DeserializeObject(objStu.StuImage) : Image.FromFile("default.png");
        }

        //¹Ø±Õ
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}