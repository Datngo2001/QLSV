
namespace QLSV
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Dropdown_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.item_NewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dropdown_Student});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "STUDENT";
            // 
            // Dropdown_Student
            // 
            this.Dropdown_Student.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_NewStudent});
            this.Dropdown_Student.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dropdown_Student.Name = "Dropdown_Student";
            this.Dropdown_Student.Size = new System.Drawing.Size(152, 42);
            this.Dropdown_Student.Text = "STUDENT";
            // 
            // item_NewStudent
            // 
            this.item_NewStudent.Name = "item_NewStudent";
            this.item_NewStudent.Size = new System.Drawing.Size(341, 46);
            this.item_NewStudent.Text = "Add New Student";
            this.item_NewStudent.Click += new System.EventHandler(this.addStudent_Clicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 633);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Dropdown_Student;
        private System.Windows.Forms.ToolStripMenuItem item_NewStudent;
    }
}