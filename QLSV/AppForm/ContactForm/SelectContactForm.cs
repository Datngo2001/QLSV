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

namespace QLSV.AppForm.ContactForm
{
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        public int ContactID { get; set; }

        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            string query = "SELECT id, fname, lname, [group] FROM Contact";
            dataGridViewContact.DataSource = contact.GetTable(query);
        }

        private void dataGridViewContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ContactID = Convert.ToInt32(dataGridViewContact.CurrentRow.Cells[0].Value.ToString().Trim());
            this.Close();
        }

   }
}
