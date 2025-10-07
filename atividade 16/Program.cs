int n;
int resultado = 0;

Console.WriteLine("digite um numero e vamos dizer o fatoral dele.");
n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    resultado = (n - 1) * n;
}
Console.WriteLine (resultado);