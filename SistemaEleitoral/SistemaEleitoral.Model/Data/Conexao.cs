using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEleitoral.Model.Data
{
	public class Conexao
	{
		public static SqlConnection ConexaoSqlServer
		{
			SqlConnection oCn = new SqlConnection();
		}
	}
}
