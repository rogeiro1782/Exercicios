using System.IO.Pipes;

Console.WriteLine("Ano Bissexto");

int ano;

Console.Write("Informe o ano: ");
ano = int.Parse(Console.ReadLine());

if((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.Write("É ANO BISSEXTO");
}
else
{
    Console.Write("Não é ANO BISSEXTO");
}


