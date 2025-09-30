int idade, ano;

Console.WriteLine("Em que ano você nasceu?");
idade = int.Parse(Console.ReadLine());
ano = (2025 - idade) * 365;
Console.WriteLine($"Você tem {ano} dias de vida");