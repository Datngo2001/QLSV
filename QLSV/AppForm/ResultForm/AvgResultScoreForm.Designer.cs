
namespace QLSV.AppForm.ResultForm
{
    partial class AvgResultScoreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFile_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.title_pn = new System.Windows.Forms.Panel();
            this.title_lb = new System.Windows.Forms.Label();
            this.textBox_pn = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lb = new System.Windows.Forms.Label();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tx = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.lname_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.showResult_dgv = new System.Windows.Forms.DataGridView();
            this.refresh_llb = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.title_pn.SuspendLayout();
            this.textBox_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showResult_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveFile_btn);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.print_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 136);
            this.panel1.TabIndex = 0;
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveFile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile_btn.Location = new System.Drawing.Point(352, 50);
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(175, 51);
            this.saveFile_btn.TabIndex = 0;
            this.saveFile_btn.Text = "Save as File";
            this.saveFile_btn.UseVisualStyleBackColor = true;
            this.saveFile_btn.Click += new System.EventHandler(this.saveFile_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(869, 50);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(175, 51);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click_1);
            // 
            // print_btn
            // 
            this.print_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(614, 50);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(175, 51);
            this.print_btn.TabIndex = 0;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            // 
            // title_pn
            // 
            this.title_pn.Controls.Add(this.refresh_llb);
            this.title_pn.Controls.Add(this.title_lb);
            this.title_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_pn.Location = new System.Drawing.Point(455, 0);
            this.title_pn.Name = "title_pn";
            this.title_pn.Size = new System.Drawing.Size(1014, 71);
            this.title_pn.TabIndex = 30;
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.title_lb.Location = new System.Drawing.Point(6, 9);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(148, 51);
            this.title_lb.TabIndex = 19;
            this.title_lb.Text = "Result:";
            // 
            // textBox_pn
            // 
            this.textBox_pn.Controls.Add(this.label5);
            this.textBox_pn.Controls.Add(this.search_tb);
            this.textBox_pn.Controls.Add(this.search_btn);
            this.textBox_pn.Controls.Add(this.search_lb);
            this.textBox_pn.Controls.Add(this.lname_tb);
            this.textBox_pn.Controls.Add(this.fname_tx);
            this.textBox_pn.Controls.Add(this.id_tb);
            this.textBox_pn.Controls.Add(this.lname_lb);
            this.textBox_pn.Controls.Add(this.fname_lb);
            this.textBox_pn.Controls.Add(this.id_lb);
            this.textBox_pn.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_pn.Location = new System.Drawing.Point(0, 0);
            this.textBox_pn.Name = "textBox_pn";
            this.textBox_pn.Size = new System.Drawing.Size(455, 418);
            this.textBox_pn.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ngô Minh Đạt 19110115";
            // 
            // search_tb
            // 
            this.search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.Location = new System.Drawing.Point(166, 343);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(217, 30);
            this.search_tb.TabIndex = 31;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(12, 336);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(121, 45);
            this.search_btn.TabIndex = 30;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_lb
            // 
            this.search_lb.AutoSize = true;
            this.search_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_lb.Location = new System.Drawing.Point(21, 296);
            this.search_lb.Name = "search_lb";
            this.search_lb.Size = new System.Drawing.Size(363, 25);
            this.search_lb.TabIndex = 29;
            this.search_lb.Text = "Search by ID, FirstName, LastName:";
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(166, 223);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.ReadOnly = true;
            this.lname_tb.Size = new System.Drawing.Size(217, 30);
            this.lname_tb.TabIndex = 28;
            // 
            // fname_tx
            // 
            this.fname_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tx.Location = new System.Drawing.Point(166, 150);
            this.fname_tx.Name = "fname_tx";
            this.fname_tx.ReadOnly = true;
            this.fname_tx.Size = new System.Drawing.Size(217, 30);
            this.fname_tx.TabIndex = 27;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(166, 70);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(217, 30);
            this.id_tb.TabIndex = 26;
            this.id_tb.Text = " ";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lname_lb.Location = new System.Drawing.Point(21, 226);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(122, 25);
            this.lname_lb.TabIndex = 25;
            this.lname_lb.Text = "Last Name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fname_lb.Location = new System.Drawing.Point(19, 150);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(123, 25);
            this.fname_lb.TabIndex = 24;
            this.fname_lb.Text = "First Name:";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(21, 70);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(121, 25);
            this.id_lb.TabIndex = 23;
            this.id_lb.Text = "Student ID:";
            // 
            // showResult_dgv
            // 
            this.showResult_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showResult_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showResult_dgv.Location = new System.Drawing.Point(455, 71);
            this.showResult_dgv.Name = "showResult_dgv";
            this.showResult_dgv.RowHeadersWidth = 62;
            this.showResult_dgv.RowTemplate.Height = 28;
            this.showResult_dgv.Size = new System.Drawing.Size(1014, 347);
            this.showResult_dgv.TabIndex = 31;
            // 
            // refresh_llb
            // 
            this.refresh_llb.AutoSize = true;
            this.refresh_llb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_llb.Location = new System.Drawing.Point(923, 24);
            this.refresh_llb.Name = "refresh_llb";
            this.refresh_llb.Size = new System.Drawing.Size(79, 25);
            this.refresh_llb.TabIndex = 20;
            this.refresh_llb.TabStop = true;
            this.refresh_llb.Text = "Refresh";
            this.refresh_llb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refresh_llb_LinkClicked);
            // 
            // AvgResultScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1469, 554);
            this.Controls.Add(this.showResult_dgv);
            this.Controls.Add(this.title_pn);
            this.Controls.Add(this.textBox_pn);
            this.Controls.Add(this.panel1);
            this.Name = "AvgResultScoreForm";
            this.Text = "AvgResultScoreForm";
            this.Load += new System.EventHandler(this.AvgResultScoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.title_pn.ResumeLayout(false);
            this.title_pn.PerformLayout();
            this.textBox_pn.ResumeLayout(false);
            this.textBox_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showResult_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveFile_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Panel title_pn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Panel textBox_pn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox fname_tx;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.DataGridView showResult_dgv;
        private System.Windows.Forms.LinkLabel refresh_llb;
    }
}