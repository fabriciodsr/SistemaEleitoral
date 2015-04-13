using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEleitoral.Model
{
	public partial class Turma
	{
		public static void Incluir(Turma oTurma)
		{
			SqlConnection oCn = Data.Conexao.ConexaoSqlServer();
			string SQL = "INSERT into Turma (Numero, Ano, Descricao) VALUES ('" + oTurma.Numero + "', '" + oTurma.Ano + "', '" + oTurma.Descricao + "')";

			SqlCommand oComando = new SqlCommand(SQL, oCn);
			oComando.ExecuteNonQuery();

			oCn.Close();
			oCn.Dispose();
		}
	}
}
