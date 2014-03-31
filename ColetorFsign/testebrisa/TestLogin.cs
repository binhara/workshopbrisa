using System;
using NUnit.Framework;
using libbrisa;

namespace testebrisa
{
	[TestFixture]
	public class TestLogin
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
			String senha = "1234";

			Assert.AreEqual (true , login.BuscarUsuarioLogin(nome, senha));

		}


	




	}
}

