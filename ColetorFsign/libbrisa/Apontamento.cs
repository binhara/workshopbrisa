using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libbrisa
{
	public class Apontamento
	{

		public int id{get; set;}
		public string funcionario{get; set;}
		public double qtde{ get; set;}
		public double hraTrab{ get; set;}


		static List <Apontamento> Listadeapontamentos = new List <Apontamento>();
		 
		public Apontamento (){
		}

		public Apontamento (int id, string funcionario, double qtde, double hraTrab){
			this.id = id;
			this.funcionario = funcionario;
			this.qtde = qtde;
			this.hraTrab = hraTrab;
		}
		public List<Apontamento> listaapontamento(){


			Apontamento apontamento = new Apontamento ();

			apontamento.id = 1;
			apontamento.funcionario = "Joao";
			apontamento.qtde = 12;
			apontamento.hraTrab = 8;
			Listadeapontamentos.Add (apontamento);

			Apontamento apontamento2 = new Apontamento ();
			apontamento2.id = 2;
			apontamento2.funcionario = "Pedro";
			apontamento2.qtde = 18;
			apontamento2.hraTrab = 8;
			Listadeapontamentos.Add (apontamento2);

			Apontamento apontamento3 = new Apontamento ();
			apontamento3.id = 3;
			apontamento3.funcionario="Maria";
			apontamento3.qtde = 20;
			apontamento3.hraTrab = 8;
			Listadeapontamentos.Add (apontamento3);

			return Listadeapontamentos;
		}
		public Apontamento listaapontamentoPorId(int id){
		
			if (Listadeapontamentos == null)
				listaapontamento ();

			foreach (var item in Listadeapontamentos) {
				if (item.id==id) {
					return item;
				}
			}
			return null;
		
		
		
		}


		public void insere(Apontamento Apt)
		{

			Listadeapontamentos.Add (Apt);

		}

		public bool insereNoBanco (Apontamento AptBanco){


			return  clsAcessoBanco.inserir ("F05Apontamentos", AptBanco.ToString(parametroValor.paramentro), AptBanco.ToString(parametroValor.valor));

		
		}
		public  string ToString (parametroValor p)
		{
			switch (p) {
			case parametroValor.paramentro:
				return "id, funcionario, qtde, hraTrab";
			case parametroValor.valor:
				return id + "," + funcionario + "," + qtde + "," + hraTrab;		
			default: return string.Empty;
			}
		}



	}
	public enum parametroValor {
		paramentro,valor
	}

}

