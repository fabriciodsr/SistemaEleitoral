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
    public partial class frmAutentica_Eleitor_Matricula : Form
    {
        public frmAutentica_Eleitor_Matricula()
        {
            InitializeComponent();
        }

        private void frmAutentica_Eleitor_Matricula_Load(object sender, EventArgs e)
        {
            tb_Matricula_Autentica_Eleitor.Focus();
        }

        private void tb_Matricula_Autentica_Eleitor_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Matricula_Autentica_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                frmVotacao frm = new frmVotacao();
                ///frm.MdiParent = this;
                frm.Show();
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
                ///frm.MdiParent = this;
                frm.Show();
                this.Close();
            }
        }

        private void frmAutentica_Eleitor_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
                ///frm.MdiParent = this;
                frm.Show();
                this.Close();
            }
        }
    }
}
