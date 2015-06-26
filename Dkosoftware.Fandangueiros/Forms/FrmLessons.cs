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

namespace Dkosoftware.Fandangueiros.Forms
{
    public partial class FrmLessons : Form
    {
        private Entity.LessonsDefaultEntity lessonsDefaultEntity;

        #region [ Methods ]

        public FrmLessons()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {
            var listLessons = (from l in new LessonsDefaultBUS().GetAll()
                               where txtNameClass.Text == string.Empty || l.NameLessonDefault.Contains(txtNameClass.Text)
                               && cbTypeLesson.SelectedIndex < 0 || l.Type.Contains(cbTypeLesson.SelectedItem.ToString())
                               select l).OrderBy(x => x.NameLessonDefault).ToList();

            this.dgvListLessons.DataSource = listLessons;
            this.dgvListLessons.Columns[0].HeaderText = "Nome da Aula";
            this.dgvListLessons.Columns[0].MinimumWidth = 200;
            this.dgvListLessons.Columns[1].HeaderText = "Tipo";
            this.dgvListLessons.Columns[2].HeaderText = "Código";
        }

        #endregion

        #region [ Events Handler ]

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLessons_Load(object sender, EventArgs e)
        {
            this.cbTypeLesson.SelectedIndex = 0;
        }

        private void btnNewLesson_Click(object sender, EventArgs e)
        {
            new FrmNewLesson().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var idLesson = Convert.ToInt32(this.dgvListLessons.SelectedRows[0].Cells[2].Value);
            try
            {
                var resultQuestion = MessageBox.Show("Você tem certeza que deseja apagar este item", "Apagar Aula", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resultQuestion == DialogResult.Yes)
                {
                    var entity = new LessonsDefaultBUS().GetByID(idLesson);
                    new LessonsDefaultBUS().Delete(entity);
                    MessageBox.Show("Item apagado com sucesso", "Apagar Aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar apagar item.", "Apagar Aula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var idLesson = Convert.ToInt32(this.dgvListLessons.SelectedRows[0].Cells[2].Value);
            new FrmNewLesson(new LessonsDefaultBUS().GetByID(idLesson)).Show();
        }

        #endregion
    }
}
