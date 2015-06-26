namespace Dkosoftware.Fandangueiros.Forms
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnPrints = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnLessons = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(764, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(2, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShutDown);
            this.panel2.Controls.Add(this.btnPrints);
            this.panel2.Controls.Add(this.btnClass);
            this.panel2.Controls.Add(this.btnLessons);
            this.panel2.Controls.Add(this.btnStudents);
            this.panel2.Controls.Add(this.btnTeachers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 100);
            this.panel2.TabIndex = 9;
            // 
            // btnShutDown
            // 
            this.btnShutDown.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394414193_exit_64;
            this.btnShutDown.Location = new System.Drawing.Point(572, 6);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(106, 91);
            this.btnShutDown.TabIndex = 5;
            this.btnShutDown.Text = "Sair";
            this.btnShutDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnPrints
            // 
            this.btnPrints.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394066724_print;
            this.btnPrints.Location = new System.Drawing.Point(460, 6);
            this.btnPrints.Name = "btnPrints";
            this.btnPrints.Size = new System.Drawing.Size(106, 91);
            this.btnPrints.TabIndex = 4;
            this.btnPrints.Text = "Impressos";
            this.btnPrints.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrints.UseVisualStyleBackColor = true;
            this.btnPrints.Click += new System.EventHandler(this.btnPrints_Click);
            // 
            // btnClass
            // 
            this.btnClass.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394066671_Courses;
            this.btnClass.Location = new System.Drawing.Point(348, 6);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(106, 91);
            this.btnClass.TabIndex = 3;
            this.btnClass.Text = "Curso";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnLessons
            // 
            this.btnLessons.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394067460_stock_task_recurring;
            this.btnLessons.Location = new System.Drawing.Point(236, 6);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Size = new System.Drawing.Size(106, 91);
            this.btnLessons.TabIndex = 2;
            this.btnLessons.Text = "Aulas";
            this.btnLessons.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLessons.UseVisualStyleBackColor = true;
            this.btnLessons.Click += new System.EventHandler(this.btnLessons_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394066849_graduated2;
            this.btnStudents.Location = new System.Drawing.Point(124, 6);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(106, 91);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Alunos";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394065836_Teachers_64;
            this.btnTeachers.Location = new System.Drawing.Point(12, 6);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(106, 91);
            this.btnTeachers.TabIndex = 0;
            this.btnTeachers.Text = "Professores";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dkosoftware.Fandangueiros.Properties.Resources.logo_fandangueiros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Controle de alunos do Curso de Dança";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrints;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnLessons;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnShutDown;
    }
}



