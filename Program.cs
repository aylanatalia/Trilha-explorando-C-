using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using trilha_explorando_C_.Models;

// instanciando um novo objeto
Pessoa p1 = new Pessoa();
p1.Nome = "Ayla Natalia";
p1.Sobrenome = "Martins Ferreira";
p1.Idade = 27;
//p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves";
p2.Idade = 22;

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
try
{
    string[] linhas = File.ReadAllLines("Arquivos/Arquivo-Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
//mensagem de erro específica
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
} 
//mensagem de erro genérico
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}finally
{
    Console.WriteLine("Chegou até aqui");
}

//usando o throw
new ExemploExcessao().Metodo1();

Console.WriteLine("Fila:");
//criando filas
Queue<int> fila = new Queue<int>();
//adiciona o elemento no final da fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

//percorrendo a fila
foreach(int item in fila)
{
    Console.WriteLine(item);
}


//remover o primeiro elemento da lista, não da para apagar elementos do meio e do final 
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("Pilha:");
//criando pilhas
Stack<int> pilha = new Stack<int>();

//adicionando elementos no topo da pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

//removendo elemento do topo da lista
Console.WriteLine($"Removendo elemento do topo da pilha: {pilha.Pop()}");
pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// enquanto na fila o primeiro a entrar é o primeiro a sair, na pilha o último a entrar é o primeiro a sair


//dictionary <chave, dado>
Console.WriteLine("Dictionary:");
Dictionary<string, string> estados = new Dictionary<string, string>();

//adicionando elementos
estados.Add("SP", "São Paulo");
estados.Add("BA", "Baiha");
estados.Add("MG", "Minas Gerais");

foreach(KeyValuePair<string, string> item in estados) // pode ser usado o var no lugar do KeyValuePair
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//removendo
Console.WriteLine("Removendo o elemento:");
estados.Remove("BA");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//alterando valor
Console.WriteLine("Alterando valor:");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//verificando se o elmento existe
string chave = "BA";
Console.WriteLine($"Verificando chave: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine("Valor existente");
} else
{
    Console.WriteLine("Valor ainda não adicionado");
}

Console.WriteLine(estados["MG"]);


//declarando uma tupla, sendo a primeira sendo a mais recomendada por questão de legibilidade
(int id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Ayla", "Natalia", 1.88M);
//ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Jocimari", "Lourdes", 1.70M);
//var outroExemploTuplaCriado = Tuple.Create(3, "Felipe", "Augusto", 1.84M);

Console.WriteLine("Tupla:");
Console.WriteLine($"id: {tupla.id}");
Console.WriteLine($"nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

//retornando tuplas atraves de métodos
// este underline informa que a informação trazida não sera usada e sim descartada
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

if(sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

//chamando construtor
Pessoa p10 = new Pessoa("Ayla", "Natalia");

//chamando desconstrutor
(string nome, string sobrenome) = p10;
Console.WriteLine($"{nome} {sobrenome}");


//chamando um metodo da maneira convencional
int numeroVerificado = 20;
if(numeroVerificado % 2 == 0)
{
    Console.WriteLine($"O número {numeroVerificado} é par");
}
else
{
    Console.WriteLine($"O número {numeroVerificado} é impar");
}

// chamdno método da maneira ternaria
int numeroChecado = 15;
bool ehPar = true;

ehPar = numeroChecado % 2 == 0;
Console.WriteLine($"O numero {numeroChecado}  é " + (ehPar ? "par" : "impar"));