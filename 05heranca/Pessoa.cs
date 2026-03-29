namespace _05heranca
{
	class Pessoa
	{
		//atributos (mudança de protected para private)
		private string? _nome; 
		private int _idade;
		
		//atribuição de construtor
		public Pessoa(string nome, int idade)
		{
			_nome = nome;
			_idade = idade;
		}
		
		//Metodo para apresentar os dados
		protected void ApresentarPessoa()
		{
			Console.WriteLine($"Nome : {_nome}");
			Console.WriteLine($"Idade : {_idade}");
		}
	}
}