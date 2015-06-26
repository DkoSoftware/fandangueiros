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
    public partial class SplashScreen : Form
    {
        public FrmPrincipal frmPrinc;

        public SplashScreen()
        {
            frmPrinc = new FrmPrincipal();
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;
            frmPrinc.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
