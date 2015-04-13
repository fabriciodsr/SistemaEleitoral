using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEleitoral.Controller;
using SistemaEleitoral.Model;
using System.Data.SqlClient;

namespace SistemaEleitoral
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            btnEntrar.Text = "Entrar >>";
            //btnEntrar.DialogResult = DialogResult.OK;
        }
		private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
		private int VerificaLogin()
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT COUNT(Login + Senha) FROM Admin WHERE Login = @login AND Senha = @senha";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.Parameters.Add("@login", SqlDbType.VarChar).Value = txtLogin.Text;
			oComando.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

			int QuantLogin;

			QuantLogin = Convert.ToInt32(oComando.ExecuteScalar());

			oCn.Close();
			return QuantLogin;
		}
		private void button7_Click(object sender, EventArgs e)
        {
			if (VerificaLogin() > 0)
			{
				DialogResult = DialogResult.OK;
				MessageBox.Show("Autenticado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Login ou senha incorretos!" + "\n" + "\n" + "Login padrão: admin" + "\n" + "Senha padrão: admin", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			//this.Visible = false;
			//frmMenu frm = new frmMenu();
			//frm.Show();

		}

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
