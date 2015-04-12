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
    }
}
