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
    public partial class frmPrincipal : Form
    {
        //public frmPrincipal.ControlCollection();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void PictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
            frm.Show();
        }

        private void PictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroCandidato frm = new frmCadastroCandidato();
            frm.Show();
        }

        private void PictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroEleitor frm = new frmCadastroEleitor();
            frm.Show();
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroMesario frm = new frmCadastroMesario();
            frm.Show();
        }

        private void PictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            frmDados frm = new frmDados();
            frm.Show();
        }

        private void PictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
