using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEleitoral
{
    public partial class frmAutentica_Eleitor_Senha : Form
    {
        public frmAutentica_Eleitor_Senha()
        {
            InitializeComponent();
        }

        private void frmAutentica_Eleitor_Senha_Load(object sender, EventArgs e)
        {
            tb_Senha_Autentica_Eleitor.Focus();
        }

        private void tb_Senha_Autentica_Eleitor_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Senha_Autentica_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                frmAutentica_Eleitor_Matricula frm = new frmAutentica_Eleitor_Matricula();
                ///frm.MdiParent = this;
                frm.Show();
                Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }
    }
}
