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
            mtbDataNasc.Text = "";
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
			oMesario.DataNasc = mtbDataNasc.Text;
			oMesario.Sexo = Convert.ToString(cmbSexo.SelectedItem);

			CSistemaEleitoral.Incluir(oMesario);
			MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			btnCancelar.PerformClick();
		}
    }
}
