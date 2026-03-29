using _01conceitos;

//Exemplo 01
Pessoa obj1 = new Pessoa();

obj1.Nome = "David";
//obj1.Apresentacao();

//Exemplo 02
Pessoa obj2 = new();
obj2.Nome = "Amanda";
//obj2.Apresentacao();


//Exemplo 03
Pessoa obj3 = new()
{
	Nome = "Aline",
	Idade = 19
};

string retorno = obj3.VerificarIdade();
obj3.Apresentacao();
Console.WriteLine(retorno);