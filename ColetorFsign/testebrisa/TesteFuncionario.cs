using NUnit.Framework;
using System;
using libbrisa;

namespace testebrisa
{
	[TestFixture ()]
	public class TesteFuncionario
	{
		[Test ()]
		public void ListarFuncionario ()
		{
			Funcionario fun = new Funcionario ();
			Assert.IsNotNull (fun);
			Assert.AreEqual (fun.ListarFuncionario ().Count , 3);

		}
		[Test]
		public void ListarFuncionarioPorId ()
		{

			var fun = Funcionario.ListarFuncionarioPorId(2);

			Assert.IsNotNull (fun);
			Assert.AreEqual (fun.Id, 2);

		}
	}
}

