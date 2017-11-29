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
    public partial class FrmScoreManage : Form
    {
        private StudentClassService objStuClassService = new StudentClassService();
        private ScoreListService objScoreListService = new ScoreListService();
        //private DataSet ds = null;

        public FrmScoreManage()
        {

            InitializeComponent();
            
            this.dgvScoreList.AutoGenerateColumns = false;
          this.cboClass.SelectedIndexChanged -= new System.EventHandler(this.cboClass_SelectedIndexChanged);
           DataTable dt= objStuClassService.GetAllClassesName().Tables[0];
         
           this.cboClass.DataSource = dt;
           
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";


            this.cboClass.SelectedIndex = -1;

            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);



        }     
        //search by class 
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Class Name", "Warning");
                return;
            }


            this.dgvScoreList.DataSource = objScoreListService.QueryScoreListByClassName(this.cboClass.Text.Trim());

            QueryScore(this.cboClass.SelectedValue.ToString());
         
        }
        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //all the students score
        private void btnStat_Click(object sender, EventArgs e)
        {
            this.dgvScoreList.DataSource = objScoreListService.QueryScoreListByClassName("");

            Dictionary<string, string> infoList = objScoreListService.QueryScoreInfo();
            this.lblAttendCount.Text = infoList["stuCount"];
            this.lblAbsentCount.Text = infoList["absentCount"];
            this.lblCSharpAvg.Text = infoList["avgCSharp"];
            this.lblDBAvg.Text = infoList["avgDB"];


            List<string> absentList = objScoreListService.QueryAbsentList();
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(absentList.ToArray());
          


        }

        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Common.DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList, e);
        }

    
     
        //
        private void dgvScoreList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
         
        }


        private  void QueryScore(string classId)
        {
            Dictionary<string, string> infoList = objScoreListService.QueryScoreInfoByClassId(classId);
            this.lblAttendCount.Text = infoList["stuCount"];
            this.lblAbsentCount.Text = infoList["absentCount"];
            this.lblCSharpAvg.Text = infoList["avgCSharp"];
            this.lblDBAvg.Text = infoList["avgDB"];


            // absent name list
            List<string> absentList = objScoreListService.QueryAbsentList(classId);
            this.lblList.Items.Clear();
            if (absentList.Count == 0)
            {
                this.lblList.Items.Add("no absent");
            }
            else
            {

                this.lblList.Items.AddRange(absentList.ToArray());
            }
        }
       
    }
}