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
		public static SqlConnection ConexaoSqlServer()
		{
			SqlConnection oCn = new SqlConnection("Data Source=FABS-PC;Initial Catalog=SistemaEleitoral;Integrated Security=True");//"Server =.\\FABS-PC;Database=SistemaEleitoral;trusted_connection;");
			oCn.Open();
			return oCn;
		}
	}
}
