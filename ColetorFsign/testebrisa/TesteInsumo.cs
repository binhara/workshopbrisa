using System;
using NUnit.Framework;
using libbrisa;


namespace testebrisa
{
	[TestFixture]
	public class TesteInsumo
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
		public void ListarInsumo ()
		{
			Insumo ins = new Insumo ();
			Assert.IsNotNull (ins);
			Assert.AreEqual (ins.ListarInsumos ().Count , 3);

		}


		[Test]
		public void ListarInsumoPorID ()
		{

			var ins = Insumo.ListarInsumosPorId(2);

			Assert.IsNotNull (ins);
			Assert.AreEqual (ins.Id, 2);

		}



	}
}

