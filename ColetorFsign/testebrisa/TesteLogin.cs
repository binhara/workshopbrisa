using System;
using NUnit.Framework;
using libbrisa;

namespace testebrisa
{
	[TestFixture]
	public class TesteLogin
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
		public void BuscarUsuarioLogin()
		{
			Login login = new Login ();
			String nome = "Joao";
			String senha = "123";

			Assert.AreEqual (true , login.BuscarUsuarioLogin(nome, senha));

		}


	




	}
}

