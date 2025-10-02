int atual, nascimento;
Console.WriteLine("qual seu ano de nascimento?");
nascimento = int.Parse(Console.ReadLine());

Console.WriteLine("qual seu ano atual?");
atual = int.Parse(Console.ReadLine());

if (nascimento > 2007)
{
    Console.WriteLine("voce nao precisa votar ainda.");
}
else
{
  Console.WriteLine("voce precisa votar.");
}