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
    public partial class FrmNewClass : Form
    {
        #region [ Variables ]

        public FrmNewClass frmNewClass;

        #endregion

        #region [ Methods ]

        public FrmNewClass()
        {
            frmNewClass = this;
            InitializeComponent();
        }

        public FrmNewClass(ClassEntity entityClass)
        {
            frmNewClass = this;
            InitializeComponent();
            SetValuesInFields(entityClass);
        }

        private void SetValuesInFields(ClassEntity entityClass)
        {
            this.idClass.Text = entityClass.Id.ToString();
            this.txtLocal.Text = entityClass.Local;
            this.txtNameClass.Text = entityClass.Name;
            this.txtValueClass.Text = entityClass.ValueCourse.ToString();
            this.dtpDtInicial.Value = entityClass.StartDate;
            this.dtpDtFinal.Value = entityClass.FinishDate;
            this.cbTypeClass.SelectedIndex = this.cbTypeClass.FindString(entityClass.Type);

            this.dgvListLessons.DataSource = (from cl in new ClassLessonsBUS().GetAll()
                                             join l in new LessonsBUS().GetAll() on cl.IdLessons equals l.Id
                                             where cl.IdClass == entityClass.Id
                                             select new {
                                                            Nome = l.Name,
                                                            Tipo = l.Type,
                                                            Codigo = l.Id,
                                                            Data = l.DateLesson
                                                         }).ToList();

            this.dgvListLessons.Columns[2].HeaderText = "Código";
            this.dgvListLessons.Columns[0].HeaderText = "Nome";
            this.dgvListLessons.Columns[0].MinimumWidth = 250;
            this.dgvListLessons.Columns[1].HeaderText = "Tipo";
            this.dgvListLessons.Columns[3].HeaderText = "Data Aula";
        }

        private string ValidateForm()
        {
            if (string.IsNullOrEmpty(txtNameClass.Text))
            {
                return "Favor preencher o campo Nome.";
            }
            else if (string.IsNullOrEmpty(txtLocal.Text))
            {
                return "Favor preencher o campo Local.";
            }
            else if (string.IsNullOrEmpty(txtValueClass.Text))
            {
                return "Favor preencher o campo Valor R$.";
            }
            else if (cbTypeClass.SelectedIndex < 0)
            {
                return "Favor selecione um Tipo de Curso";
            }

            // validate all rows the grid
            foreach (DataGridViewRow row in dgvListLessons.Rows)
            {
                if (Convert.ToString(row.Cells[3].Value) == "")
                    return "Favor preencher todas as datas das aulas adicionadas.";
            }

            return string.Empty;
        }

        private void SaveClass()
        {
            try
            {
                string messageError = ValidateForm();

                if (string.IsNullOrEmpty(messageError))
                {
                    if (Convert.ToInt32(this.idClass.Text) <= 0)
                    {
                        // new class
                        ClassEntity entityClass = GetValuesForm();
                        SaveLessonOfClass(entityClass, new ClassBUS().Add(entityClass));
                        this.Close();

                        MessageBox.Show("Curso cadastrado com sucesso.", "Cadastro de Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //update classv
                        ClassEntity entityClass = GetValuesForm();
                        new ClassBUS().Update(entityClass);
                        UpdateLessonOfClass(entityClass, entityClass.Id);
                        this.Close();

                        MessageBox.Show("Curso atualizado com sucesso.", "Cadastro de Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(messageError, "Cadastro de Curso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar cadastrar o Curso", "Cadastro de Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLessonOfClass(ClassEntity entityClass, int idClass)
        {
            var listClassLessonAdded = new ClassLessonsBUS().GetByIDClass(idClass);

            foreach (var item in listClassLessonAdded)
            {
                new LessonsBUS().Delete(new LessonsBUS().GetByID(item.IdLessons)); // delete lesson
                new ClassLessonsBUS().Delete(item); // delete join class lessons
            }

            //create news lessons for this class
            SaveLessonOfClass(entityClass, idClass);
        }

        private void SaveLessonOfClass(ClassEntity entityClass, int idClassAdded)
        {
            foreach (var item in entityClass.ListLessons)
            {
                new LessonsBUS().Add(item);

                new ClassLessonsBUS().Add(new ClassLessonsEntity()
                {
                    IdClass = idClassAdded,
                    IdLessons = new LessonsBUS().GetAll().Max(x => x.Id)
                });
            }
        }

        private ClassEntity GetValuesForm()
        {
            //get lessons of grid
            List<LessonsEntity> listAdded = new List<LessonsEntity>();
            foreach (DataGridViewRow row in dgvListLessons.Rows)
            {
                listAdded.Add(new LessonsEntity()
                {
                    DateLesson = Convert.ToDateTime(row.Cells[3].Value),
                    Id = Convert.ToInt32(row.Cells[2].Value),
                    Name = row.Cells[0].Value.ToString(),
                    Type = row.Cells[1].Value.ToString()
                });
            }

            //get data of form
            return new ClassEntity()
            {
                FinishDate = this.dtpDtFinal.Value,
                Id = Convert.ToInt32(this.idClass.Text),
                ListLessons = listAdded,
                Local = this.txtLocal.Text.Trim(),
                Name = this.txtNameClass.Text.Trim(),
                StartDate = this.dtpDtInicial.Value,
                ValueCourse = Convert.ToDecimal(this.txtValueClass.Text),
                Type = cbTypeClass.SelectedItem.ToString()
            };
        }

        #endregion

        #region [ Events Handler ]

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClass();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            new FrmListLessons(ref frmNewClass).Show();
        }


        #endregion
    }
}
