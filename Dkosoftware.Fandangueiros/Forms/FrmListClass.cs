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
    public partial class FrmListClass : Form
    {
        public FrmNewStudent frmNewStudent;

        #region [ Methods ]

        public FrmListClass()
        {
            InitializeComponent();
        }

        public FrmListClass(FrmNewStudent frmNewStudent)
        {
            InitializeComponent();
            this.frmNewStudent = frmNewStudent;
        }

        #endregion

        #region [ Events Handler ]

        private void FrmListClass_Load(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = new ClassBUS().GetAll().OrderBy(x => x.Name).ToList();
            this.dgvListClasses.Columns[0].HeaderText = "Nome";
            this.dgvListClasses.Columns[0].MinimumWidth = 250;
            this.dgvListClasses.Columns[1].HeaderText = "Data Inicial";
            this.dgvListClasses.Columns[2].HeaderText = "Data Final";
            this.dgvListClasses.Columns[3].HeaderText = "Valor R$";
            this.dgvListClasses.Columns[4].HeaderText = "Local";
            this.dgvListClasses.Columns[5].HeaderText = "Tipo";
            this.dgvListClasses.Columns[6].HeaderText = "Código";
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            var entityClass = new ClassBUS().GetByID(Convert.ToInt32(this.dgvListClasses.SelectedRows[0].Cells[6].Value));
            frmNewStudent.txtCodeClass.Text = entityClass.Id.ToString();
            frmNewStudent.txtNameClass.Text = entityClass.Name;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
