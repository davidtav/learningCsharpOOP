namespace _05heranca
{
	class Colaborador:Pessoa
	{
		//Atributos
		private string? _cargo;
		private double _salario;
		
		//construtor
		public Colaborador(string nome, int idade, string cargo, double salario)
		{
			Nome = nome; //herdado de Pessoa
			Idade = idade; //herdado de Pessoa
			_cargo = cargo;
			_salario = salario;
			
			ApresentarPessoa(); //herdado de Pessoa
			ApresentarColaborador();
		}
		
		//Metodo
		protected void ApresentarColaborador()
		{
			Console.WriteLine($"Cargo : {_cargo}");
			Console.WriteLine($"Salario : R${_salario}");
		}
	}
}