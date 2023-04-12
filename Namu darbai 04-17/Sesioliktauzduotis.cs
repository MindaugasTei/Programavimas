namespace Sesioliktauzduotis;
class Program
{
    static void Main(string[] args)
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine("Visu skaiciu suma: " + suma);
    }
}

