using Exemplo_MP2032_NãoFiscal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dkosoftware.Fandangueiros.Forms
{
    public partial class FrmPrints : Form
    {
        public FrmPrints()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MP2032.ConfiguraModeloImpressora(0) > 0);
                MessageBox.Show("Configurada impressora");

            if(MP2032.IniciaPorta("COM3") > 0)
                MessageBox.Show("Configurada porta");
        }
    }
}
