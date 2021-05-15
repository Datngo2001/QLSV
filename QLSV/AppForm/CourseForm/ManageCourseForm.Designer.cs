namespace QLSV.AppForm.CourseForm
{
    partial class ManageCourseForm
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
            this.ID = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.HoursNumber = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.labelTotalCourse = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.semester_tb = new System.Windows.Forms.TextBox();
            this.semester_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.Location = new System.Drawing.Point(126, 25);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(40, 25);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Description.Location = new System.Drawing.Point(44, 201);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(127, 25);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description:";
            // 
            // HoursNumber
            // 
            this.HoursNumber.AutoSize = true;
            this.HoursNumber.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HoursNumber.Location = new System.Drawing.Point(16, 122);
            this.HoursNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HoursNumber.Name = "HoursNumber";
            this.HoursNumber.Size = new System.Drawing.Size(158, 25);
            this.HoursNumber.TabIndex = 2;
            this.HoursNumber.Text = "Hours Number:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label.Location = new System.Drawing.Point(97, 68);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(70, 25);
            this.Label.TabIndex = 3;
            this.Label.Text = "Label:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxID.Location = new System.Drawing.Point(177, 25);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(221, 27);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxLabel.Location = new System.Drawing.Point(177, 68);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(221, 27);
            this.textBoxLabel.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxDescription.Location = new System.Drawing.Point(177, 201);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(221, 131);
            this.textBoxDescription.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 13F);
            this.numericUpDown1.Location = new System.Drawing.Point(177, 122);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(220, 27);
            this.numericUpDown1.TabIndex = 7;
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonFirst.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonFirst.Location = new System.Drawing.Point(20, 361);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(102, 47);
            this.buttonFirst.TabIndex = 8;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonNext.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonNext.Location = new System.Drawing.Point(131, 361);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(105, 47);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonPrevious.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonPrevious.Location = new System.Drawing.Point(240, 361);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(113, 47);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonLast.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonLast.Location = new System.Drawing.Point(358, 361);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(97, 47);
            this.buttonLast.TabIndex = 11;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Blue;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(79, 429);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 47);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Lime;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(192, 429);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 47);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.Location = new System.Drawing.Point(302, 429);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(98, 47);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Arial", 14F);
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 22;
            this.listBoxCourse.Location = new System.Drawing.Point(503, 36);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(335, 378);
            this.listBoxCourse.TabIndex = 17;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.AutoSize = true;
            this.labelTotalCourse.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTotalCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTotalCourse.Location = new System.Drawing.Point(655, 434);
            this.labelTotalCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Padding = new System.Windows.Forms.Padding(19, 8, 19, 8);
            this.labelTotalCourse.Size = new System.Drawing.Size(187, 42);
            this.labelTotalCourse.TabIndex = 18;
            this.labelTotalCourse.Text = "Total Course:";
            this.labelTotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngô Minh Đạt 19110115";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // semester_tb
            // 
            this.semester_tb.Font = new System.Drawing.Font("Arial", 13F);
            this.semester_tb.Location = new System.Drawing.Point(177, 162);
            this.semester_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.semester_tb.Name = "semester_tb";
            this.semester_tb.Size = new System.Drawing.Size(221, 27);
            this.semester_tb.TabIndex = 23;
            // 
            // semester_lb
            // 
            this.semester_lb.AutoSize = true;
            this.semester_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.semester_lb.Location = new System.Drawing.Point(57, 163);
            this.semester_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semester_lb.Name = "semester_lb";
            this.semester_lb.Size = new System.Drawing.Size(111, 25);
            this.semester_lb.TabIndex = 2;
            this.semester_lb.Text = "Semester:";
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 491);
            this.Controls.Add(this.semester_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotalCourse);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.semester_lb);
            this.Controls.Add(this.HoursNumber);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ID);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label HoursNumber;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelTotalCourse;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox semester_tb;
        private System.Windows.Forms.Label semester_lb;
    }
}