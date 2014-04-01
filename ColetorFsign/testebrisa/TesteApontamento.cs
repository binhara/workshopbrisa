using System;
using NUnit.Framework;
using libbrisa;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testebrisa
{
	[TestFixture ()]
	public class TesteApontamento
	{
		[Test ()]
		public void TestCase ()
		{

		}

		[Test ()]
		public void CriarApontamento()
		{
			Apontamento apt = new Apontamento ();

			apt.id = 1;
			apt.idTalhao = 2;
			apt.Data = DateTime.Now;

			Apontamento negocio = new Apontamento();
			negocio.CriarApontamento(apt);

			//FALTA O TESTE NOVO APONTAMENTO  
		}
	}
}

