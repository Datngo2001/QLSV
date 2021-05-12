
namespace QLSV.AppForm.ContactForm
{
    partial class SelectContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContact.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.RowHeadersWidth = 51;
            this.dataGridViewContact.RowTemplate.Height = 24;
            this.dataGridViewContact.Size = new System.Drawing.Size(677, 562);
            this.dataGridViewContact.TabIndex = 1;
            // 
            // SelectContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 562);
            this.Controls.Add(this.dataGridViewContact);
            this.Name = "SelectContactForm";
            this.Text = "SelectContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewContact;
    }
}