using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
            Bar.Minimum = 0;
            Bar.Maximum = 100;
            Bar.Value = 0;
        }
        public ProgressDialog(int min, int max)
        {
            InitializeComponent();
            Bar.Minimum = min;
            Bar.Maximum = max;
            Bar.Value = 0;
        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
