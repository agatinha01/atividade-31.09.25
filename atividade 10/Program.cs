double nota1;
double nota2;

Console.WriteLine("digite a sua primeira nota.");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("digite a sua segunda nota.");
nota2 = double.Parse(Console.ReadLine());

if (nota1+nota2 > 6)
{
    Console.WriteLine("voce foi aprovado.");
}
else
{
    Console.WriteLine("voce foi reprovado.");
}