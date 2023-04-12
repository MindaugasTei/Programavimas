namespace Astuonioliktauzduotis;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Iveskite kiek kepalu gali iskepti vienas darbuotojas per valanda:");
        int kepaluPerValanda = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Iveskite kiek darbuotoju turi kepykla:");
        int darbuotojuSkaicius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Iveskite vieno kepalo savikaina:");
        double savikaina = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Iveskite vieno kepalo pardavimo kaina:");
        double pardavimoKaina = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Iveskite kiek kepalu kepykla turi iskepti siandien:");
        int uzsakymuSkaicius = Convert.ToInt32(Console.ReadLine());

    
        int kepaluPerDiena = kepaluPerValanda * darbuotojuSkaicius * 8;

        Console.WriteLine("Kepiama kepalu per diena: " + kepaluPerDiena);

        
        if (uzsakymuSkaicius <= kepaluPerDiena)
        {
            Console.WriteLine("Visi uzsakymai bus iskepti.");
        }
        else
        {
            int likusiuKepaluSkaicius = uzsakymuSkaicius - kepaluPerDiena;
            Console.WriteLine("Nepavyks iskepti visu uzsakymu. Likusiu kepalu skaicius: " + likusiuKepaluSkaicius);
        }

     
        double pajamos = pardavimoKaina * uzsakymuSkaicius;
        double savikainos = savikaina * uzsakymuSkaicius;
        double pelnas = pajamos - savikainos;

        Console.WriteLine("Uzdirbtas pelnas: " + pelnas);

    }
}

