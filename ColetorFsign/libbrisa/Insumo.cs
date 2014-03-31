using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libbrisa
{
	public class Insumo
	{
		public int Id { get; set;}
		public String Nome { get; set;}
		public double Dosagem { get; set;}

		public List<Insumo> ListarInsumos()
		{
			List<Insumo> insumos = new List<Insumo> ();
			Insumo insumo = new Insumo ();

			insumo.Id = 1;
			insumo.Nome = "bla bla bla 1";
			insumo.Dosagem = 1;
			insumos.Add (insumo);

			insumo = new Insumo ();
			insumo.Id = 2;
			insumo.Nome = "bla bla bla 2";
			insumo.Dosagem = 2;
			insumos.Add (insumo);

			insumo = new Insumo ();
			insumo.Id = 3;
			insumo.Nome = "bla bla bla 3";
			insumo.Dosagem = 3;
			insumos.Add (insumo);

			return insumos;
		}
		public static Insumo ListarInsumosPorId(int _id)
		{
			List<Insumo> insumos = new List<Insumo> ();

			Insumo insu = new Insumo ();
			insu.Id = 1;
			insu.Nome = "bla bla bla 1";
			insu.Dosagem = 1;
			insumos.Add (insu);

			insu = new Insumo ();
			insu.Id = 2;
			insu.Nome = "bla bla bla 2";
			insu.Dosagem = 2;
			insumos.Add (insu);

			insu = new Insumo ();
			insu.Id = 3;
			insu.Nome = "bla bla bla 3";
			insu.Dosagem = 3;
			insumos.Add (insu);

			foreach (var item in insumos ){
				if (item.Id ==_id) {
					return item;
				}
			}

			return null;
		}
	}
}

