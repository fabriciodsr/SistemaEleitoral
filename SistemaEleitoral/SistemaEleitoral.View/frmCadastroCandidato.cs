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

		private void btnSalvar_Click(object sender, EventArgs e)
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
