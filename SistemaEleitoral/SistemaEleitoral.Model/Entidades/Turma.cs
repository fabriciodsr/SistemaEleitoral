using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEleitoral.Model
{
	public partial class Turma
	{
		private string strNumero, strAno, strDescricao;

		public string Numero
		{
			get { return strNumero; }
			set { strNumero = value; }
		}
		public string Ano
		{
			get { return strAno; }
			set { strAno = value; }
		}
		public string Descricao
		{
			get { return strDescricao; }
			set { strDescricao = value; }
		}
	}
}
