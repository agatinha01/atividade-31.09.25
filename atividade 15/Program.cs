int n;
int num = 0;
int valor = 0;

Console.WriteLine("digite qualquer numero.");
n = int.Parse(Console.ReadLine());

for (int i = 1000; i < 2000; i++)
{
    num++;
    valor = num / 11;
}
Console.WriteLine(valor);