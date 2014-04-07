using System;
using System.Collections.Generic;
using System.Text;

namespace libBrisaPCL
{
	public class Funcionario
	{

		public int Id { get; set;}
		public string nome { get ; set;}


		public List<Funcionario> ListarFuncionario (){

			List<Funcionario> funcionarios = new List<Funcionario> ();
			Funcionario funcionario = new Funcionario ();

			funcionario.Id = 1;
			funcionario.nome = "Maria";
			funcionarios.Add (funcionario);

			funcionario = new Funcionario();
			funcionario.Id = 2;
			funcionario.nome = "Ana Clara";
			funcionarios.Add (funcionario);

			funcionario = new Funcionario();
			funcionario.Id = 3;
			funcionario.nome = "Jhonathan";
			funcionarios.Add (funcionario);

			return funcionarios;
		}

		public static Funcionario ListarFuncionarioPorId(int _id)
		{
			List<Funcionario> funcionarios = new List<Funcionario> ();
			Funcionario funcionario = new Funcionario ();

			funcionario.Id = 1;
			funcionario.nome = "Maria";
			funcionarios.Add (funcionario);

			funcionario = new Funcionario();
			funcionario.Id = 2;
			funcionario.nome = "Ana Clara";
			funcionarios.Add (funcionario);

			funcionario = new Funcionario();
			funcionario.Id = 3;
			funcionario.nome = "Jhonathan";
			funcionarios.Add (funcionario);

			foreach (Funcionario item in funcionarios ){
				if (item.Id ==_id) {
					return item;
				}
			}

			return null;
		}
	}
}

