﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEleitoral.Model
{
	public partial class Eleitor
	{
		public static void Incluir(Eleitor oEleitor)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "INSERT into Eleitor (Matricula, Nome, CPF, Telefone, Identidade, Endereco, Bairro, Cidade, Cep, Estado, Email, DataNasc, Sexo) VALUES ('" + oEleitor.Matricula + "', '" + oEleitor.Nome + "', '" + oEleitor.CPF + "', '" + oEleitor.Telefone + "', '" + oEleitor.Identidade + "', '" + oEleitor.Endereco + "', '" + oEleitor.Bairro + "', '" + oEleitor.Cidade + "', '" + oEleitor.Cep + "', '" + oEleitor.Estado + "', '" + oEleitor.Email + "', '" + oEleitor.DataNasc + "', '" + oEleitor.Sexo + "')";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.ExecuteNonQuery();

			oCn.Close();
			oCn.Dispose();
		}

		public static int Alterar(Eleitor oEleitor)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "UPDATE Eleitor Matricula='" + oEleitor.Matricula + "', Nome='" + oEleitor.Nome + "', CPF='" + oEleitor.CPF + "', Telefone='" + oEleitor.Telefone + "', Identidade='" + oEleitor.Identidade + "', Endereco='" + oEleitor.Endereco + "', Bairro='" + oEleitor.Bairro + "', Cidade='" + oEleitor.Cidade + "', Cep='" + oEleitor.Cep + "', Estado='" + oEleitor.Estado + "', Email='" + oEleitor.Email + "', DataNasc='" + oEleitor.DataNasc + "', Sexo='" + oEleitor.Sexo + "' WHERE Matricula='" + oEleitor.Matricula + "')";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			var Retorno = oComando.ExecuteNonQuery();

			oCn.Close();
			oCn.Dispose();

			return Retorno;

		}
		public static int Excluir(string Matricula)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "DELETE FROM Eleitor WHERE Matricula='" + Matricula + "')";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			var Retorno = oComando.ExecuteNonQuery();

			oCn.Close();
			oCn.Dispose();

			return Retorno;
		}
		public static Eleitor Selecionar(string Matricula)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * from Eleitor WHERE Matricula='" + Matricula + "'";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			SqlDataReader oDr = oComando.ExecuteReader();

			Eleitor oEleitor = null;
			if (oDr.Read())
			{
				oEleitor.Matricula = oDr.GetString(oDr.GetOrdinal("Matricula"));
				oEleitor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
				oEleitor.CPF = oDr.GetString(oDr.GetOrdinal("CPF"));
				oEleitor.Telefone = oDr.GetString(oDr.GetOrdinal("Telefone"));
				oEleitor.Identidade = oDr.GetString(oDr.GetOrdinal("Identidade"));
				oEleitor.Endereco = oDr.GetString(oDr.GetOrdinal("Endereco"));
				oEleitor.Bairro = oDr.GetString(oDr.GetOrdinal("Bairro"));
				oEleitor.Cidade = oDr.GetString(oDr.GetOrdinal("Cidade"));
				oEleitor.Cep = oDr.GetString(oDr.GetOrdinal("Cep"));
				oEleitor.Estado = oDr.GetString(oDr.GetOrdinal("Estado"));
				oEleitor.Email = oDr.GetString(oDr.GetOrdinal("Email"));
				oEleitor.DataNasc = oDr.GetString(oDr.GetOrdinal("DataNasc"));
				oEleitor.Sexo = oDr.GetString(oDr.GetOrdinal("Sexo"));
				oEleitor.VotoRepresentante = oDr.GetString(oDr.GetOrdinal("VotoRepresentante"));
				oEleitor.VotoCoordenador = oDr.GetString(oDr.GetOrdinal("VotoCoordenador"));
				oEleitor.VotoDiretor = oDr.GetString(oDr.GetOrdinal("VotoDiretor"));
			}
			oDr.Close();
			oCn.Close();
			oCn.Dispose();
			return oEleitor;
		}
		public static List<Eleitor> SelecionarTodos()
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * from Eleitor order by Nome";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			SqlDataReader oDr = oComando.ExecuteReader();

			List<Eleitor> oRetorno = new List<Eleitor>();
			while (oDr.Read())
			{
				Eleitor oEleitor = new Eleitor();
				oEleitor.Matricula = oDr.GetString(oDr.GetOrdinal("Matricula"));
                oEleitor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
				oEleitor.CPF = oDr.GetString(oDr.GetOrdinal("CPF"));
				oEleitor.Telefone = oDr.GetString(oDr.GetOrdinal("Telefone"));
				oEleitor.Identidade = oDr.GetString(oDr.GetOrdinal("Identidade"));
				oEleitor.Endereco = oDr.GetString(oDr.GetOrdinal("Endereco"));
				oEleitor.Bairro = oDr.GetString(oDr.GetOrdinal("Bairro"));
				oEleitor.Cidade = oDr.GetString(oDr.GetOrdinal("Cidade"));
				oEleitor.Cep = oDr.GetString(oDr.GetOrdinal("Cep"));
				oEleitor.Estado = oDr.GetString(oDr.GetOrdinal("Estado"));
				oEleitor.Email = oDr.GetString(oDr.GetOrdinal("Email"));
				oEleitor.DataNasc = oDr.GetString(oDr.GetOrdinal("DataNasc"));
				oEleitor.Sexo = oDr.GetString(oDr.GetOrdinal("Sexo"));
				oEleitor.VotoRepresentante = oDr.GetString(oDr.GetOrdinal("VotoRepresentante"));
				oEleitor.VotoCoordenador = oDr.GetString(oDr.GetOrdinal("VotoCoordenador"));
				oEleitor.VotoDiretor = oDr.GetString(oDr.GetOrdinal("VotoDiretor"));

				oRetorno.Add(oEleitor);
			}
			oDr.Close();
			oCn.Close();
			oCn.Dispose();
			return oRetorno;
		}
	}
}
