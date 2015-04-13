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
    public partial class frmCadastroMesario : Form
    {
        public frmCadastroMesario()
        {
            InitializeComponent();
        }

		private bool ValidaCampos()
		{
			if (txtCodigo.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Código do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCodigo.Focus();
				return false;
            }
			else if (txtSenha.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Senha do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSenha.Focus();
				return false;
			}
			else if (txtConfirmaSenha.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Confirmação de Senha do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtConfirmaSenha.Focus();
				return false;
			}
			else if  (txtConfirmaSenha.Text != txtSenha.Text)
			{
				MessageBox.Show("A Senha e Confirmação de Senha não coincidem!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSenha.Focus();
				return false;
			}
			else if (txtNome.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Nome do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtNome.Focus();
				return false;
			}
			else if (txtEndereco.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Endereço do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtEndereco.Focus();
				return false;
			}
			else if (txtBairro.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Bairro do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtBairro.Focus();
				return false;
			}
			else if (txtCidade.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Cidade do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCidade.Focus();
				return false;
			}
			else if (mtbCep.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o CEP do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				mtbCep.Focus();
				return false;
			}
			else if (cmbEstado.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Estado do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbEstado.Focus();
				return false;
			}
			else if (txtRg.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Identidade do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtRg.Focus();
				return false;
			}
			else if (txtCpf.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o CPF do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCpf.Focus();
				return false;
			}
			else if (dtpDataNasc.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Data de Nascimento do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtpDataNasc.Focus();
				return false;
			}
			else if (txtEmail.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o E-mail do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtEmail.Focus();
				return false;
			}
			else if (cmbSexo.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Sexo do Mesário!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbSexo.Focus();
				return false;
			}
			else
			{
				return true;
			}
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCodigo.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            cmbEstado.SelectedItem = null;
            cmbSexo.SelectedItem = null;
            mtbCep.Text = "";
            dtpDataNasc.Text = "";
            mtbTel.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (ValidaCampos())
			{
				Mesario oMesario = new Mesario();
				oMesario.Codigo = txtCodigo.Text.Trim();
				oMesario.Nome = txtNome.Text.Trim();
				oMesario.CPF = txtCpf.Text.Trim();
				oMesario.Telefone = mtbTel.Text;
				oMesario.Identidade = txtRg.Text.Trim();
				oMesario.Endereco = txtEndereco.Text.Trim();
				oMesario.Bairro = txtBairro.Text.Trim();
				oMesario.Cidade = txtCidade.Text.Trim();
				oMesario.Cep = mtbCep.Text;
				oMesario.Estado = Convert.ToString(cmbEstado.SelectedItem);
				oMesario.Email = txtEmail.Text.Trim();
				oMesario.DataNasc = dtpDataNasc.Text;
				oMesario.Sexo = Convert.ToString(cmbSexo.SelectedItem);
				oMesario.Senha = txtSenha.Text.Trim();

				CSistemaEleitoral.Incluir(oMesario);
				MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCancelar.PerformClick();
			}
		}
    }
}
