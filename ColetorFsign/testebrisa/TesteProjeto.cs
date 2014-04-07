using NUnit.Framework;
using System;
using libBrisaPCL;

namespace testebrisa
{
	[TestFixture ()]
	public class TesteProjeto
	{

		[Test]
		public void ListarProjeto ()
		{
			Projeto proj = new Projeto  ();
			Assert.IsNotNull (proj);
			Assert.AreEqual (proj.ListarProjetos().Count , 3);

		}


		[Test]
		public void ListarProjetoPorID ()
		{

			var proj = Projeto.ListarProjetosPorId(2);

			Assert.IsNotNull (proj);
			Assert.AreEqual (proj.Id, 2);

		}
	}
}

