Console.WriteLine("Operações Aritméticas");

int num1 = 0;
int num2 = 0;

Console.Write("Digite um nùmero inteiro: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Digite um nùmero inteiro: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Adição {num1 + num2}");
Console.WriteLine($"Subtração {num1 - num2}");
Console.WriteLine($"Multiplicação {num1 * num2}");
Console.WriteLine($"Divisão {num1 % num2}");


