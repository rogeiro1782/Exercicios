Console.WriteLine("Calculando IMC");

float altura, peso;

Console.Write("Digite seu peso (em Kg); ");
peso = float.Parse(Console.ReadLine());
Console.Write("Digite sua altura (em Cm); ");
altura = float.Parse(Console.ReadLine());

float imc = peso / ((altura/100) * (altura/100));

Console.WriteLine("Seu imc é: " + imc);

if (imc < 18.5)
{
    Console.WriteLine("BAIXO PESO");
}
else if (imc < 25)
{
    Console.WriteLine("PESO NORMAL");
}
else if (imc < 30)
{
    Console.WriteLine("SOBREPESO");
}
else if (imc < 35)
{
    Console.WriteLine("OBESIDADE GRAU 1");
}
else if (imc < 40)
{
    Console.WriteLine("OBESIDADE GRAU 2");
}
else
{
    Console.WriteLine("OBESIDADE GRAVE");
}

    
