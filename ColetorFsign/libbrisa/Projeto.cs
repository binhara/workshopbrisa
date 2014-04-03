using System;
using System.Collections.Generic;

namespace libbrisa
{
	public class Projeto
	{
		public int Id{ get; set;}
		public string Nome {
			get;
			set;
		}

		public Projeto(){
		}

		public Projeto (int id, string nome)
		{
			this.Id = id;
			this.Nome = nome;
		}

		public List<Projeto > ListarProjetos(){

			List<Projeto> Projetos = new List<Projeto> ();

			Projetos.Add (new Projeto(1,"proj 1"));
			Projetos.Add (new Projeto(2,"proj 2"));
			Projetos.Add (new Projeto(3,"proj 3"));

			return Projetos;
		}

		public static Projeto  ListarProjetosPorId(int id){

			List<Projeto> Projetos = new List<Projeto> ();

			Projetos.Add (new Projeto(1,"proj 1"));
			Projetos.Add (new Projeto(2,"proj 2"));
			Projetos.Add (new Projeto(3,"proj 3"));

			foreach (var item in Projetos) {
				if (item.Id == id)
					return item;
			}

			return null;
		}
	}
}

