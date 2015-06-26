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
    public partial class FrmListLessons : Form
    {
        public FrmNewClass frmNewClass;

        #region [ Methods ]

        public FrmListLessons()
        {
            InitializeComponent();
        }

        public FrmListLessons(ref FrmNewClass frmNewClass)
        {
            InitializeComponent();

            this.frmNewClass = frmNewClass;
        }

        #endregion

        #region [ Events Handler ]

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            var listSelected = new List<LessonsDefaultEntity>();
            foreach (DataGridViewRow item in this.dgvListLessons.Rows)
            {
                if (item.Selected)
                    listSelected.Add(new LessonsDefaultEntity() { 
                        Id = Convert.ToInt32(item.Cells[2].Value),
                        NameLessonDefault = item.Cells[0].Value.ToString(),
                        Type = item.Cells[1].Value.ToString()
                    });
            }

            this.frmNewClass.dgvListLessons.DataSource = listSelected.ToList();
            this.frmNewClass.dgvListLessons.Columns[2].HeaderText = "Código";
            this.frmNewClass.dgvListLessons.Columns[0].HeaderText = "Nome";
            this.frmNewClass.dgvListLessons.Columns[0].MinimumWidth = 250;
            this.frmNewClass.dgvListLessons.Columns[1].HeaderText = "Tipo";

            // add column date lesson
            DataGridViewTextBoxColumn colDateLesson = new DataGridViewTextBoxColumn();
            colDateLesson.DisplayIndex = 3;
            colDateLesson.HeaderText = "Data aula";
            colDateLesson.DataPropertyName = "DateLessonId";
            this.frmNewClass.dgvListLessons.Columns.Add(colDateLesson);
            this.frmNewClass.dgvListLessons.AutoResizeColumns();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void FrmListLessons_Load(object sender, EventArgs e)
        {
            this.dgvListLessons.DataSource = new LessonsDefaultBUS().GetAll().OrderBy(x => x.NameLessonDefault).ToList();
            this.dgvListLessons.Columns[2].HeaderText = "Código";
            this.dgvListLessons.Columns[0].HeaderText = "Nome";
            this.dgvListLessons.Columns[0].MinimumWidth = 250;
            this.dgvListLessons.Columns[1].HeaderText = "Tipo";
        }
    }
}
