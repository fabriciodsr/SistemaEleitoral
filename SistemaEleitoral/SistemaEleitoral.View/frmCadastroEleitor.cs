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
            mtbDataNascEleitor.Text = "";
            mtbTelEleitor.Text = "";
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btnSalvar_Click(object sender, EventArgs e)
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
			oEleitor.DataNasc = mtbDataNascEleitor.Text;
			oEleitor.Sexo = Convert.ToString(cmbSexoEleitor.SelectedItem);

			CSistemaEleitoral.Incluir(oEleitor);
		}
	}
}
