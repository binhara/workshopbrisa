using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace libbrisa
{
	public class Talhao
	{

		public int id { get; set;}
		public string Nome { get; set;}
		public int iProjeto{ get; set;}


		public List<Talhao> ListarTalhoes(){
			List<Talhao> talhoes = new List<Talhao>();

			Talhao talhao = new Talhao ();
			talhao.id = 1;
			talhao.Nome = "talhao 1";
			talhao.iProjeto = 1;
			talhoes.Add (talhao);

			talhao = new Talhao ();
			talhao.id = 2;
			talhao.Nome = "talhao 2";
			talhao.iProjeto = 2;
			talhoes.Add (talhao);

			talhao = new Talhao ();
			talhao.id = 3;
			talhao.Nome = "talhao 3";
			talhao.iProjeto = 3;
			talhoes.Add (talhao);

			return talhoes;
		}

		public static Talhao ListarTalhaoPorId(int id){
			List<Talhao> talhoes = new List<Talhao>();

			Talhao talhao = new Talhao ();
			talhao.id = 1;
			talhao.Nome = "talhao 1";
			talhao.iProjeto = 1;
			talhoes.Add (talhao);

			talhao = new Talhao ();
			talhao.id = 2;
			talhao.Nome = "talhao 2";
			talhao.iProjeto = 2;
			talhoes.Add (talhao);

			talhao = new Talhao ();
			talhao.id = 3;
			talhao.Nome = "talhao 3";
			talhao.iProjeto = 3;
			talhoes.Add (talhao);

			foreach (var item in talhoes) {
				if (item.id==id) {
					return item;
				}
			}
			return null;

		}

	}
}

