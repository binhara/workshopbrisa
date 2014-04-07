using System;
using System.Collections.Generic;
using System.Text;


namespace libBrisaPCL
{
	public class OrdemServico
	{
		public int id { get; set;}
		public string Nome { get; set;}
		public DateTime Data { get; set;}
		public string Usuario { get; set;}


		public List<OrdemServico> ListarOs(){
			List<OrdemServico> os = new List<OrdemServico>();

			OrdemServico ordem = new OrdemServico ();
			ordem.id = 1;
			ordem.Nome = "ordem 1";
			ordem.Data = DateTime.Now;
			ordem.Usuario = "User 1";
			os.Add (ordem);

			ordem = new OrdemServico ();
			ordem.id = 2;
			ordem.Nome = "ordem 2";
			ordem.Data = DateTime.Now;
			ordem.Usuario = "User 2";
			os.Add (ordem);

			ordem = new OrdemServico ();
			ordem.id = 3;
			ordem.Nome = "ordem 3";
			ordem.Data = DateTime.Now;
			ordem.Usuario = "User 3";
			os.Add (ordem);

			return os;
		}


		public static OrdemServico listaOsPorId (int _id)
		{

			List<OrdemServico> os = new List<OrdemServico>();

			OrdemServico ordem = new OrdemServico ();
			ordem.id = 1;
			ordem.Nome = "ordem 1";
			ordem.Data = DateTime.Now;
			ordem.Usuario = "User 1";
			os.Add (ordem);

			ordem = new OrdemServico ();
			ordem.id = 2;
			ordem.Nome = "ordem 2";
			ordem.Data = DateTime.Now;
			ordem.Usuario = "User 2";
			os.Add (ordem);

			ordem = new OrdemServico ();
			ordem.id = 3;
			ordem.Nome = "ordem 3";
			ordem.Data = DateTime.Now;
			ordem.Usuario = "User 3";
			os.Add (ordem);


			foreach (var item in os) {
				if (item.id==_id) {
					return item;
				}
			}

			return null;


		}

	}


}

