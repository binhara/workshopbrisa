using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using libTeste;


namespace TelaApontamentoOS
{
	[Activity (Label = "TelaListaOS")]			
	public class TelaListaOS : Activity
	{

		OrdemServico itensOs;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			itensOs = new OrdemServico ();
			var lista = itensOs.ListarOs ();

			//ListView ListadeOS = FindViewById<ListView>();
			//ListadeOS.Adapter =  new ArrayAdapter<OrdemServico>(this, Android.Resource.Layout.SimpleListItem1, lista);

			List<string> listaNome = new List<String>();
			foreach (var item in lista) {
				listaNome.Add (item.Nome);
			}

			OSAdaptert os = new OSAdaptert (this, listaNome.ToArray ());

		}
	}
}

