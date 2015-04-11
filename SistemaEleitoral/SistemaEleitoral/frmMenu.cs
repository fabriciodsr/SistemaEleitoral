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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
            ///frm.MdiParent = this;
            frm.Show();
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCandidato frm = new frmCadastroCandidato();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEleitor frm = new frmCadastroEleitor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mesárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMesario frm = new frmCadastroMesario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDados frm = new frmDados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
