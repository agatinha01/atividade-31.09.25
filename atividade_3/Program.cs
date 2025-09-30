using System;

int Base;
int Altura;

Console.WriteLine("Digite a base do seu retangulo.");

Base = int.Parse(Console.ReadLine());

Console.WriteLine("Diga a altura do seu retângulo.");
Altura = int.Parse(Console.ReadLine());

int area = Base * Altura;

Console.WriteLine($"A área do seu retângulo é {area}");