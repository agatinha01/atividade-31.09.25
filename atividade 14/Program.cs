int n;
int num = 0;
int valor = 0;

Console.WriteLine("digite um valor.");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    num++;
    valor = num;
    Console.WriteLine(valor);
}