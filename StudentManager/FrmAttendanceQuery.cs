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
    public partial class FrmAttendanceQuery : Form
    {

        private AttendanceService objAttendanceService = new AttendanceService();

        public FrmAttendanceQuery()
        {
            InitializeComponent();
            this.dgvStudentList.AutoGenerateColumns = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // search attendance by student name and datetime

            DateTime beginTime = Convert.ToDateTime(this.dtpTime.Text);
            DateTime endTime = beginTime.AddDays(1.0);

            this.dgvStudentList.DataSource = objAttendanceService.GetStudentBySignDate(beginTime,endTime,this.txtName.Text.Trim());


            // get signed student number, absent student number, all student number
            this.lblCount.Text = objAttendanceService.GetStudentCount().ToString();
            this.lblSignedCount.Text = objAttendanceService.GetSignedStudent(beginTime, endTime).ToString();
            this.lblAbsenceCount.Text = (Convert.ToInt32(this.lblCount.Text.Trim()) - Convert.ToInt32(this.lblSignedCount.Text.Trim())).ToString();
         
        }
        //add line number
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          //  Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
