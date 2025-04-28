string nomePrimeiroItem = "Câmara de ar";
string nomeSegundoItem = "Capacete";
string nomeTerceiroItem = "Kit de ferramentas";

decimal precoPrimeiroItem = 29.90m;
decimal precoSegundoItem = 134.90m;
decimal precoTerceiroItem = 189.90m;

decimal percentualImpostoVenda = 0.088m; //8,8%

int qtdItem1, qtdItem2, qtdItem3;

decimal subtotalItem1, subtotalItem2, subtotalItem3;
decimal totalCliente1, valorImposto, totalImposto;

const int tamanhoLinha = 36;
const char separador = '=';

Console.Clear();

Console.WriteLine($"{"+".PadRight(tamanhoLinha, separador)}+");
Console.WriteLine($"{"|".PadRight(10)}Oficina Bike Pro{"|".PadLeft(11)}");
Console.WriteLine($"{"+".PadRight(tamanhoLinha, separador)}+");
Console.WriteLine($"{"|".PadRight(14)}CATÁLOGO{"|".PadLeft(15)}");
Console.WriteLine($"{"+".PadRight(tamanhoLinha, separador)}+");

Console.WriteLine($"{"| ITEM",-24}{"VALOR",-12}|");
Console.WriteLine($"{"+".PadRight(tamanhoLinha, separador)}+");

Console.WriteLine($"| 1. {nomePrimeiroItem,-20}{precoPrimeiroItem,-11:C2}|");
Console.WriteLine($"| 2. {nomeSegundoItem,-20}{precoSegundoItem,-11:C2}|");
Console.WriteLine($"| 3. {nomeTerceiroItem,-20}{precoTerceiroItem,-11:C2}|");

Console.WriteLine($"{"+".PadRight(tamanhoLinha, separador)}+");
Console.WriteLine($"{"| Imposto sobre a venda: 8,8%",-tamanhoLinha}|");
Console.WriteLine($"{"+".PadRight(tamanhoLinha, separador)}+");

Console.Write($"\n\nInforme a quantidade de {nomePrimeiroItem}: ");
qtdItem1 = Convert.ToInt32(Console.ReadLine());

bool primeiroNumeroNegativo = qtdItem1 < 0;

if (primeiroNumeroNegativo)
{
    Console.WriteLine("Quantidade inválida!");
    return;
}

//if (primeiroNumeroNegativo)
//{
//    Console.WriteLine("Quantidade informada é negativa. Será considerada como 0");
//    qtdItem1 = 0;
//}

Console.Write($"\n\nInforme a quantidade de {nomeSegundoItem}: ");
qtdItem2 = Convert.ToInt32(Console.ReadLine());

if (qtdItem2 < 0)
{
    Console.WriteLine("Quantidade inválida!");
    return;
}

Console.Write($"\n\nInforme a quantidade de {nomeTerceiroItem}: ");
qtdItem3 = Convert.ToInt32(Console.ReadLine());

if (qtdItem3 < 0)
{
    Console.WriteLine("Quantidade inválida!");
    return;
}

subtotalItem1 = qtdItem1 * precoPrimeiroItem;
subtotalItem2 = qtdItem2 * precoSegundoItem;
subtotalItem3 = qtdItem3 * precoTerceiroItem;

totalCliente1 = subtotalItem1 + subtotalItem2 + subtotalItem3;
valorImposto = totalCliente1 * percentualImpostoVenda;

totalImposto = totalCliente1 + valorImposto;

Console.WriteLine("\n");
Console.WriteLine($"1. {qtdItem1}x {nomePrimeiroItem} --> {subtotalItem1:C2}");
Console.WriteLine($"2. {qtdItem2}x {nomeSegundoItem} --> {subtotalItem2:C2}");
Console.WriteLine($"3. {qtdItem3}x {nomeTerceiroItem} --> {subtotalItem3:C2}");

Console.WriteLine($"\nImposto (8,8%): {valorImposto:C2}");
Console.WriteLine($"\nTotal: {totalImposto:C2}");