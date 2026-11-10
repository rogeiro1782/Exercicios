Console.WriteLine("Classificando Idades");

int idade;
Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine("Você é criança");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Você é Adolescente");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Você é Adulta");
}
else
{
    Console.WriteLine("Você é Idoso");
}
