using Dkosoftware.Fandangueiros.Business.Concrete;
using Dkosoftware.Fandangueiros.Entity;
using Dkosoftware.Fandangueiros.Helpers;
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
    public partial class FrmSearchTeacher : Form
    {
        #region [ Events Hamdler ]

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTeachers();
        }

        private void SearchTeachers()
        {
            var listTTeachers = from t in new TeacherBUS().GetAll()
                                where txtName.Text.Trim() == string.Empty || t.Name.ToUpper().Contains(txtName.Text.ToUpper().Trim())
                                orderby t.Name
                                select t;

            PopulateGrid(listTTeachers.ToList());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            FrmTeacher newMDIChild = new FrmTeacher();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var rowSelected = this.dgvListTeachers.SelectedRows[0];
            var entity = new TeacherBUS().GetByID((int)rowSelected.Cells[4].Value);
            new FrmTeacher(entity).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente deseja apagar este item", "Apagar Professor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var rowSelected = this.dgvListTeachers.SelectedRows[0];
                    var entity = new TeacherBUS().GetByID((int)rowSelected.Cells[4].Value);
                    new TeacherBUS().Delete(entity);
                    SearchTeachers();
                    MessageBox.Show("Item apagado com sucesso", "Apagar Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar apagar o item.", "Apagar Professor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region [ Methods ]

        public FrmSearchTeacher()
        {
            InitializeComponent();
        }

        private void PopulateGrid(IList<TeacherEntity> listEntitys)
        {
            this.dgvListTeachers.Columns.Clear();
            this.dgvListTeachers.DataSource = listEntitys;
            this.dgvListTeachers.Columns[0].HeaderText = "Nome";
            this.dgvListTeachers.Columns[0].MinimumWidth = 250;
            this.dgvListTeachers.Columns[3].HeaderText = "Sexo";
            this.dgvListTeachers.Columns[1].HeaderText = "Telefone";
            this.dgvListTeachers.Columns[2].HeaderText = "Celular";
            this.dgvListTeachers.Columns[4].Visible = false;
        }

        #endregion
    }
}
