using NUnit.Framework;
using System;
using libbrisa;

namespace testebrisa
{
	[TestFixture ()]
	public class TesteApontamento
	{
		[Test ()]
		public void  listaapontamento ()
		{
			Apontamento apontamento = new Apontamento ();
			Assert.IsNotNull (apontamento);
			Assert.AreEqual (apontamento.listaapontamento ().Count , 4);

		}

		[Test]
		public void listaapontamentoPorId ()
		{
			Apontamento apontamento = new Apontamento ();
			apontamento = apontamento.listaapontamentoPorId(2);


			Assert.IsNotNull (apontamento);
			Assert.AreEqual (apontamento.id, 2);

		}

		[Test]
		public void InsereApontamento ()
		{
			Apontamento apont = new Apontamento();
			Assert.IsNotNull (apont);

			apont.id = 4;
			apont.funcionario = "Teste 4";
			apont.qtde = 19;
			apont.hraTrab = 8;
			apont.insere ( apont);

			Apontamento apontamento = new Apontamento ();
			apontamento = apontamento.listaapontamentoPorId(4);
			Assert.AreEqual (apontamento.id, 4);

		}
		[Test]
		public void InsereApontamentoBanco ()
		{
			Apontamento apont = new Apontamento();
			Assert.IsNotNull (apont);

			apont.id = 4;
			apont.funcionario = "Teste 4";
			apont.qtde = 19;
			apont.hraTrab = 8;

			Assert.Equals (apont.insereNoBanco (apont), true);
		}


	}
}

