using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtFoto.Text = "foto.jpg";
            pbCandidato.Image = null;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
