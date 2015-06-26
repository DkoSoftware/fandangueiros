namespace Dkosoftware.Fandangueiros.Forms
{
    partial class FrmNewClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewClass));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTypeClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValueClass = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDtFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDtInicial = new System.Windows.Forms.DateTimePicker();
            this.txtNameClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListLessons = new System.Windows.Forms.DataGridView();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.idClass = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTypeClass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValueClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDtFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDtInicial);
            this.groupBox1.Controls.Add(this.txtNameClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados principais do Curso";
            // 
            // cbTypeClass
            // 
            this.cbTypeClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeClass.FormattingEnabled = true;
            this.cbTypeClass.Items.AddRange(new object[] {
            "Avançado",
            "Básico"});
            this.cbTypeClass.Location = new System.Drawing.Point(376, 63);
            this.cbTypeClass.Name = "cbTypeClass";
            this.cbTypeClass.Size = new System.Drawing.Size(232, 21);
            this.cbTypeClass.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo curso";
            // 
            // txtValueClass
            // 
            this.txtValueClass.Location = new System.Drawing.Point(83, 64);
            this.txtValueClass.Mask = "99999,99";
            this.txtValueClass.Name = "txtValueClass";
            this.txtValueClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValueClass.Size = new System.Drawing.Size(224, 20);
            this.txtValueClass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor R$";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(376, 28);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(232, 20);
            this.txtLocal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Local";
            // 
            // dtpDtFinal
            // 
            this.dtpDtFinal.Location = new System.Drawing.Point(376, 99);
            this.dtpDtFinal.Name = "dtpDtFinal";
            this.dtpDtFinal.Size = new System.Drawing.Size(232, 20);
            this.dtpDtFinal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Inicial";
            // 
            // dtpDtInicial
            // 
            this.dtpDtInicial.Location = new System.Drawing.Point(83, 99);
            this.dtpDtInicial.Name = "dtpDtInicial";
            this.dtpDtInicial.Size = new System.Drawing.Size(226, 20);
            this.dtpDtInicial.TabIndex = 5;
            // 
            // txtNameClass
            // 
            this.txtNameClass.Location = new System.Drawing.Point(83, 28);
            this.txtNameClass.Name = "txtNameClass";
            this.txtNameClass.Size = new System.Drawing.Size(226, 20);
            this.txtNameClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListLessons);
            this.groupBox2.Controls.Add(this.btnAddLesson);
            this.groupBox2.Location = new System.Drawing.Point(28, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Aulas";
            // 
            // dgvListLessons
            // 
            this.dgvListLessons.AllowUserToAddRows = false;
            this.dgvListLessons.AllowUserToOrderColumns = true;
            this.dgvListLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLessons.Location = new System.Drawing.Point(17, 66);
            this.dgvListLessons.Name = "dgvListLessons";
            this.dgvListLessons.Size = new System.Drawing.Size(591, 181);
            this.dgvListLessons.TabIndex = 6;
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394068316_add_48;
            this.btnAddLesson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLesson.Location = new System.Drawing.Point(17, 19);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(141, 41);
            this.btnAddLesson.TabIndex = 7;
            this.btnAddLesson.Text = "Adicionar aulas";
            this.btnAddLesson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // idClass
            // 
            this.idClass.AutoSize = true;
            this.idClass.Location = new System.Drawing.Point(623, 9);
            this.idClass.Name = "idClass";
            this.idClass.Size = new System.Drawing.Size(13, 13);
            this.idClass.TabIndex = 17;
            this.idClass.Text = "0";
            this.idClass.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Dkosoftware.Fandangueiros.Properties.Resources.Back;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(559, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Dkosoftware.Fandangueiros.Properties.Resources._1394068680_floppy_disk_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(460, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 515);
            this.Controls.Add(this.idClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Curso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtValueClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public  System.Windows.Forms.DataGridView dgvListLessons;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.ComboBox cbTypeClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idClass;
        public System.Windows.Forms.DateTimePicker dtpDtInicial;
        public System.Windows.Forms.DateTimePicker dtpDtFinal;
    }
}