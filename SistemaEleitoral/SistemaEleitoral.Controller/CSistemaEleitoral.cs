using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEleitoral.Model;

namespace SistemaEleitoral.Controller
{
	public class CSistemaEleitoral
	{
		public static List<Eleitor> SelecionarTodos()
		{
			return SelecionarTodos();
		}

		public static void Incluir(Eleitor oEleitor)
		{
			Eleitor.Incluir(oEleitor);
		}
		public static void Incluir(Mesario oMesario)
		{
			Mesario.Incluir(oMesario);
		}
		public static void Incluir(Candidato oCandidato)
		{
			Candidato.Incluir(oCandidato);
		}
	}
}
