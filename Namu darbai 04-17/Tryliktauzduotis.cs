namespace Tryliktauzduotis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite gyvuno rusi: ");
        string gyvunas = Console.ReadLine();

        switch (gyvunas)
        {
            case "suo":
                Console.WriteLine("Ivestas gyvunas yra Suo.");
                break;
            case "kate":
                Console.WriteLine("Ivestas gyvunas yra kate.");
                break;
            case "ziurkenas":
                Console.WriteLine("Ivestas gyvunas yra ziurkenas.");
                break;
           
        }
    }
}

