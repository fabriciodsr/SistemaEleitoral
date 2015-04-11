using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SistemaEleitoral
{
    public partial class frmAutentica_Eleitor_Senha : Form
    {
        private SoundPlayer player2;

        public frmAutentica_Eleitor_Senha()
        {
            InitializeComponent();

            player2 = new SoundPlayer("voto.wav");
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
                player2.Play();
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
