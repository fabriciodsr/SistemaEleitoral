using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using SistemaEleitoral.Controller;
using SistemaEleitoral.Model;
using System.Data.SqlClient;

namespace SistemaEleitoral
{
    public partial class frmVotacao : Form
    {
        int cont = 0;
        string num1, num2, num3;

        private  SoundPlayer player1;

        private  SoundPlayer player2;

		string MatEleitor;

		public frmVotacao(string texto)
        {
            InitializeComponent();

            player1 = new SoundPlayer("urna.wav");

            player2 = new SoundPlayer("voto.wav");

			MatEleitor = texto;
        }

		private void btnCancela_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
            tb_2.Text = "";
			rtb_Nome_Candidato.Text = "";
			pbCandidato.Image = imageList1.Images[0];
            habilita_botoes();
			lblErroCargo.Visible = false;
			//lblNomeCandidato.Text = "";
		}

        private void btnBranco_Click(object sender, EventArgs e)
        {
            //lblNomeCandidato.Text = "VOTO NULO";
            //txtNumero.Text = "00";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (tb_1.Text != "" && tb_2.Text != "")
            {
                cont++;
                if (cont == 1)
                {
                    player2.Play();
                    num1 = (tb_1.Text + tb_2.Text);
                    lb_Cargo.Text = "COORDENADOR".ToString();
                    rtb_Nome_Candidato.Text = "";
                    tb_1.Text = "";
                    tb_2.Text = "";
                    pbCandidato.Image = imageList1.Images[0];
                    habilita_botoes();
                }
                else if (cont == 2)
                {
                    player2.Play();
                    num2 = (tb_1.Text + tb_2.Text);
                    lb_Cargo.Text = "DIRETOR".ToString();
                    rtb_Nome_Candidato.Text = "";
                    tb_1.Text = "";
                    tb_2.Text = "";
                    pbCandidato.Image = imageList1.Images[0];
                    habilita_botoes();
                }
                else
                {
                    player1.Play();
                    num3 = (tb_1.Text + tb_2.Text);
					//  System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"\imagens\urna.wav");
					//
					Votar(MatEleitor);
                    MessageBox.Show("VOTO REALIZADO COM SUCESSO", "VOTAÇÃO FINALIZADA");
                    System.Threading.Thread.Sleep(2000);
                    frmAutentica_Eleitor_Senha frm = new frmAutentica_Eleitor_Senha();
                    frm.Show();
                    Close();
                }
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
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
				CarregaCandidato();
            }
        }

		private void CarregaCandidato()
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT Nome FROM Candidato WHERE Numero = @num";
			string SQL2 = "SELECT Cargo FROM Candidato WHERE Numero = @num";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			SqlCommand oComando2 = new SqlCommand(SQL2, oCn);

			oComando.Parameters.Add("@num", SqlDbType.VarChar).Value = (tb_1.Text + tb_2.Text);
			oComando2.Parameters.Add("@num", SqlDbType.VarChar).Value = (tb_1.Text + tb_2.Text);

			string NomeCandidato;
			string CargoCandidato;

			NomeCandidato = Convert.ToString(oComando.ExecuteScalar());
			CargoCandidato = Convert.ToString(oComando2.ExecuteScalar());

			rtb_Nome_Candidato.Text = NomeCandidato;

			if (CargoCandidato == lb_Cargo.Text)
			{
				lb_Cargo.Text = CargoCandidato;
				btnConfirma.Enabled = true;
			}
			else
			{
				lblErroCargo.Visible = true;
				lblErroCargo.Text = "Selecione um candidato condizente com o cargo!";
				btnConfirma.Enabled = false;
			}
			oCn.Close();
			
		}

		private void Votar(string Matricula)
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "UPDATE Eleitor SET VotoRepresentante = '" + num1 + "', VotoCoordenador = '" + num2 + "', VotoDiretor = '" + num3 + "' WHERE Matricula = @mat";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.Parameters.Add("@mat", SqlDbType.VarChar).Value = Matricula;

			oComando.ExecuteNonQuery();
			
			oCn.Close();
			oCn.Dispose();
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
            if ((tb_2.Text != "") && (cont == 0))
            {
                int num = Convert.ToInt32(tb_1.Text + tb_2.Text);
                for (int i = 0; i< imageList1.Images.Count; i++)
                {
                    int x = i.CompareTo(num);
                
                    if (x == 0)
                    {
                        pbCandidato.Image = imageList1.Images[i];
                        rtb_Nome_Candidato.Text = imageList1.Images[i].ToString();
                    }
                    
                }
                
            } else if ((tb_2.Text != "") && (cont == 1))
            {
                int num = Convert.ToInt32(tb_1.Text + tb_2.Text);
                for (int i = 0; i < imageList2.Images.Count; i++)
                {
                    int x = i.CompareTo(num);

                    if (x == 0)
                    {
                        pbCandidato.Image = imageList2.Images[i];
                        rtb_Nome_Candidato.Text = imageList2.Images[i].ToString();
                    }

                }

            } else if ((tb_2.Text != "") && (cont == 2))
            {
                int num = Convert.ToInt32(tb_1.Text + tb_2.Text);
                for (int i = 0; i < imageList3.Images.Count; i++)
                {
                    int x = i.CompareTo(num);

                    if (x == 0)
                    {
                        pbCandidato.Image = imageList3.Images[i];
                        rtb_Nome_Candidato.Text = imageList3.Images[i].ToString();
                    }

                }
            }
        }

    }
}
