// EX 1 -
// Console.Write("Digite o nome de um produto: ");
// string? produto = Console.ReadLine();

// Console.Write("Digite a quantidade necessária em unidades: ");
// int? quantidade = int.Parse(Console.ReadLine()!);

// Console.Write("Digite preço unitário deste produto: ");
// decimal? valor = decimal.Parse(Console.ReadLine()!);

// decimal? total = valor * quantidade;

// Console.WriteLine($"Produto: {produto}. Quantidade: {quantidade}. Preço: {valor} e preço total: {total}");

// EX 2 -

// Console.Write("Digite o nome de um aluno: ");
// string? nome = Console.ReadLine();

// Console.Write("Digite uma nota de 0 a 10: ");
// int? nota = int.Parse(Console.ReadLine()!);

// if(nota >= 7 && nota <= 10)
// {
//     Console.WriteLine("Aluno Aprovado!");
// } 
// else if (nota >= 5 && nota < 7)
// {
//     Console.WriteLine("Aluno de Recuperação!");
// }
// else if (nota < 0 && nota < 5)
// {
//     Console.WriteLine("Aluno de Reprovado!");
// } 
// else
// {
//      Console.WriteLine("Nota inserida é inválida!");
// };

// EX 3 -

// EX 4

Console.WriteLine("Digite um número:");
int? a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite outro número:");
int? b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Escolha 1 para somar e 2 para multiplicar:");
int? calculo = int.Parse(Console.ReadLine()!);

if (calculo == 1)
{
    int resultado = Somar(a, b);
    Console.WriteLine(resultado);
}
else
{
    int resultado = Multiplicar(a, b);
    Console.WriteLine(resultado);
}


static int Somar(int a, int b)
{
    return a + b;
}

static int  Multiplicar(int a, int b)
{
    return a * b;
}

