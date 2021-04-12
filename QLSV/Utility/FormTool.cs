using System.Windows.Forms;

namespace QLSV.Utility
{
    class FormTool
    {
        public void ClearForm(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if(c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else
                    ClearForm(c);
            }
        }

    }
}
