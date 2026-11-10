using System.ComponentModel.Design;

Console.WriteLine("Par ou ìmpar");

int x = 0;

Console.Write("Digite um nùmero inteiro: ");
x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine("O número é PAR:");
}
else { 
 
    Console.WriteLine("O número é IMPAR:");
}

Console.ReadKey();





