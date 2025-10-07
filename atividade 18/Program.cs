double num = 1;
double media = 1;

for (double i = 0; i < media; i++)
{
    if (num != 0)
    {
        Console.WriteLine("digite um numero.");
        num = double.Parse(Console.ReadLine());

        if (num != 0)
        {
            media = num / 2;
            Console.WriteLine(media);
        }
    }

}