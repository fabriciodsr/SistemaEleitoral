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
using SistemaEleitoral.Controller;
using SistemaEleitoral.Model;
using System.Data.SqlClient;

namespace SistemaEleitoral
{
    public partial class frmAutentica_Eleitor_Matricula : Form
    {

        private SoundPlayer player2;
        public frmAutentica_Eleitor_Matricula()
        {
            InitializeComponent();

            player2 = new SoundPlayer("voto.wav");
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
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT COUNT(Matricula) FROM Eleitor WHERE Matricula = @mat";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.Parameters.Add("@mat", SqlDbType.VarChar).Value = tb_Matricula_Autentica_Eleitor.Text;

			int v = (int)oComando.ExecuteScalar();

			if (e.KeyChar == 13 && v > 0)
			{
				player2.Play();
                frmVotacao frm = new frmVotacao();
                frm.Show();
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
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
