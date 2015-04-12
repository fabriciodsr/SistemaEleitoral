﻿using System;
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

		private void frmDados_Load(object sender, EventArgs e)
		{

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
	}
}
