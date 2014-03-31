using System;
using NUnit.Framework;
using libbrisa;

namespace testebrisa
{
	[TestFixture]
	public class TalhaoTeste
	{


		[Test]
		public void ListarTalhoes()
		{
			Talhao talhao = new Talhao ();
			Assert.IsNotNull (talhao);
			Assert.AreEqual (talhao.ListarTalhoes().Count , 3);

		}


		[Test]
		public void ListarTalhaoPorId ()
		{

			var talhao = Talhao.ListarTalhaoPorId(2);

			Assert.IsNotNull (talhao);
			Assert.AreEqual (talhao.id, 2);

		}


	}
}

