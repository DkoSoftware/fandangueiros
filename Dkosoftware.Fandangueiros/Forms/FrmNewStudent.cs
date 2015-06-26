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
    public partial class FrmNewStudent : Form
    {
        #region [ Variables ]

        public FrmNewStudent frmNewStudent;

        #endregion

        #region [ Methods ]

        public FrmNewStudent()
        {
            InitializeComponent();
            frmNewStudent = this;
        }

        public FrmNewStudent(StudentEntity regEntity)
        {
            InitializeComponent();
            frmNewStudent = this;
            PopulateFields(regEntity);
        }

        private void PopulateFields(StudentEntity regEntity)
        {
            var entityReg = (from r in new RegistrationFormBUS().GetAll()
                              where r.IdStudent == regEntity.Id
                              select r).FirstOrDefault();

            //number registration
            this.txtNumberRegistration.Text = entityReg.Id.ToString();
            this.chbPayment.Checked = entityReg.Payment;

            var entitysRegStudents = from r in new RegistrationFormBUS().GetAll()
                                     where r.Id == entityReg.Id
                                     select r;

            PopolateFieldsClass(new ClassBUS().GetByID(entityReg.IdClass),entityReg.Observation);
            PopulateFieldsPeao(new StudentBUS().GetByID(entitysRegStudents.ElementAt(0).IdStudent));
            PopulateFieldsPrenda(new StudentBUS().GetByID(entitysRegStudents.ElementAt(1).IdStudent));
            PopulateFieldsKnowLeddge(entityReg);
        }

        private void PopolateFieldsClass(ClassEntity classEntity,string obs)
        {
            this.txtCodeClass.Text = classEntity.Id.ToString();
            this.txtNameClass.Text = classEntity.Name;
            this.txtObservation.Text = obs;
        }

        private void PopulateFieldsKnowLeddge(RegistrationFormEntity entityReg)
        {
            var knowEntity = (from v in new ViewKnowledgeBUS().GetAll()
                                where v.IdRegistrationForm == entityReg.Id
                                select v).FirstOrDefault();
            
            this.txtPesquisaOutro.Text = knowEntity.OtherObservation;                     
            foreach (Control x in gbKnowLedge.Controls)
            {
                if (x is RadioButton)
                {
                    RadioButton rb = (RadioButton)x;
                    if (rb.Text == knowEntity.Type)
                        rb.Checked = true;
                }
            }
        }

        private void PopulateFieldsPeao(StudentEntity entityPeao)
        {
            this.lblIdPeao.Text = entityPeao.Id.ToString();
            this.txtAdressPeao.Text = entityPeao.Adress;
            this.txtCityPeao.Text = entityPeao.City;
            this.txtEmailPeao.Text = entityPeao.Email;
            this.txtMobilePeao.Text = entityPeao.Mobile;
            this.txtNamePeao.Text = entityPeao.Name;
            this.txtPhonePeao.Text = entityPeao.Phone;
            this.cbSexPeao.SelectedIndex = entityPeao.SexType.Equals("M") ? 1 : 0;
        }

        private void PopulateFieldsPrenda(StudentEntity entityPrenda)
        {
            this.lblIdPrenda.Text = entityPrenda.Id.ToString();
            this.txtAdressPrenda.Text = entityPrenda.Adress;
            this.txtCityPrenda.Text = entityPrenda.City;
            this.txtEmailPrenda.Text = entityPrenda.Email;
            this.txtMobilePrenda.Text = entityPrenda.Mobile;
            this.txtNamePrenda.Text = entityPrenda.Name;
            this.txtPhonePrenda.Text = entityPrenda.Phone;
            this.cbSexPeao.SelectedIndex = entityPrenda.SexType.Equals("M") ? 1 : 0;
        }

        private string ValidateRestForm()
        {
            return string.Empty;
        }

        private string ValidatePartialPrenda()
        {
            if (string.IsNullOrEmpty(txtAdressPrenda.Text.Trim()))
                return "Favor preencher campo Endereço - Prenda";
            else if (string.IsNullOrEmpty(txtCityPrenda.Text.Trim()))
                return "Favor preencher campo Cidade - Prenda";
            else if (string.IsNullOrEmpty(txtEmailPrenda.Text.Trim()))
                return "Favor preencher campo Email - Prenda";
            else if (string.IsNullOrEmpty(txtMobilePrenda.Text.Trim()))
                return "Favor preencher campo Celular - Prenda";
            else if (string.IsNullOrEmpty(txtNamePrenda.Text.Trim()))
                return "Favor preencher campo Nome - Prenda";
            else if (string.IsNullOrEmpty(txtPhonePrenda.Text.Trim()))
                return "Favor preencher campo Telefone - Prenda";

            return string.Empty;
        }

        private string ValidatePartialPeao()
        {
            if (string.IsNullOrEmpty(txtAdressPeao.Text.Trim()))
                return "Favor preencher campo Endereço - Peão";
            else if (string.IsNullOrEmpty(txtCityPeao.Text.Trim()))
                return "Favor preencher campo Cidade - Peão";
            else if (string.IsNullOrEmpty(txtEmailPeao.Text.Trim()))
                return "Favor preencher campo Email - Peão";
            else if (string.IsNullOrEmpty(txtMobilePeao.Text.Trim()))
                return "Favor preencher campo Celular - Peão";
            else if (string.IsNullOrEmpty(txtNamePeao.Text.Trim()))
                return "Favor preencher campo Nome - Peão";
            else if (string.IsNullOrEmpty(txtPhonePeao.Text.Trim()))
                return "Favor preencher campo Telefone - Peão";

            return string.Empty;
        }

        private StudentEntity GetDataPeao()
        {
            StudentEntity entityPeao = new StudentEntity()
            {
                Adress = this.txtAdressPeao.Text.Trim(),
                City = this.txtCityPeao.Text.Trim(),
                Email = this.txtEmailPeao.Text.Trim(),
                Id = Convert.ToInt32(this.lblIdPeao.Text),
                Mobile = this.txtMobilePeao.Text.Trim(),
                Name = this.txtNamePeao.Text.Trim(),
                Phone = this.txtPhonePeao.Text.Trim(),
                SexType = this.cbSexPeao.SelectedIndex == 0 ? "F" : "M"

            };

            return entityPeao;
        }

        private StudentEntity GetDataPrenda()
        {
            StudentEntity entityPrenda = new StudentEntity()
            {
                Adress = this.txtAdressPrenda.Text.Trim(),
                City = this.txtCityPrenda.Text.Trim(),
                Email = this.txtEmailPrenda.Text.Trim(),
                Id = Convert.ToInt32(this.lblIdPrenda.Text),
                Mobile = this.txtMobilePrenda.Text.Trim(),
                Name = this.txtNamePrenda.Text.Trim(),
                Phone = this.txtPhonePrenda.Text.Trim(),
                SexType = this.cbSexPrenda.SelectedIndex == 0 ? "F" : "M"

            };

            return entityPrenda;
        }

        private void SaveStudents()
        {
            try
            {
                string validPeao = ValidatePartialPeao();
                string validPrenda = ValidatePartialPrenda();
                string validRestForm = ValidateRestForm();

                if (string.IsNullOrEmpty(validPeao) && string.IsNullOrEmpty(validPrenda) && string.IsNullOrEmpty(validRestForm))
                {
                    var entityPeao = GetDataPeao();
                    var entityPrenda = GetDataPrenda();

                    if (entityPeao.Id <= 0 && entityPrenda.Id <= 0)
                    {
                        //add new students
                        var idStudentPeao = new StudentBUS().Add(entityPeao);
                        var idStudentPrenda = new StudentBUS().Add(entityPrenda);

                        //entity registration form to data Peão
                        var entityRegFormPeao = new RegistrationFormEntity()
                        {
                            CreateDate = DateTime.Now,
                            IdClass = Convert.ToInt32(this.txtCodeClass.Text),
                            IdStudent = idStudentPeao,
                            Observation = this.txtObservation.Text.Trim(),
                            Payment = this.chbPayment.Checked
                        };

                        //entity registration form to data Prenda
                        var entityRegFormPrenda = new RegistrationFormEntity()
                        {
                            CreateDate = DateTime.Now,
                            IdClass = Convert.ToInt32(this.txtCodeClass.Text),
                            IdStudent = idStudentPrenda,
                            Observation = this.txtObservation.Text.Trim(),
                            Payment = this.chbPayment.Checked
                        };

                        //registration
                        var idReg = new RegistrationFormBUS().Add(entityRegFormPeao,0);
                        new RegistrationFormBUS().Add(entityRegFormPrenda, idReg);

                        new ViewKnowledgeBUS().Add(new ViewKnowledgeEntity()
                        {
                            IdRegistrationForm = idReg,
                            OtherObservation = this.txtObservation.Text.Trim(),
                            Type = GetValueKnowledge()
                        });

                        if (this.chbPayment.Checked)
                        {
                            if (MessageBox.Show("Deseja imprimir o comprovante da inscrição realizada", "Nova Inscrição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //TODO create method for print 
                            }
                        }

                        MessageBox.Show("Inscrição realizada com sucesso", "Nova Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        //update students

                    }
                }
                else
                {
                    MessageBox.Show(validPeao + "\n" + validPrenda + "\n" + validRestForm, "Nova Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar efetuar a inscrição", "Nova Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetValueKnowledge()
        {
            foreach (Control x in gbKnowLedge.Controls)
            {
              if (x is RadioButton)
              {
                  if (((RadioButton)x).Checked)
                      return ((RadioButton)x).Text;
              }
            }
             
            return string.Empty;
        }

        #endregion

        #region [ Events Hanlder ]

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStudents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbOutro_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbOutro.Checked)
                this.txtPesquisaOutro.Enabled = true;
            else
                this.txtPesquisaOutro.Enabled = false;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            new FrmListClass(frmNewStudent).Show();
        }

        private void FrmNewStudent_Load(object sender, EventArgs e)
        {
            this.cbSexPeao.SelectedIndex = 1;
            this.cbSexPrenda.SelectedIndex = 0;
        }

        #endregion
    }
}
