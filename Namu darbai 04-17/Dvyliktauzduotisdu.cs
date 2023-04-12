namespace Dvyliktauzduotisdu;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Iveskite egzamino rezultata:");
        int rezultatas = int.Parse(Console.ReadLine());

        if (rezultatas >= 8 && rezultatas <= 10)
        {
            Console.WriteLine("Rezultatas yra tarp 8-10.");
        }
        else if (rezultatas >= 5 && rezultatas < 8)
        {
            Console.WriteLine("Rezultatas yra tarp 5-8.");
        }
        else if (rezultatas < 5)
        {
            Console.WriteLine("Rezultatas yra mazesnis nei 5.");
        }
        
        }
    }
        
    


