using System;
using NUnit.Framework;
using libbrisa;

namespace testebrisa
{
	[TestFixture]
	public class TestOrdemServico

	{
		[SetUp]
		public void Setup ()
		{
		}

		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void ListarOS ()
		{
			OrdemServico os = new OrdemServico ();
			Assert.IsNotNull (os);
			Assert.AreEqual (os.ListarOs ().Count , 3);

		}


		[Test]
		public void ListarOSPorID ()
		{

			var os = OrdemServico.listaOsPorId(2);

			Assert.IsNotNull (os);
			Assert.AreEqual (os.id, 2);

		}




	}
}

