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
    public partial class frmCadastroEleitor : Form
    {
        public frmCadastroEleitor()
        {
            InitializeComponent();
        }

		private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCodigoEleitor.Text = "";
            txtCpfEleitor.Text = "";
            txtEmailEleitor.Text = "";
            txtEnderecoEleitor.Text = "";
            txtNomeEleitor.Text = "";
            txtRgEleitor.Text = "";
            cmbEstadoEleitor.SelectedItem = null;
            cmbSexoEleitor.SelectedItem = null;
            mtbCepEleitor.Text = "";
            dtpDataNascEleitor.Text = "";
            mtbTelEleitor.Text = "";
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private bool ValidaCampos()
		{
			if (txtCodigoEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Matrícula do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCodigoEleitor.Focus();
				return false;
			}
			else if (txtNomeEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Nome do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtNomeEleitor.Focus();
				return false;
			}
			else if (txtEnderecoEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Endereço do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtEnderecoEleitor.Focus();
				return false;
			}
			else if (txtBairro.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Bairro do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtBairro.Focus();
				return false;
			}
			else if (txtCidade.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Cidade do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCidade.Focus();
				return false;
			}
			else if (mtbCepEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o CEP do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				mtbCepEleitor.Focus();
				return false;
			}
			else if (cmbEstadoEleitor.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Estado do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbEstadoEleitor.Focus();
				return false;
			}
			else if (txtRgEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Identidade do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtRgEleitor.Focus();
				return false;
			}
			else if (txtCpfEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o CPF do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCpfEleitor.Focus();
				return false;
			}
			else if (dtpDataNascEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Data de Nascimento do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtpDataNascEleitor.Focus();
				return false;
			}
			else if (txtEmailEleitor.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o E-mail do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtEmailEleitor.Focus();
				return false;
			}
			else if (cmbSexoEleitor.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Sexo do Eleitor!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbSexoEleitor.Focus();
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
				Eleitor oEleitor = new Eleitor();
				oEleitor.Matricula = txtCodigoEleitor.Text.Trim();
				oEleitor.Nome = txtNomeEleitor.Text.Trim();
				oEleitor.CPF = txtCpfEleitor.Text.Trim();
				oEleitor.Telefone = mtbTelEleitor.Text;
				oEleitor.Identidade = txtRgEleitor.Text.Trim();
				oEleitor.Endereco = txtEnderecoEleitor.Text.Trim();
				oEleitor.Bairro = txtBairro.Text.Trim();
				oEleitor.Cidade = txtCidade.Text.Trim();
				oEleitor.Cep = mtbCepEleitor.Text;
				oEleitor.Estado = Convert.ToString(cmbEstadoEleitor.SelectedItem);
				oEleitor.Email = txtEmailEleitor.Text.Trim();
				oEleitor.DataNasc = dtpDataNascEleitor.Text;
				oEleitor.Sexo = Convert.ToString(cmbSexoEleitor.SelectedItem);

				CSistemaEleitoral.Incluir(oEleitor);
				MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCancelar.PerformClick();
			}
		}
	}
}
