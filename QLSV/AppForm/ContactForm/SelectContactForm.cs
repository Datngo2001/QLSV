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
            dataGridViewContact.RowTemplate.Height = 80;
            Contact contact = new Contact();
            dataGridViewContact.DataSource = contact.getUserContact(CurrentUser.Id);
            dataGridViewContact.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridViewContact.Columns["picture"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewContact.AllowUserToAddRows = false;
        }

        private void dataGridViewContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ContactID = Convert.ToInt32(dataGridViewContact.CurrentRow.Cells[0].Value.ToString().Trim());
            this.Close();
        }

   }
}
