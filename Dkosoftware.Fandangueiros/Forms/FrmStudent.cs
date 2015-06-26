using Dkosoftware.Fandangueiros.Business.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dkosoftware.Fandangueiros.Forms
{
    public partial class FrmStudent : Form
    {
        #region [ Methods ]

        public FrmStudent()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Event Handler ]

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            new FrmNewStudent().Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var listStudents = (from s in new StudentBUS().GetAll()
                               where this.txtNameStudent.Text == string.Empty || s.Name.ToUpper().Contains(txtNameStudent.Text.ToUpper())
                               select s).OrderBy(x => x.Name);

            this.dgvListTeachers.DataSource = listStudents.ToList();
            this.dgvListTeachers.Columns[0].HeaderText = "Nome";
            this.dgvListTeachers.Columns[0].MinimumWidth = 200;

            this.dgvListTeachers.Columns[1].HeaderText = "Telefone";
            this.dgvListTeachers.Columns[0].MinimumWidth =200;
            this.dgvListTeachers.Columns[2].HeaderText = "Celular";
            this.dgvListTeachers.Columns[3].HeaderText = "E-mail";
            this.dgvListTeachers.Columns[3].MinimumWidth = 200;

            this.dgvListTeachers.Columns[4].HeaderText = "Endereço";
            this.dgvListTeachers.Columns[4].MinimumWidth = 200;
            this.dgvListTeachers.Columns[5].HeaderText = "Cidade";
            this.dgvListTeachers.Columns[5].MinimumWidth = 200;
            this.dgvListTeachers.Columns[6].HeaderText = "Sexo";
            this.dgvListTeachers.Columns[7].HeaderText = "Código";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateStudents();
        }

        private void UpdateStudents()
        {
            var entityStudentSelected = new StudentBUS().GetByID(Convert.ToInt32(this.dgvListTeachers.SelectedRows[0].Cells[7].Value));
            new FrmNewStudent(entityStudentSelected).Show();
        }

        #endregion
    }
}

