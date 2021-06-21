
namespace QLSV.AppForm.StudentsForm
{
    partial class StudentListForm
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
            this.list_dgv = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // list_dgv
            // 
            this.list_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_dgv.Location = new System.Drawing.Point(0, 0);
            this.list_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_dgv.Name = "list_dgv";
            this.list_dgv.RowHeadersWidth = 62;
            this.list_dgv.RowTemplate.Height = 80;
            this.list_dgv.Size = new System.Drawing.Size(856, 437);
            this.list_dgv.TabIndex = 0;
            this.list_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.list_dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.list_dgv_DataError);
            this.list_dgv.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.refresh_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh_btn.Location = new System.Drawing.Point(0, 424);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(856, 32);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.list_dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentListForm";
            this.Text = "List of students";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list_dgv;
        private System.Windows.Forms.Button refresh_btn;
    }
}