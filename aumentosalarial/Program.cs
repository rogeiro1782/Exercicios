Console.WriteLine("Aumento Salarial");

float salario, aumento, novosalario;

Console.Write("Digite seu salario: ");
salario = float.Parse(Console.ReadLine());

if (salario <= 2000)
{
    aumento = (salario * 15) / 100;
}
else if (salario >= 2001 && salario <= 4000)
{
    aumento = (salario * 10) / 100;
}
else
{
    aumento = (salario * 5) / 100;
}

novosalario = salario + aumento;

Console.WriteLine("Novo Salario: " + novosalario);