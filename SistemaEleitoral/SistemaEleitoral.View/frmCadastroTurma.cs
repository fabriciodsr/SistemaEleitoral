using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEleitoral.Model;
using SistemaEleitoral.Controller;

namespace SistemaEleitoral
{
	public partial class frmCadastroTurma : Form
	{
		public frmCadastroTurma()
		{
			InitializeComponent();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private bool ValidaCampos()
		{
			if (txtNumeroTurma.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Numero da Turma!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtNumeroTurma.Focus();
				return false;
			}
			else if (txtAnoTurma.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o ano da Turma!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtAnoTurma.Focus();
				return false;
			}
			else if (txtDescricaoTurma.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Descrição da Turma!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtDescricaoTurma.Focus();
				return false;
			}
			else
			{
				return true;
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (ValidaCampos())
			{
				Turma oTurma = new Turma();
				oTurma.Numero = txtNumeroTurma.Text.Trim();
				oTurma.Ano = txtAnoTurma.Text.Trim();
				oTurma.Descricao = txtDescricaoTurma.Text.Trim();

				CSistemaEleitoral.Incluir(oTurma);
				MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCancelar.PerformClick();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			txtNumeroTurma.Text = "";
			txtAnoTurma.Text = "";
			txtDescricaoTurma.Text = "";
		}
	}
}
