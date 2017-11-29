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
    public partial class FrmAttendance : Form
    {

        private AttendanceService objAttendanceService = new AttendanceService();
        private StudentService objStuService = new StudentService();
        private List<Student> signedStudent = new List<Student>();

        public FrmAttendance()
        {
            InitializeComponent();

            this.dgvStudentList.AutoGenerateColumns = false;

            timer1_Tick(null,null);
            this.lblCount.Text = objAttendanceService.GetStudentCount().ToString();
            ShowStat();


        }
        private void ShowStat()
        {
          
            this.lblSignCount.Text = objAttendanceService.GetSignedStudent().ToString();
            this.lblAbsenceCount.Text = (Convert.ToInt32(this.lblCount.Text) - Convert.ToInt32(this.lblSignCount.Text)).ToString();

        }
        //display current time
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblYear.Text = DateTime.Now.Year.ToString();
            this.lblMonth.Text = DateTime.Now.Month.ToString();
            this.lblDay.Text = DateTime.Now.Day.ToString();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
           

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    this.lblWeek.Text = "Mon";
                    break;
                case DayOfWeek.Tuesday:
                    this.lblWeek.Text = "Tue";
                    break;
                case DayOfWeek.Wednesday:
                    this.lblWeek.Text = "Wed";
                    break;
                case DayOfWeek.Thursday:
                    this.lblWeek.Text = "Thu";
                    break;
                case DayOfWeek.Friday:
                    this.lblWeek.Text = "Fri";
                    break;
                case DayOfWeek.Saturday:
                    this.lblWeek.Text = "Sat";
                    break;
                case DayOfWeek.Sunday:
                    this.lblWeek.Text = "Sun";
                    break;
            }
        }
        //swipe card    
        private void txtStuCardNo_KeyDown(object sender, KeyEventArgs e)
        {

            Student objStu = objStuService.GetStudentByCardNo(this.txtStuCardNo.Text.Trim());

            if(objStu== null)
            {

                MessageBox.Show("The card no is incorrect","Warning");
                this.lblInfo.Text = "Fail";
                this.txtStuCardNo.SelectAll();
                this.lblStuName.Text = "";
                this.lblStuClass.Text = "";
                this.lblStuId.Text = "";
                this.pbStu.Image = null;

            }
            else
            {
                this.lblStuName.Text = objStu.StudentName;
                this.lblStuId.Text = objStu.StudentId.ToString();
                this.lblStuClass.Text = objStu.ClassName;
                // image
                if(objStu.StuImage!=null && objStu.StuImage.Length != 0)
                {
                    this.pbStu.Image = (Image)new SerializeObjectToString().DeserializeObject(objStu.StuImage);
                }
                else
                {
                    this.pbStu.Image = Image.FromFile("default.png");
                }
               

                string result = objAttendanceService.AddCardNo(this.txtStuCardNo.Text.Trim());

                if(result != "success")
                {
                    this.lblInfo.Text = "Fail";
                    MessageBox.Show(result,"Warning");
                }
                else
                {
                    this.lblInfo.Text = "Success";

                    ShowStat();

                    // save signed student to list
                    objStu.SignedTime = DateTime.Now;
                    signedStudent.Add(objStu);

                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = this.signedStudent;

                    // wait next  student to swipe card
                    this.txtStuCardNo.Text = "";
                    this.txtStuCardNo.Focus();

                }
            }
         
        }
        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            this.txtStuCardNo.Focus();
        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
              DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
    }
}
