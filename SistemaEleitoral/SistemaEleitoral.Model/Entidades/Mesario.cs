using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEleitoral.Model.Entidades
{
	public class Mesario
	{
		private string strCodigo, strNome, strCPF, strTelefone, strIdentidade, strEndereco, strBairro, strCidade, strCep,
		strEstado, strEmail, strDataNasc, strSexo, strSenha;

		public string Codigo
		{
			get { return strCodigo; }
			set { strCodigo = value; }
		}
		public string Nome
		{
			get { return strNome; }
			set { strNome = value; }
		}
		public string CPF
		{
			get { return strCPF; }
			set { strCPF = value; }
		}
		public string Telefone
		{
			get { return strTelefone; }
			set { strTelefone = value; }
		}
		public string Identidade
		{
			get { return strIdentidade; }
			set { strIdentidade = value; }
		}
		public string Endereco
		{
			get { return strEndereco; }
			set { strEndereco = value; }
		}
		public string Bairro
		{
			get { return strBairro; }
			set { strBairro = value; }
		}
		public string Cidade
		{
			get { return strCidade; }
			set { strCidade = value; }
		}
		public string Cep
		{
			get { return strCep; }
			set { strCep = value; }
		}
		public string Estado
		{
			get { return strEstado; }
			set { strEstado = value; }
		}
		public string Email
		{
			get { return strEmail; }
			set { strEmail = value; }
		}
		public string DataNasc
		{
			get { return strDataNasc; }
			set { strDataNasc = value; }
		}
		public string Sexo
		{
			get { return strSexo; }
			set { strSexo = value; }
		}
		public string Senha
		{
			get { return strSenha; }
			set { strSenha = value; }
		}
		
	}
}
