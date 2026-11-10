using System.ComponentModel.Design;
using System.Net.Http.Headers;

Console.WriteLine("Calculando a media escolar");

float nota1, nota2, nota3, nota4, media;


Console.Write("Digite a primeira nota: ");
nota1 = float.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
nota2 = float.Parse(Console.ReadLine());
Console.Write("Digite a terceira nota: ");
nota3 = float.Parse(Console.ReadLine());
Console.Write("Digite a quarta nota: ");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Sua média foi de: {media}");

if (media >= 7)
{
    Console.WriteLine("APROVADO");
}
else if (media >= 5.1 && media <= 6.9 )
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}

