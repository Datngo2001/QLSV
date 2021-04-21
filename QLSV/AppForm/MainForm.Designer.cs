
namespace QLSV.AppForm
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
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMVCECOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECOURCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVESCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGESCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGSCOREBYSCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTRESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dropdown_Student,
            this.cOURSEToolStripMenuItem,
            this.sCOREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(969, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "STUDENT";
            // 
            // Dropdown_Student
            // 
            this.Dropdown_Student.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_NewStudent,
            this.studentListToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.Dropdown_Student.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Dropdown_Student.Name = "Dropdown_Student";
            this.Dropdown_Student.Size = new System.Drawing.Size(152, 42);
            this.Dropdown_Student.Text = "STUDENT";
            // 
            // item_NewStudent
            // 
            this.item_NewStudent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.item_NewStudent.Name = "item_NewStudent";
            this.item_NewStudent.Size = new System.Drawing.Size(399, 46);
            this.item_NewStudent.Text = "Add New Student";
            this.item_NewStudent.Click += new System.EventHandler(this.addStudent_Clicked);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(399, 46);
            this.studentListToolStripMenuItem.Text = "Student List ";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(399, 46);
            this.staticsToolStripMenuItem.Text = "Statics";
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(399, 46);
            this.editRemoveToolStripMenuItem.Text = "Edit / Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(399, 46);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(399, 46);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDCOURSEToolStripMenuItem,
            this.eDITCOURSEToolStripMenuItem,
            this.rEMVCECOURSEToolStripMenuItem,
            this.mANAGECOURCEToolStripMenuItem,
            this.pRINTToolStripMenuItem1});
            this.cOURSEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(135, 42);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // aDDCOURSEToolStripMenuItem
            // 
            this.aDDCOURSEToolStripMenuItem.Name = "aDDCOURSEToolStripMenuItem";
            this.aDDCOURSEToolStripMenuItem.Size = new System.Drawing.Size(350, 46);
            this.aDDCOURSEToolStripMenuItem.Text = "ADD COURSE";
            this.aDDCOURSEToolStripMenuItem.Click += new System.EventHandler(this.aDDCOURSEToolStripMenuItem_Click);
            // 
            // eDITCOURSEToolStripMenuItem
            // 
            this.eDITCOURSEToolStripMenuItem.Name = "eDITCOURSEToolStripMenuItem";
            this.eDITCOURSEToolStripMenuItem.Size = new System.Drawing.Size(350, 46);
            this.eDITCOURSEToolStripMenuItem.Text = "EDIT COURSE";
            this.eDITCOURSEToolStripMenuItem.Click += new System.EventHandler(this.eDITCOURSEToolStripMenuItem_Click);
            // 
            // rEMVCECOURSEToolStripMenuItem
            // 
            this.rEMVCECOURSEToolStripMenuItem.Name = "rEMVCECOURSEToolStripMenuItem";
            this.rEMVCECOURSEToolStripMenuItem.Size = new System.Drawing.Size(350, 46);
            this.rEMVCECOURSEToolStripMenuItem.Text = "REMOVE COURSE";
            this.rEMVCECOURSEToolStripMenuItem.Click += new System.EventHandler(this.rEMVCECOURSEToolStripMenuItem_Click);
            // 
            // mANAGECOURCEToolStripMenuItem
            // 
            this.mANAGECOURCEToolStripMenuItem.Name = "mANAGECOURCEToolStripMenuItem";
            this.mANAGECOURCEToolStripMenuItem.Size = new System.Drawing.Size(350, 46);
            this.mANAGECOURCEToolStripMenuItem.Text = "MANAGE COURCE";
            this.mANAGECOURCEToolStripMenuItem.Click += new System.EventHandler(this.mANAGECOURCEToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem1
            // 
            this.pRINTToolStripMenuItem1.Name = "pRINTToolStripMenuItem1";
            this.pRINTToolStripMenuItem1.Size = new System.Drawing.Size(350, 46);
            this.pRINTToolStripMenuItem1.Text = "PRINT";
            this.pRINTToolStripMenuItem1.Click += new System.EventHandler(this.pRINTToolStripMenuItem1_Click);
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDSCOREToolStripMenuItem,
            this.rEMOVESCOREToolStripMenuItem,
            this.mANAGESCOREToolStripMenuItem,
            this.aVGSCOREBYSCOREToolStripMenuItem,
            this.pRINTRESULTToolStripMenuItem});
            this.sCOREToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(116, 42);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // aDDSCOREToolStripMenuItem
            // 
            this.aDDSCOREToolStripMenuItem.Name = "aDDSCOREToolStripMenuItem";
            this.aDDSCOREToolStripMenuItem.Size = new System.Drawing.Size(395, 46);
            this.aDDSCOREToolStripMenuItem.Text = "ADD SCORE";
            this.aDDSCOREToolStripMenuItem.Click += new System.EventHandler(this.aDDSCOREToolStripMenuItem_Click);
            // 
            // rEMOVESCOREToolStripMenuItem
            // 
            this.rEMOVESCOREToolStripMenuItem.Name = "rEMOVESCOREToolStripMenuItem";
            this.rEMOVESCOREToolStripMenuItem.Size = new System.Drawing.Size(395, 46);
            this.rEMOVESCOREToolStripMenuItem.Text = "REMOVE SCORE";
            this.rEMOVESCOREToolStripMenuItem.Click += new System.EventHandler(this.rEMOVESCOREToolStripMenuItem_Click);
            // 
            // mANAGESCOREToolStripMenuItem
            // 
            this.mANAGESCOREToolStripMenuItem.Name = "mANAGESCOREToolStripMenuItem";
            this.mANAGESCOREToolStripMenuItem.Size = new System.Drawing.Size(395, 46);
            this.mANAGESCOREToolStripMenuItem.Text = "MANAGE SCORE";
            this.mANAGESCOREToolStripMenuItem.Click += new System.EventHandler(this.mANAGESCOREToolStripMenuItem_Click);
            // 
            // aVGSCOREBYSCOREToolStripMenuItem
            // 
            this.aVGSCOREBYSCOREToolStripMenuItem.Name = "aVGSCOREBYSCOREToolStripMenuItem";
            this.aVGSCOREBYSCOREToolStripMenuItem.Size = new System.Drawing.Size(395, 46);
            this.aVGSCOREBYSCOREToolStripMenuItem.Text = "AVG SCORE BY SCORE";
            // 
            // pRINTRESULTToolStripMenuItem
            // 
            this.pRINTRESULTToolStripMenuItem.Name = "pRINTRESULTToolStripMenuItem";
            this.pRINTRESULTToolStripMenuItem.Size = new System.Drawing.Size(395, 46);
            this.pRINTRESULTToolStripMenuItem.Text = "PRINT RESULT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(969, 553);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Dropdown_Student;
        private System.Windows.Forms.ToolStripMenuItem item_NewStudent;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMVCECOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGECOURCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aDDSCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVESCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGESCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVGSCOREBYSCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTRESULTToolStripMenuItem;
    }
}