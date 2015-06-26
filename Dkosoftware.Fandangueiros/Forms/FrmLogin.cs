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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var msgError = ValidateForm();
                if (string.IsNullOrEmpty(msgError))
                {
                    var user = (from u in new UserBUS().GetAll()
                               where u.UserName.Equals(txtUser.Text) &&
                               u.Password.Equals(txtPassword.Text)
                               select u).FirstOrDefault();

                    if (user != null)
                    {
                        new FrmPrincipal().Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar efetuar o Login.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateForm()
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                return "error";
            }

            return string.Empty;
        }
    }
}
