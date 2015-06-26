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
    public partial class FrmNewLesson : Form
    {
        #region [ Methods ]

        public FrmNewLesson()
        {
            InitializeComponent();
        }

        public FrmNewLesson(LessonsDefaultEntity entity)
        {
            InitializeComponent();
            PopulateFields(entity);
        }

        private void PopulateFields(LessonsDefaultEntity entity)
        {
            this.txtNameLesson.Text = entity.NameLessonDefault;
            this.cbTypeLesson.SelectedIndex = this.cbTypeLesson.FindString(entity.Type);
            this.lblIdLesson.Text = entity.Id.ToString();
        }

        private string ValidateForm()
        {
            if (string.IsNullOrEmpty(txtNameLesson.Text))
                return "Favor preencher o campo Nome.";
            else if (cbTypeLesson.SelectedIndex < 0)
            {
                return "Favor selecione um tipo.";
            }

           return string.Empty;
        }
        
        #endregion

        #region [ Events Handler ]

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string msgError = ValidateForm();

                if (string.IsNullOrEmpty(msgError))
                {
                    if (Convert.ToInt32(lblIdLesson.Text) <= 0)
                    {
                        //add new lesson
                        new LessonsDefaultBUS().Add(new LessonsDefaultEntity()
                        {
                            NameLessonDefault = txtNameLesson.Text.Trim(),
                            Type = cbTypeLesson.SelectedItem.ToString()
                        });

                        MessageBox.Show("Aula cadastrada com sucesso", "Cadastro de Aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        //update lesson
                        var entity = new LessonsDefaultBUS().GetByID(Convert.ToInt32(lblIdLesson.Text));

                        entity.NameLessonDefault = txtNameLesson.Text.Trim();
                        entity.Type = cbTypeLesson.SelectedItem.ToString();
                        new LessonsDefaultBUS().Update(entity);
                        MessageBox.Show("Aula atualizada com sucesso", "Cadastro de Aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(msgError, "Cadastro de Aula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar.", "Cadastro de Aula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
