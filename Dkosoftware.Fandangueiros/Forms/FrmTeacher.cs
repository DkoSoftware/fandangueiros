using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dkosoftware.Fandangueiros.Business.Concrete;
using Dkosoftware.Fandangueiros.Entity;

namespace Dkosoftware.Fandangueiros.Forms
{
    public partial class FrmTeacher : Form
    {
        #region [Constructor]

        public FrmTeacher(TeacherEntity entity)
        {
            InitializeComponent();

            if (entity != null)
                PopulateFields(entity);
        }

        public FrmTeacher()
        {
            InitializeComponent();
        }

        #endregion

        #region [Methods]

        private void PopulateFields(TeacherEntity entity)
        {
            txtMobile.Text = entity.Mobile;
            txtName.Text = entity.Name;
            txtPhone.Text = entity.Phone;
            cbSex.SelectedIndex = entity.Sex.Equals("M") ? 0 : 1;
            lblIdTeacher.Text = entity.Id.ToString();
        }

        private void ClearFields()
        {
            txtMobile.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbSex.SelectedIndex = -1;
            txtPassword.Text = string.Empty;
            txtUser.Text = string.Empty;
            cbTypeAccess.SelectedIndex = -1;
        }

        private void AddTeacher()
        {
            try
            {
                TeacherEntity entity = new TeacherBUS().GetByID(Convert.ToInt32(lblIdTeacher.Text));

                if (entity == null)
                    entity = new TeacherEntity();

                entity.Mobile = txtMobile.Text.Trim();
                entity.Name = txtName.Text.Trim();
                entity.Phone = txtPhone.Text.Trim();
                entity.Sex = cbSex.SelectedIndex < 0 ? "" : cbSex.SelectedIndex == 0 ? "M" : "F";

                var validate = new TeacherBUS().ValideteForm(entity);
                var validateFormLogin = ValidateFormLogin();

                if (string.IsNullOrEmpty(validate) && string.IsNullOrEmpty(validateFormLogin))
                {
                    if (entity.Id > 0)
                    {
                        new TeacherBUS().Update(entity);
                        if(chbUser.Checked)
                        {
                            var entityUser = new UserBUS().GetByIdTeacher(entity.Id);
                            entityUser.AccessType = cbTypeAccess.SelectedValue.ToString();
                            entityUser.Password = txtPassword.Text.Trim();
                            entityUser.UserName = txtUser.Text.Trim();

                            new UserBUS().Update(entityUser);
                        }
                              
                        MessageBox.Show("Registro atualizado com sucesso", "Cadastro de Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        new TeacherBUS().Add(entity);
                        if (chbUser.Checked)
                        {
                            var entityUser = new UserEntity() {
                                AccessType = cbTypeAccess.SelectedIndex == 1 ? "A" : "U",
                                CreateDate = DateTime.Now,
                                IdTeacher = new TeacherBUS().GetAll().Last().Id,
                                Password = txtPassword.Text.Trim(),
                                UserName = txtUser.Text.Trim()
                            };

                            new UserBUS().Add(entityUser);
                        }

                        MessageBox.Show("Registro salvo com sucesso", "Cadastro de Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(validate + "\n" + validateFormLogin, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar o registo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateFormLogin()
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) || cbTypeAccess.SelectedIndex < 0)
                return "Favor preencher todos os campos de Login.";
            else
            {
                return string.Empty;
            }
        }


        #endregion

        #region [EventHamdler]

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            // disable controls for default
            cbTypeAccess.Enabled = false;
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void chbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUser.Checked)
            {
                // disable controls for default
                cbTypeAccess.Enabled = true;
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                // disable controls for default
                cbTypeAccess.Enabled = false;
                cbTypeAccess.SelectedIndex = -1;
                txtUser.Enabled = false;
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPassword.Enabled = false;
            }
        }

        #endregion
    }
}
