int num;
int resultado;

Console.WriteLine("Digite um número.");

num = int.Parse(Console.ReadLine());

resultado = num - 1;

Console.WriteLine($"O antessesor de {num} é {resultado}");