namespace _05heranca
{
	class Pessoa
	{
		//atributos
		protected string? Nome;
		protected int Idade;
		
		//Metodo para apresentar os dados
		protected void ApresentarPessoa()
		{
			Console.WriteLine($"Nome : {Nome}");
			Console.WriteLine($"Idade : {Idade}");
		}
	}
}