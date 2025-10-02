using System.Runtime.CompilerServices;

int num1;
int num2;
int num3;
int maior;
int meio;
int menor;

Console.WriteLine("digite o primeiro numero.");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero.");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("digite o terceiro numero.");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3 && num2 < num3)
{
    Console.WriteLine($"os numeros sao {num3} {num2} {num1}.");
}

if (num1 > num2 && num1 > num3 && num2 < num3)
{
    Console.WriteLine($"os numeros sao {num2} {num3} {num1}.");
}

if (num3 > num1 && num3 > num1 && num2 < num1)
{
    Console.WriteLine($"os numeros sao {num3} {num1}{num2}");
}

if (num2 > num1 && num2 > num3 && num3 < num1)
{
    Console.WriteLine($"os numeros sao {num1} {num3} {num2}.");
}

if (num3 > num1 && num3 > num2 && num1 < num2)
{
    Console.WriteLine($"os numeros sao {num1} {num2}{num3}");
}