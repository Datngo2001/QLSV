using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm
{
    public partial class ConfirmPasswordForm : Form
    {
        User user;
        studentManager manager;
        public ConfirmPasswordForm()
        {
            InitializeComponent();
            user = new User();
            manager = new studentManager();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.isAdmin == true)
            {
                if (manager.CheckPassword(pass_tb.Text) == true)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Password not match!");
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
                if (user.CheckPassword(pass_tb.Text) == true)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Password not match!");
                    this.DialogResult = DialogResult.No;
                }

            }
        }
    }
}
