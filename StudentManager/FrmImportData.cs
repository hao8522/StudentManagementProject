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
    public partial class FrmImportData : Form
    {
        private ImportDataFromExcel objImportData = new ImportDataFromExcel();
        List<Student> stuList = new List<Student>();

        public FrmImportData()
        {
            InitializeComponent();
            this.dgvStudentList.AutoGenerateColumns = false;
        }
        private void btnChoseExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();

            if(result== DialogResult.OK)
            {
                string path = openFile.FileName;
                this.stuList = objImportData.GetStudentByExcel(path);

                this.dgvStudentList.DataSource = this.stuList;
            }
        }
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
        //save
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (stuList == null || stuList.Count == 0)
            {

                MessageBox.Show("No data import", "Warning");
                return;
            }
            try
            {
                if (objImportData.Import(this.stuList))
                {
                    MessageBox.Show("Import Sussessfully","Warning");

                    this.dgvStudentList.DataSource = null;
                    this.stuList.Clear();
                }
                else
                {
                    MessageBox.Show("Fail","Warning");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Import data error:"+ex.Message,"Warning");
            }
        }
    }
}

