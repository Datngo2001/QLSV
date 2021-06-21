
namespace QLSV.AppForm.ContactForm
{
    partial class ShowFullContactForm
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
            this.dataGridViewShowAll = new System.Windows.Forms.DataGridView();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowAll
            // 
            this.dataGridViewShowAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowAll.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowAll.Location = new System.Drawing.Point(163, 0);
            this.dataGridViewShowAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewShowAll.Name = "dataGridViewShowAll";
            this.dataGridViewShowAll.RowHeadersWidth = 18;
            this.dataGridViewShowAll.RowTemplate.Height = 80;
            this.dataGridViewShowAll.Size = new System.Drawing.Size(1021, 361);
            this.dataGridViewShowAll.TabIndex = 7;
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.BackColor = System.Drawing.Color.Aquamarine;
            this.listBoxGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 20;
            this.listBoxGroup.Location = new System.Drawing.Point(0, 0);
            this.listBoxGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(163, 361);
            this.listBoxGroup.TabIndex = 6;
            this.listBoxGroup.DoubleClick += new System.EventHandler(this.listBoxGroup_DoubleClick);
            // 
            // ShowFullContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.dataGridViewShowAll);
            this.Controls.Add(this.listBoxGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowFullContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All your contact";
            this.Load += new System.EventHandler(this.ShowFullContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowAll;
        private System.Windows.Forms.ListBox listBoxGroup;
    }
}