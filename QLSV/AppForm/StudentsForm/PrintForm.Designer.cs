
namespace QLSV.AppForm.StudentsForm
{
    partial class PrintForm
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
            this.dataView_gv = new System.Windows.Forms.DataGridView();
            this.Sevefile_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.all_rBtn = new System.Windows.Forms.RadioButton();
            this.male_rBtn = new System.Windows.Forms.RadioButton();
            this.female_rBtn = new System.Windows.Forms.RadioButton();
            this.dateOption_gb = new System.Windows.Forms.GroupBox();
            this.no_rbtn = new System.Windows.Forms.RadioButton();
            this.yes_rbtn = new System.Windows.Forms.RadioButton();
            this.dateEnd2_dtp = new System.Windows.Forms.DateTimePicker();
            this.dateEnd1_dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check_btn = new System.Windows.Forms.Button();
            this.searchOption_gb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_gv)).BeginInit();
            this.dateOption_gb.SuspendLayout();
            this.searchOption_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView_gv
            // 
            this.dataView_gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_gv.Location = new System.Drawing.Point(8, 109);
            this.dataView_gv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataView_gv.Name = "dataView_gv";
            this.dataView_gv.RowHeadersWidth = 62;
            this.dataView_gv.RowTemplate.Height = 28;
            this.dataView_gv.Size = new System.Drawing.Size(836, 272);
            this.dataView_gv.TabIndex = 1;
            // 
            // Sevefile_btn
            // 
            this.Sevefile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sevefile_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.Sevefile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sevefile_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sevefile_btn.Location = new System.Drawing.Point(201, 389);
            this.Sevefile_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 32);
            this.Sevefile_btn.Name = "Sevefile_btn";
            this.Sevefile_btn.Size = new System.Drawing.Size(175, 48);
            this.Sevefile_btn.TabIndex = 2;
            this.Sevefile_btn.Text = "Save as file";
            this.Sevefile_btn.UseVisualStyleBackColor = false;
            this.Sevefile_btn.Click += new System.EventHandler(this.Sevefile_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.print_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.print_btn.Location = new System.Drawing.Point(491, 389);
            this.print_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 32);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(172, 48);
            this.print_btn.TabIndex = 2;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // all_rBtn
            // 
            this.all_rBtn.AutoSize = true;
            this.all_rBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.all_rBtn.Checked = true;
            this.all_rBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_rBtn.Location = new System.Drawing.Point(12, 41);
            this.all_rBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.all_rBtn.Name = "all_rBtn";
            this.all_rBtn.Size = new System.Drawing.Size(44, 24);
            this.all_rBtn.TabIndex = 0;
            this.all_rBtn.TabStop = true;
            this.all_rBtn.Text = "All";
            this.all_rBtn.UseVisualStyleBackColor = false;
            // 
            // male_rBtn
            // 
            this.male_rBtn.AutoSize = true;
            this.male_rBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rBtn.Location = new System.Drawing.Point(81, 41);
            this.male_rBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.male_rBtn.Name = "male_rBtn";
            this.male_rBtn.Size = new System.Drawing.Size(61, 24);
            this.male_rBtn.TabIndex = 0;
            this.male_rBtn.TabStop = true;
            this.male_rBtn.Text = "Male";
            this.male_rBtn.UseVisualStyleBackColor = true;
            // 
            // female_rBtn
            // 
            this.female_rBtn.AutoSize = true;
            this.female_rBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rBtn.Location = new System.Drawing.Point(169, 41);
            this.female_rBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.female_rBtn.Name = "female_rBtn";
            this.female_rBtn.Size = new System.Drawing.Size(71, 24);
            this.female_rBtn.TabIndex = 0;
            this.female_rBtn.TabStop = true;
            this.female_rBtn.Text = "Fmale";
            this.female_rBtn.UseVisualStyleBackColor = true;
            // 
            // dateOption_gb
            // 
            this.dateOption_gb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateOption_gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dateOption_gb.Controls.Add(this.no_rbtn);
            this.dateOption_gb.Controls.Add(this.yes_rbtn);
            this.dateOption_gb.Controls.Add(this.dateEnd2_dtp);
            this.dateOption_gb.Controls.Add(this.dateEnd1_dtp);
            this.dateOption_gb.Controls.Add(this.label4);
            this.dateOption_gb.Controls.Add(this.label3);
            this.dateOption_gb.Controls.Add(this.label2);
            this.dateOption_gb.Controls.Add(this.label1);
            this.dateOption_gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dateOption_gb.Location = new System.Drawing.Point(263, 11);
            this.dateOption_gb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateOption_gb.Name = "dateOption_gb";
            this.dateOption_gb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateOption_gb.Size = new System.Drawing.Size(403, 84);
            this.dateOption_gb.TabIndex = 1;
            this.dateOption_gb.TabStop = false;
            // 
            // no_rbtn
            // 
            this.no_rbtn.AutoSize = true;
            this.no_rbtn.Checked = true;
            this.no_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_rbtn.Location = new System.Drawing.Point(231, 8);
            this.no_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.no_rbtn.Name = "no_rbtn";
            this.no_rbtn.Size = new System.Drawing.Size(47, 24);
            this.no_rbtn.TabIndex = 3;
            this.no_rbtn.TabStop = true;
            this.no_rbtn.Text = "No";
            this.no_rbtn.UseVisualStyleBackColor = true;
            // 
            // yes_rbtn
            // 
            this.yes_rbtn.AutoSize = true;
            this.yes_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_rbtn.Location = new System.Drawing.Point(162, 8);
            this.yes_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yes_rbtn.Name = "yes_rbtn";
            this.yes_rbtn.Size = new System.Drawing.Size(55, 24);
            this.yes_rbtn.TabIndex = 3;
            this.yes_rbtn.TabStop = true;
            this.yes_rbtn.Text = "Yes";
            this.yes_rbtn.UseVisualStyleBackColor = true;
            this.yes_rbtn.CheckedChanged += new System.EventHandler(this.yes_rbtn_CheckedChanged);
            // 
            // dateEnd2_dtp
            // 
            this.dateEnd2_dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd2_dtp.CustomFormat = "dd-MMM-yyyy";
            this.dateEnd2_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd2_dtp.Location = new System.Drawing.Point(307, 51);
            this.dateEnd2_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd2_dtp.Name = "dateEnd2_dtp";
            this.dateEnd2_dtp.Size = new System.Drawing.Size(76, 20);
            this.dateEnd2_dtp.TabIndex = 1;
            this.dateEnd2_dtp.Value = new System.DateTime(2021, 3, 11, 0, 0, 0, 0);
            // 
            // dateEnd1_dtp
            // 
            this.dateEnd1_dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd1_dtp.CustomFormat = "dd-MMM-yyyy";
            this.dateEnd1_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd1_dtp.Location = new System.Drawing.Point(175, 51);
            this.dateEnd1_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd1_dtp.Name = "dateEnd1_dtp";
            this.dateEnd1_dtp.Size = new System.Drawing.Size(76, 20);
            this.dateEnd1_dtp.TabIndex = 2;
            this.dateEnd1_dtp.Value = new System.DateTime(2021, 3, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "And:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Between:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range:";
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.Red;
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_btn.Location = new System.Drawing.Point(690, 11);
            this.check_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(144, 84);
            this.check_btn.TabIndex = 2;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // searchOption_gb
            // 
            this.searchOption_gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchOption_gb.Controls.Add(this.check_btn);
            this.searchOption_gb.Controls.Add(this.dateOption_gb);
            this.searchOption_gb.Controls.Add(this.female_rBtn);
            this.searchOption_gb.Controls.Add(this.male_rBtn);
            this.searchOption_gb.Controls.Add(this.all_rBtn);
            this.searchOption_gb.Location = new System.Drawing.Point(8, 8);
            this.searchOption_gb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchOption_gb.Name = "searchOption_gb";
            this.searchOption_gb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchOption_gb.Size = new System.Drawing.Size(836, 99);
            this.searchOption_gb.TabIndex = 0;
            this.searchOption_gb.TabStop = false;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 456);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.Sevefile_btn);
            this.Controls.Add(this.dataView_gv);
            this.Controls.Add(this.searchOption_gb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView_gv)).EndInit();
            this.dateOption_gb.ResumeLayout(false);
            this.dateOption_gb.PerformLayout();
            this.searchOption_gb.ResumeLayout(false);
            this.searchOption_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataView_gv;
        private System.Windows.Forms.Button Sevefile_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.RadioButton all_rBtn;
        private System.Windows.Forms.RadioButton male_rBtn;
        private System.Windows.Forms.RadioButton female_rBtn;
        private System.Windows.Forms.GroupBox dateOption_gb;
        private System.Windows.Forms.RadioButton no_rbtn;
        private System.Windows.Forms.RadioButton yes_rbtn;
        private System.Windows.Forms.DateTimePicker dateEnd2_dtp;
        private System.Windows.Forms.DateTimePicker dateEnd1_dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.GroupBox searchOption_gb;
    }
}