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
        int cont = 0;

        public frmVotacao()
        {
            InitializeComponent();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
            tb_2.Text = "";
            rtb_Nome_Candidato.Text = "";
            pbCandidato.Image = imageList1.Images[0];
            habilita_botoes();
            //lblNomeCandidato.Text = "";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            //lblNomeCandidato.Text = "VOTO NULO";
            //txtNumero.Text = "00";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            cont++;
            if (cont == 1)
            {
                int num1 = Convert.ToInt32(tb_1.Text + tb_2.Text);
                lb_Cargo.Text = "COORDENADOR".ToString();
                rtb_Nome_Candidato.Text = "";
                tb_1.Text = "";
                tb_2.Text = "";
                pbCandidato.Image = imageList1.Images[0];
                habilita_botoes();
            }
            else if (cont == 2)
            {
                int num2 = Convert.ToInt32(tb_1.Text + tb_2.Text);
                lb_Cargo.Text = "DIRETOR".ToString();
                rtb_Nome_Candidato.Text = "";
                tb_1.Text = "";
                tb_2.Text = "";
                pbCandidato.Image = imageList1.Images[0];
                habilita_botoes();
            }
            else
            {
                int num3 = Convert.ToInt32(tb_1.Text + tb_2.Text);
            }
            //lblNomeCandidato.Text = "";
            //txtNumero.Text = "";
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
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
                bloqueia_botoes();
            }
        }

        private void bloqueia_botoes ()
        {
            btnNumero0.Enabled = false;
            btnNumero1.Enabled = false;
            btnNumero2.Enabled = false;
            btnNumero3.Enabled = false;
            btnNumero4.Enabled = false;
            btnNumero5.Enabled = false;
            btnNumero6.Enabled = false;
            btnNumero7.Enabled = false;
            btnNumero8.Enabled = false;
            btnNumero9.Enabled = false;
        }

        private void habilita_botoes ()
        {
            btnNumero0.Enabled = true;
            btnNumero1.Enabled = true;
            btnNumero2.Enabled = true;
            btnNumero3.Enabled = true;
            btnNumero4.Enabled = true;
            btnNumero5.Enabled = true;
            btnNumero6.Enabled = true;
            btnNumero7.Enabled = true;
            btnNumero8.Enabled = true;
            btnNumero9.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCandidato_Click(object sender, EventArgs e)
        {

        }

        private void frmVotacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
                ///frm.MdiParent = this;
                frm.Show();
                Close();
            }
        }

        private void frmVotacao_Load(object sender, EventArgs e)
        {
            tb_1.Focus();
        }

        private void tb_2_TextChanged(object sender, EventArgs e)
        {
            if (tb_2.Text != "")
            {
                int num = Convert.ToInt32(tb_1.Text + tb_2.Text);
                for (int i = 0; i< imageList1.Images.Count; i++)
                {
                    int x = i.CompareTo(num);
                    //int x = imageList1.Images[i].ToString().CompareTo(Convert.ToString (num));
                   // string nome = imageList1.Images[i].ToString();
                   // if(nome == Convert.ToString(num))
                   // {
                   //     pbCandidato.Image = imageList1.Images[i];
                   // }

                    if (x == 0)
                    {
                        pbCandidato.Image = imageList1.Images[i];
                        rtb_Nome_Candidato.Text = imageList1.Images[i].ToString();
                    }
                    
                }
                //pbCandidato.Image = imageList1.Images[1];
            }
        }

    }
}
