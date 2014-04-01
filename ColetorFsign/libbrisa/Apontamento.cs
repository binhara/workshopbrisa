using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libbrisa
{
	public class Apontamento
	{
		public int id { get; set;}
		public int idTalhao { get; set;}
		public DateTime Data { get; set;}

		//INSERT -> RETURN VOID 
		//TESTE -> RETURN LIST<Apontamento>
		public List<Apontamento> CriarApontamento (Apontamento pApt)
		{
			Apontamento Apt = new Apontamento();

			Apt.id = pApt.id;
			Apt.idTalhao = pApt.idTalhao;
			Apt.Data = pApt.Data;
		
			//inserir banco
			// db.insert(Apt)

			//Testar 
			List<Apontamento> lstApontamento = new List<Apontamento>();

			lstApontamento.Add(Apt);

			return lstApontamento;

		}
	}
}

