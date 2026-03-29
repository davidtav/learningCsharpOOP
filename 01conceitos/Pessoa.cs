using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01conceitos
{
    public class Pessoa
    {
        //atributos
		public string? Nome; // uso de ? para flexibilizar a falta de declação do atributo Nome
		
		public int Idade;
		
		
		//metodos
		public void Apresentacao()
		{
			Console.WriteLine($"Olá meu nome é {Nome}");
		}
		
		public string VerificarIdade()
		{
			return Idade >= 18 ? "Maior de idade":"Menor de idade";
		}
    }
}