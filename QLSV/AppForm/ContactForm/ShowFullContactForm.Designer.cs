
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
            this.linkLabelShowAll = new System.Windows.Forms.LinkLabel();
            this.linkLabelGroup = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowAll
            // 
            this.dataGridViewShowAll.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAll.Location = new System.Drawing.Point(210, 86);
            this.dataGridViewShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewShowAll.Name = "dataGridViewShowAll";
            this.dataGridViewShowAll.RowHeadersWidth = 18;
            this.dataGridViewShowAll.RowTemplate.Height = 80;
            this.dataGridViewShowAll.Size = new System.Drawing.Size(1020, 446);
            this.dataGridViewShowAll.TabIndex = 7;
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.BackColor = System.Drawing.Color.Aquamarine;
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 20;
            this.listBoxGroup.Location = new System.Drawing.Point(15, 86);
            this.listBoxGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(169, 444);
            this.listBoxGroup.TabIndex = 6;
            // 
            // linkLabelShowAll
            // 
            this.linkLabelShowAll.AutoSize = true;
            this.linkLabelShowAll.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelShowAll.ForeColor = System.Drawing.Color.White;
            this.linkLabelShowAll.LinkColor = System.Drawing.Color.White;
            this.linkLabelShowAll.Location = new System.Drawing.Point(205, 23);
            this.linkLabelShowAll.Name = "linkLabelShowAll";
            this.linkLabelShowAll.Size = new System.Drawing.Size(140, 35);
            this.linkLabelShowAll.TabIndex = 5;
            this.linkLabelShowAll.TabStop = true;
            this.linkLabelShowAll.Text = "Show All";
            this.linkLabelShowAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowAll_LinkClicked);
            // 
            // linkLabelGroup
            // 
            this.linkLabelGroup.AutoSize = true;
            this.linkLabelGroup.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGroup.ForeColor = System.Drawing.Color.White;
            this.linkLabelGroup.LinkColor = System.Drawing.Color.White;
            this.linkLabelGroup.Location = new System.Drawing.Point(14, 23);
            this.linkLabelGroup.Name = "linkLabelGroup";
            this.linkLabelGroup.Size = new System.Drawing.Size(104, 35);
            this.linkLabelGroup.TabIndex = 4;
            this.linkLabelGroup.TabStop = true;
            this.linkLabelGroup.Text = "Group";
            this.linkLabelGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGroup_LinkClicked);
            // 
            // ShowFullContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1244, 555);
            this.Controls.Add(this.dataGridViewShowAll);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.linkLabelShowAll);
            this.Controls.Add(this.linkLabelGroup);
            this.Name = "ShowFullContactForm";
            this.Text = "ShowFullContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowAll;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.LinkLabel linkLabelShowAll;
        private System.Windows.Forms.LinkLabel linkLabelGroup;
    }
}