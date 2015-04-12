using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEleitoral.Model
{
	public class Eleitor
	{
		private string strMatricula, strNome, strCPF, strIdentidade, strEndereco, strBairro, strCidade, strCep,
		strEstado, strEmail, strDataNasc, strSexo, strVotoRepresentante, strVotoCoordenador, strVotoDiretor;

		public string Matricula { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Telefone { get; set; }
		public string Identidade { get; set; }
		public string Endereco { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Cep { get; set; }
		public string Estado { get; set; }
		public string Email { get; set; }
		public string DataNasc { get; set; }
		public string Sexo { get; set; }
		public string VotoRepresentante { get; set; }
		public string VotoCoordenador { get; set; }
		public string VotoDiretor { get; set; }

	}
}
