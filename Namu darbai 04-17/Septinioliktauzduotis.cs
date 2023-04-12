namespace Septinioliktauzduotis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite teigiama skaiciu: ");
        int skaicius = Convert.ToInt32(Console.ReadLine());

        while (skaicius > 0)
        {
            Console.WriteLine(skaicius);
            skaicius--;
        }

    }
}

