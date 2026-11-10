Console.WriteLine("Comparando Números");

int x = 0;
int y = 0;

Console.Write("Digite o primeiro número inteiro: ");
x = int.Parse(Console.ReadLine());
Console.Write("Digite outro número inteiro: ");
y = int.Parse(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("O primeiro Número é maior!");
}
else if (y > x)
{
    Console.WriteLine("O segundo número é maior!");
}
else
{
    Console.WriteLine("Os dois são iguais!");
}
