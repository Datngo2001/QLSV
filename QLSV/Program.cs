using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.AppForm;

namespace QLSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.Yes)
            {
                if (loginForm.student_rbtn.Checked) Application.Run(new MainForm());
                if (loginForm.human_rbtn.Checked) Application.Run(new MainContactForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
