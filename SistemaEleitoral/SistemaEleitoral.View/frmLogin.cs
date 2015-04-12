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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            btnEntrar.Text = "Entrar >>";
            btnEntrar.DialogResult = DialogResult.OK;
        }
		private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

        private void button7_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //frmMenu frm = new frmMenu();
            //frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
