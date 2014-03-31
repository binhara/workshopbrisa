using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libbrisa
{
	public class Atividade
	{

		public int id { get; set;}
		public string Nome { get; set;}
		public int idunidademedida { get; set;}


		public List<Atividade> listaAtividade(){
			List<Atividade> ListadeAtividades = new List<Atividade>();

			Atividade ativ1 = new Atividade ();
			ativ1.id = 1;
			ativ1.Nome = "atividade 1";
			ativ1.idunidademedida = 1;
			ListadeAtividades.Add (ativ1);

			Atividade ativ2  = new Atividade ();
			ativ2.id = 2;
			ativ2.Nome = "atividade 2";
			ativ2.idunidademedida = 1;
			ListadeAtividades.Add (ativ2);

			Atividade atv3 = new Atividade ();
			atv3.id = 3;
			atv3.Nome = "atividade 3";
			atv3.idunidademedida = 1;
			ListadeAtividades.Add (atv3);

			return ListadeAtividades;
		}

		public static Atividade listaAtividadePorId(int id){
			List<Atividade> ListadeAtividades = new List<Atividade>();

			Atividade ativ1 = new Atividade ();
			ativ1.id = 1;
			ativ1.Nome = "atividade 1";
			ativ1.idunidademedida = 1;
			ListadeAtividades.Add (ativ1);

			Atividade ativ2  = new Atividade ();
			ativ2.id = 2;
			ativ2.Nome = "atividade 2";
			ativ2.idunidademedida = 1;
			ListadeAtividades.Add (ativ2);

			Atividade atv3 = new Atividade ();
			atv3.id = 3;
			atv3.Nome = "atividade 3";
			atv3.idunidademedida = 1;
			ListadeAtividades.Add (atv3);

			foreach (var item in ListadeAtividades) {
				if (item.id==id) {
					return item;
				}
			}
			return null;
		
		}

	}
}
