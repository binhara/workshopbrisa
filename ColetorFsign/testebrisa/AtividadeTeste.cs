using System;
using NUnit.Framework;
using libBrisaPCL;

namespace testebrisa
{
	[TestFixture]
	public class AtividadeTeste
	{


		[Test]
		public void ListarAtividade()
		{
			Atividade atividade = new Atividade ();
			Assert.IsNotNull (atividade);
			Assert.AreEqual (atividade.listaAtividade ().Count , 3);

		}


		[Test]
		public void ListarAtividadePorID ()
		{

			var atividade = Atividade.listaAtividadePorId(2);

			Assert.IsNotNull (atividade);
			Assert.AreEqual (atividade.id, 2);

		}


	}
}

