using System;

int valor;
int valor2;

Console.WriteLine("digite o primeiro numero.");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero.");
valor2 = int.Parse(Console.ReadLine());

if (valor > valor2)
{
    Console.WriteLine($"{valor} e maior que {valor2}");
}
else
{
    Console.WriteLine($"{valor2} e maior que {valor}");
}