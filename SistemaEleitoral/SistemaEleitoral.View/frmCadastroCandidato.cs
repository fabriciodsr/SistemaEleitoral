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
    public partial class frmCadastroCandidato : Form
    {
        public frmCadastroCandidato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (String arquivo in open.FileNames)
                {
                    txtFoto.Text = arquivo;
                    PictureBox pb = new PictureBox();
                    Image imagem = Image.FromFile(arquivo);
                    pbCandidato.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbCandidato.Image = imagem;

                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtNumero.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            cmbEstado.SelectedItem = null;
            cmbSexo.SelectedItem = null;
			cmbCargo.SelectedItem = null;
            mtbCep.Text = "";
            dtpDataNasc.Text = "";
            mtbTel.Text = "";
            txtFoto.Text = "foto.jpg";
            pbCandidato.Image = null;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private bool ValidaCampos()
		{
			if (txtNumero.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Numero do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtNumero.Focus();
				return false;
			}
			else if (cmbCargo.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Cargo do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbCargo.Focus();
				return false;
			}
			else if (txtNome.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Nome do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtNome.Focus();
				return false;
			}
			else if (txtEndereco.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Endereço do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtEndereco.Focus();
				return false;
			}
			else if (txtBairro.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o Bairro do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtBairro.Focus();
				return false;
			}
			else if (txtCidade.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Cidade do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCidade.Focus();
				return false;
			}
			else if (mtbCep.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o CEP do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				mtbCep.Focus();
				return false;
			}
			else if (cmbEstado.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Estado do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbEstado.Focus();
				return false;
			}
			else if (txtRg.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Identidade do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtRg.Focus();
				return false;
			}
			else if (txtCpf.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o CPF do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCpf.Focus();
				return false;
			}
			else if (dtpDataNasc.Text.Trim() == "")
			{
				MessageBox.Show("Preencha a Data de Nascimento do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtpDataNasc.Focus();
				return false;
			}
			else if (txtEmail.Text.Trim() == "")
			{
				MessageBox.Show("Preencha o E-mail do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtEmail.Focus();
				return false;
			}
			else if (cmbSexo.SelectedItem == null)
			{
				MessageBox.Show("Selecione o Sexo do Candidato!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbSexo.Focus();
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
				Candidato oCandidato = new Candidato();
				oCandidato.Numero = txtNumero.Text.Trim();
				oCandidato.Cargo = Convert.ToString(cmbCargo.SelectedItem);
				oCandidato.Nome = txtNome.Text.Trim();
				oCandidato.CPF = txtCpf.Text.Trim();
				oCandidato.Telefone = mtbTel.Text;
				oCandidato.Identidade = txtRg.Text.Trim();
				oCandidato.Endereco = txtEndereco.Text.Trim();
				oCandidato.Bairro = txtBairro.Text.Trim();
				oCandidato.Cidade = txtCidade.Text.Trim();
				oCandidato.Cep = mtbCep.Text;
				oCandidato.Estado = Convert.ToString(cmbEstado.SelectedItem);
				oCandidato.Email = txtEmail.Text.Trim();
				oCandidato.DataNasc = dtpDataNasc.Text;
				oCandidato.Sexo = Convert.ToString(cmbSexo.SelectedItem);
				oCandidato.Foto = txtFoto.Text;

				CSistemaEleitoral.Incluir(oCandidato);
				MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCancelar.PerformClick();
			}
		}
	}
}
