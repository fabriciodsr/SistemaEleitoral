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
    public partial class frmVotacao : Form
    {
        public frmVotacao()
        {
            InitializeComponent();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lblNomeCandidato.Text = "";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            lblNomeCandidato.Text = "VOTO NULO";
            txtNumero.Text = "00";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            lblNomeCandidato.Text = "";
            txtNumero.Text = "";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "2";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "2";
            }
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "3";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "3";
            }
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "4";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "4";
            }
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "5";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "5";
            }
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "6";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "6";
            }
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "7";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "7";
            }
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "8";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "8";
            }
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "9";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "9";
            }
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "0";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "0";
            }
        }

        private void btnNumero1_Click_1(object sender, EventArgs e)
        {
            if (tb_1.Text == "")
            {
                tb_1.Text = "1";
            }
            else if (tb_2.Text == "")
            {
                tb_2.Text = "1";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCandidato_Click(object sender, EventArgs e)
        {

        }
    }
}
