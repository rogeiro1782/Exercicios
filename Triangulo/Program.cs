Console.WriteLine("Tipo de Triangulo");

float l1, l2, l3;

Console.Write("Digite a medida do primeiro lado: ");
l1 = float.Parse(Console.ReadLine());
Console.Write("Digite a medida do segundo lado: ");
l2 = float.Parse(Console.ReadLine());
Console.Write("digite a medida terceiro lado: ");
l3 = float.Parse(Console.ReadLine());


if (l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1)
{
    if (l1 == l2 && l2 == l3)
    {
        Console.WriteLine("Triangulo Equilátero!");
    }
    else if (l1 == l2 || l2 == l3 || l1 == l3)
    {
        Console.WriteLine("Triangulo Isóceles!");
    }
    else
    {
        Console.WriteLine("Triangulo Escaleno!");
    }
}
else
    Console.Write("Não Forma TRIANGULO");


    
