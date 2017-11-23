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
    public partial class FrmUserLogin : Form
    {
        private SysAdminService objAdminService = new SysAdminService();

        public FrmUserLogin()
        {
            InitializeComponent();
        }


        //Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // data validation
            if(this.txtLoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in login Id","Warning");
                this.txtLoginId.Focus();
                return;
            }

            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in login password", "Warning");
                this.txtLoginPwd.Focus();
                return;
            }

            // instance of object
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };

            // database connection
            Program.currentAdmin = objAdminService.AdminLogin(objAdmin);

            try
            {
                if (Program.currentAdmin != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("LoginId or Password is incorrect", "Warning");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database connection error");
            }
            
        }
        //Close application
        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }
    }
}
