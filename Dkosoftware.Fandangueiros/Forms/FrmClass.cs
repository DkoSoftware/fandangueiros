using Dkosoftware.Fandangueiros.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Dkosoftware.Fandangueiros.Forms
{
    public partial class FrmClass : Form
    {
        #region [ Methods ]

        public FrmClass()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {
            this.dgvListClasses.Columns.Clear();
            this.dgvListClasses.DataSource = (from c in new ClassBUS().GetAll()
                                              where txtNameClass.Text.Equals(string.Empty) || c.Name.ToUpper().Contains(txtNameClass.Text.ToUpper())
                                               && (cbTypeClass.SelectedIndex <= 0) || c.Type.Contains(cbTypeClass.SelectedItem.ToString())
                                               && c.StartDate.Date >= dtpDtInicial.Value.Date && c.FinishDate.Date <= dtpDtFinal.Value.Date
                                              select c).ToList().OrderBy(x => x.Name).ToList();

            this.dgvListClasses.Columns[0].HeaderText = "Nome";
            this.dgvListClasses.Columns[0].MinimumWidth = 250;
            this.dgvListClasses.Columns[1].HeaderText = "Data Inicial";
            this.dgvListClasses.Columns[2].HeaderText = "Data Final";
            this.dgvListClasses.Columns[3].HeaderText = "Valor R$";
            this.dgvListClasses.Columns[4].HeaderText = "Local";
            this.dgvListClasses.Columns[5].HeaderText = "Tipo";
            this.dgvListClasses.Columns[6].HeaderText = "Código";
        }

        #endregion

        #region [ Events Handler ]

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            new FrmNewClass().Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvListClasses.SelectedRows.Count <= 0)
                return;

            new FrmNewClass(new ClassBUS().GetByID(Convert.ToInt32(this.dgvListClasses.SelectedRows[0].Cells[6].Value.ToString()))).Show();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            this.cbTypeClass.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente deseja apagar este item", "Apagar Curso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var entityClass = new ClassBUS().GetByID(Convert.ToInt32(this.dgvListClasses.SelectedRows[0].Cells[6].Value));

                    var listClassLessons = new ClassLessonsBUS().GetByIDClass(entityClass.Id);
                    var listLessons = from cl in listClassLessons
                                      join l in new LessonsBUS().GetAll() on cl.IdLessons equals l.Id
                                      select l;

                    //delete class
                    new ClassBUS().Delete(entityClass);

                    //delete class lessons
                    foreach (var item in listClassLessons)
                    {
                        new ClassLessonsBUS().Delete(item);
                    }

                    //delete lessons
                    foreach (var item in listLessons)
                    {
                        new LessonsBUS().Delete(item);
                    }

                    MessageBox.Show("Curso apagado com sucesso", "Apagar Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar apagar o item", "Apagar Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
