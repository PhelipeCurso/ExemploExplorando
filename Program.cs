using ExemploExplorando.models;
using System.Globalization;
using Models;
using Newtonsoft.Json;

DateTime dataAtual= DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "ssd", 120.00M, dataAtual);
Venda v2 = new Venda(2, "memoria", 100.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado= JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);





// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ?"par" : "ímpar")); 

// if(numero %2 ==0)
// {
//     Console.WriteLine($"O númeor {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }








// Pessoa p1 = new Pessoa("Phelipe","Araujo");

// (string nome,string sobrenome)= p1;











// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas)= arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//      Console.WriteLine(linha);  
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possíbel ler o aqruivo");
// }








// (int, string, string, decimal) tupla =(1,"Phelipe", "Araujo", 1.72M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");















// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }





// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine ($"Removendo o elemento:  {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }










//new ExemploExcecao().Metodo1();






// try
// {

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura..txt");

// foreach(string linha in linhas )
// {
// Console.WriteLine(linha);
// }

// } 
// catch(FileNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. caminho não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//   Console.WriteLine($"Ocorreu uma exceção generia. {ex.Message}");
// }

// finally
// {
//   Console.WriteLine("Finalizou tudo");
// }



//DateTime data =DateTime.Parse("12/03/1991");

//Console.WriteLine(data);






















//Pessoa p1 = new Pessoa("Phelipe", "Araujo");
//Pessoa p2 = new Pessoa("Isabela","Araujo");

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome ="Ingles";
//cursoDeIngles.Alunos =new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();



//Pessoa p1 = new Pessoa();

//p1.Nome = "Phelipe";
//p1.SobreNome ="Araujo";
//p1.Idade = 32;
//p1.Apresentar();