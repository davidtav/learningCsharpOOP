namespace _02encapsulamento
{

	class Aluno
	{
		//1ª maneira
		/*private string? _nome;
				
		public string? Nome
		{
			get{return _nome;}
			set{_nome = value;}
		}
		*/
		
		//2ª maneira
		public string? Nome { get; set;}
		public double Ano{get; set;}
	}
}