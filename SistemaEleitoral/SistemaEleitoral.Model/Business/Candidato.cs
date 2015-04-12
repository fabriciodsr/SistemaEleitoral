using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SistemaEleitoral.Model
{
	public partial class Candidato
	{
		public static void Incluir(Candidato oCandidato)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "INSERT into Candidato (Numero, Cargo, Nome, CPF, Telefone, Identidade, Endereco, Bairro, Cidade, Cep, Estado, Email, DataNasc, Sexo, Foto) VALUES ('" + oCandidato.Numero + "', '" + oCandidato.Cargo + "', '" + oCandidato.Nome + "', '" + oCandidato.CPF + "', '" + oCandidato.Telefone + "', '" + oCandidato.Identidade + "', '" + oCandidato.Endereco + "', '" + oCandidato.Bairro + "', '" + oCandidato.Cidade + "', '" + oCandidato.Cep + "', '" + oCandidato.Estado + "', '" + oCandidato.Email + "', '" + oCandidato.DataNasc + "', '" + oCandidato.Sexo + "', '" + oCandidato.Foto + "')";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.ExecuteNonQuery();

			oCn.Close();
			oCn.Dispose();
		}

		public static void Alterar(Candidato oCandidato)
		{
		}
		public static void Excluir(string Numero)
		{
		}
		public static Candidato Selecionar(string Numero)
		{
			return null;
		}
		public static List<Candidato> SelecionarTodos()
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * from Candidato order by Nome";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			SqlDataReader oDr = oComando.ExecuteReader();

			List<Candidato> oRetorno = new List<Candidato>();
			while (oDr.Read())
			{
				Candidato oCandidato = new Candidato();
				oCandidato.Numero = oDr.GetString(oDr.GetOrdinal("Numero"));
				oCandidato.Cargo = oDr.GetString(oDr.GetOrdinal("Cargo"));
				oCandidato.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
				oCandidato.CPF = oDr.GetString(oDr.GetOrdinal("CPF"));
				oCandidato.Telefone = oDr.GetString(oDr.GetOrdinal("Telefone"));
				oCandidato.Identidade = oDr.GetString(oDr.GetOrdinal("Identidade"));
				oCandidato.Endereco = oDr.GetString(oDr.GetOrdinal("Endereco"));
				oCandidato.Bairro = oDr.GetString(oDr.GetOrdinal("Bairro"));
				oCandidato.Cidade = oDr.GetString(oDr.GetOrdinal("Cidade"));
				oCandidato.Cep = oDr.GetString(oDr.GetOrdinal("Cep"));
				oCandidato.Estado = oDr.GetString(oDr.GetOrdinal("Estado"));
				oCandidato.Email = oDr.GetString(oDr.GetOrdinal("Email"));
				oCandidato.DataNasc = oDr.GetString(oDr.GetOrdinal("DataNasc"));
				oCandidato.Sexo = oDr.GetString(oDr.GetOrdinal("Sexo"));
				oCandidato.Foto = oDr.GetString(oDr.GetOrdinal("Foto"));
				
				oRetorno.Add(oCandidato);
			}
			oDr.Close();
			oCn.Close();
			return oRetorno;
		}

	}
}
