using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEleitoral.Controller;
using SistemaEleitoral.Model;
using System.Data.SqlClient;

namespace SistemaEleitoral
{
	public partial class frmDados : Form
	{

		public frmDados()
		{
			InitializeComponent();
		}

		private void label24_Click(object sender, EventArgs e)
		{

		}

		private int ContagemEleitores()
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT COUNT(*) FROM Eleitor";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			int QuantEleitores;

			QuantEleitores = Convert.ToInt32(oComando.ExecuteScalar());

			oCn.Close();
			return QuantEleitores;
		}

		private int ContagemVotos()
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT COUNT(VotoRepresentante + VotoCoordenador + VotoDiretor) FROM Eleitor";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			int QuantVotos;

			QuantVotos = Convert.ToInt32(oComando.ExecuteScalar());

			oCn.Close();
			return QuantVotos;
		}

		private void frmDados_Load(object sender, EventArgs e)
		{
			CarregarDados();
			lblQuantEleitores.Text = ContagemEleitores().ToString();
			lblQuantVotos.Text = ContagemVotos().ToString();
		}

		SqlDataAdapter adapter;
		BindingSource bsource = new BindingSource();
		DataSet dataSet = null;
		string SQL;

		public void CarregarDados()
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			SQL = "SELECT * FROM Eleitor";

			adapter = new SqlDataAdapter(SQL, oCn);
			dataSet = new DataSet();
			SqlCommandBuilder oCommand = new SqlCommandBuilder(adapter);
			adapter.Fill(dataSet, "Eleitor");
			bsource.DataSource = dataSet.Tables["Eleitor"];
			dtgEleitores.DataSource = bsource;
		}

		
		private void button12_Click(object sender, EventArgs e)
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * FROM Candidato WHERE Numero = @num OR Nome = @nome";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.Parameters.Add("@num", SqlDbType.VarChar).Value = txtNumeroCandidato.Text;
			oComando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeCandidato.Text;

			oComando.Connection = oCn;
			oComando.CommandText = SQL;

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = oComando;

			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet);

			dtgCandidatos.DataSource = dataSet;
			dtgCandidatos.DataMember = dataSet.Tables[0].TableName;
			oCn.Close();
		}

		private void btnPesquisaEleitor_Click(object sender, EventArgs e)
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * FROM Eleitor WHERE Matricula = @mat OR Nome = @nome";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.Parameters.Add("@mat", SqlDbType.VarChar).Value = txtMatEleitor.Text;
			oComando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeEleitor.Text;

			oComando.Connection = oCn;
			oComando.CommandText = SQL;

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = oComando;

			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet);

			dtgEleitores.DataSource = dataSet;
			dtgEleitores.DataMember = dataSet.Tables[0].TableName;
			oCn.Close();
		}

		private void btnPesquisaMesario_Click(object sender, EventArgs e)
		{
			SqlConnection oCn = Model.Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * FROM Mesario WHERE Codigo = @cod OR Nome = @nome";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.Parameters.Add("@cod", SqlDbType.VarChar).Value = txtCodigoMesario.Text;
			oComando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeMesario.Text;

			oComando.Connection = oCn;
			oComando.CommandText = SQL;

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = oComando;

			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet);

			dtgMesarios.DataSource = dataSet;
			dtgMesarios.DataMember = dataSet.Tables[0].TableName;
			oCn.Close();
		}

		private void label23_Click(object sender, EventArgs e)
		{

		}

		private void btnCargos_Click(object sender, EventArgs e)
		{
			dtgCargos.DataSource = CSistemaEleitoral.SelecionarTodos();
		}

		private void dtgEleitores_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			/*if (dtgEleitores.Rows[e.RowIndex].DataBoundItem != null)
			{
				Eleitor oEleitor = (Eleitor)dtgEleitores.Rows[e.RowIndex].DataBoundItem;
			}*/
		}

		private void tabEleitores_Enter(object sender, EventArgs e)
		{
			CarregarDados();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = dataSet.Tables["Eleitor"];
				this.dtgEleitores.BindingContext[dt].EndCurrentEdit();
				this.adapter.Update(dt);
				MessageBox.Show("Banco de dados Atualizado com sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dtgEleitores_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			if (!e.Row.IsNewRow)
			{
				DialogResult res = MessageBox.Show("Tem certeza de que deseja deletar esta linha ?", "Deletar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.No)
					e.Cancel = true;
			}
		}

	}
}
