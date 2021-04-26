namespace QLSV.AppForm.CourseForm
{
    partial class PrintCourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Blue;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(245, 472);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(210, 89);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save to File";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.LightGray;
            this.buttonPrint.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.Location = new System.Drawing.Point(546, 472);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(210, 89);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCourse.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCourse.RowHeadersWidth = 70;
            this.dataGridViewCourse.RowTemplate.Height = 24;
            this.dataGridViewCourse.Size = new System.Drawing.Size(1005, 439);
            this.dataGridViewCourse.TabIndex = 3;
            this.dataGridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngô Minh Đạt 19110115";
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1032, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Label label5;
    }
}