using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEleitoral.Model
{
	public partial class Mesario
	{
		public static void Incluir(Mesario oMesario)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "INSERT into Mesario (Codigo, Nome, CPF, Telefone, Identidade, Endereco, Bairro, Cidade, Cep, Estado, Email, DataNasc, Sexo, Senha) VALUES ('" + oMesario.Codigo + "', '" + oMesario.Nome + "', '" + oMesario.CPF + "', '" + oMesario.Telefone + "', '" + oMesario.Identidade + "', '" + oMesario.Endereco + "', '" + oMesario.Bairro + "', '" + oMesario.Cidade + "', '" + oMesario.Cep + "', '" + oMesario.Estado + "', '" + oMesario.Email + "', '" + oMesario.DataNasc + "', '" + oMesario.Sexo + "', '" + oMesario.Senha + "')";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.ExecuteNonQuery();

			oCn.Close();
			oCn.Dispose();
		}

		public static void Alterar(Mesario oMesario)
		{
		}
		public static void Excluir(string Codigo)
		{
		}
		public static Mesario Selecionar(string Codigo)
		{
			return null;
		}
		public static List<Mesario> SelecionarTodos()
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "SELECT * from Mesario order by Nome";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			SqlDataReader oDr = oComando.ExecuteReader();

			List<Mesario> oRetorno = new List<Mesario>();
			while (oDr.Read())
			{
				Mesario oMesario = new Mesario();
				oMesario.Codigo = oDr.GetString(oDr.GetOrdinal("Codigo"));
				oMesario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
				oMesario.CPF = oDr.GetString(oDr.GetOrdinal("CPF"));
				oMesario.Telefone = oDr.GetString(oDr.GetOrdinal("Telefone"));
				oMesario.Identidade = oDr.GetString(oDr.GetOrdinal("Identidade"));
				oMesario.Endereco = oDr.GetString(oDr.GetOrdinal("Endereco"));
				oMesario.Bairro = oDr.GetString(oDr.GetOrdinal("Bairro"));
				oMesario.Cidade = oDr.GetString(oDr.GetOrdinal("Cidade"));
				oMesario.Cep = oDr.GetString(oDr.GetOrdinal("Cep"));
				oMesario.Estado = oDr.GetString(oDr.GetOrdinal("Estado"));
				oMesario.Email = oDr.GetString(oDr.GetOrdinal("Email"));
				oMesario.DataNasc = oDr.GetString(oDr.GetOrdinal("DataNasc"));
				oMesario.Sexo = oDr.GetString(oDr.GetOrdinal("Sexo"));
				oMesario.Senha = oDr.GetString(oDr.GetOrdinal("Senha"));

				oRetorno.Add(oMesario);
			}
			oDr.Close();
			oCn.Close();
			return oRetorno;
		}
	}
}
