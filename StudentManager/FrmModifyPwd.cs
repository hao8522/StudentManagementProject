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
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        //修改密码
        private void btnModify_Click(object sender, EventArgs e)
        {

            #region data validation

            if(this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("The old password can not be null","Warning");
                this.txtOldPwd.Focus();
                return;
            }

            if (this.txtOldPwd.Text.Trim().Length < 6)
            {
                MessageBox.Show("The old password can not be less than 6 characters", "Warning");
                this.txtOldPwd.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("The new password can not be null", "Warning");
                this.txtNewPwd.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Trim().Length < 6)
            {
                MessageBox.Show("The new password can not be less than 6 characters", "Warning");
                this.txtNewPwd.Focus();
                return;
            }

            if (this.txtNewPwdConfirm.Text.Trim().Length == 0)
            {
                MessageBox.Show("The confirmed password can not be null", "Warning");
                this.txtNewPwdConfirm.Focus();
                return;
            }

            if (this.txtNewPwdConfirm.Text.Trim().Length < 6)
            {
                MessageBox.Show("The confirmed password can not be less than 6 characters", "Warning");
                this.txtNewPwdConfirm.Focus();
                return;
            }

            if(this.txtOldPwd.Text.Trim() != Program.currentAdmin.LoginPwd)
            {
                MessageBox.Show("The old password is incorrect","Warning");
                this.txtOldPwd.Focus();
                return;
            }

            if(this.txtNewPwd.Text.Trim() != this.txtNewPwdConfirm.Text.Trim())
            {
                MessageBox.Show("The new password and confirmed password are not the same");
                this.txtNewPwd.Focus();
                return;
            }



            #endregion


            #region database connection

            // instance of system admin
            SysAdmin objAdmin = new SysAdmin()
            {

                LoginId = Program.currentAdmin.LoginId,
                LoginPwd = this.txtNewPwd.Text.Trim()
            };


           

            try
            {
                if(new SysAdminService().ModifyPassword(objAdmin) == 1)
                {
                    MessageBox.Show("The password is modified!!!","Warning");
                    Program.currentAdmin.LoginPwd = this.txtNewPwd.Text.Trim();
                    this.Close();
                }
               
            }
            catch (Exception)
            {

                throw;
            }

            #endregion
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
