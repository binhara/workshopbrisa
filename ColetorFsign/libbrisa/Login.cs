using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace libbrisa
{
	public class Login
	{
		public int id { get; set;}
		public string Nome { get; set;}
		public string Senha { get; set;}


		public bool BuscarUsuarioLogin(string nome, string senha)
		{
			if(nome.Equals("Joao") && senha.Equals("123")){
				return true;
			}else{
				return false;
			}			

		}

	}

}

