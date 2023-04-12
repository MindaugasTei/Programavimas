namespace Septinioliktauzduotisdu;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite neigiama skaičiu: ");
        int skaicius = Convert.ToInt32(Console.ReadLine());

        while (skaicius <= 0)
        {
            Console.Write(skaicius + " ");
            skaicius++;
        }

        Console.WriteLine("0");
    }
}

