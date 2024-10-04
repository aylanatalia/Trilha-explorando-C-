using System.Globalization;
using System.Reflection;
using trilha_explorando_C_.Models;

// instanciando um novo objeto
 Pessoa p1 = new Pessoa();
 p1.Nome = "Ayla Natalia";
 p1.Sobrenome = "Martins Ferreira";
 p1.Idade = 27;
 //p1.Apresentar();

 Pessoa p2 = new Pessoa();
 p2.Nome = "Eduardo";
 p2.Sobrenome= "Neves";
 p2.Idade =  22;

 //instanciando um novo objeto usando construtores 
 Pessoa p3 = new Pessoa(nome: "Renato", sobrenome: "Silva");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
// instanciar a lista para ela não ficar nula
cursoDeIngles.Alunos = new List<Pessoa>();

// adicionando aluno

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();


//formatando valor monetário

decimal valorMonetario = 82.40M;
//Console.WriteLine($"{valorMonetario:C}");

//altera a cultura do código
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

//porcentagem

double porcentagem = .3412;
Console.WriteLine(porcentagem.ToString("P"));

//datatime
// .Now é um propriedade do tipo get que pega a data do sistema
DateTime data = DateTime.Now;
Console.WriteLine(data);
//deve ser respeitado o maiusculo e minusculo
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

//data curta
Console.WriteLine(data.ToShortDateString());


//ler arquivo 
string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}