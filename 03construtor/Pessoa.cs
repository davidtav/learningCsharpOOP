
namespace _03construtor
{
    public class Pessoa
    {
        //1º construtor
		public Pessoa()
		{
			Console.WriteLine("Olá Mundo !");
		}
		
		//2º construtor
		public Pessoa(string nome)
		{
			Console.WriteLine($"Olá {nome}!");
		}
		
		//3º construtor
		public Pessoa(string nome, int idade)
		{
			Console.WriteLine($"Olá {nome} esse ano voce fara {idade} anos de idade!");
		}
    }
}