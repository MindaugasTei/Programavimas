namespace Keturioliktauzduotis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pasirinkite viena is galimybiu:");
Console.WriteLine("1 - stacionarus kompiuteris");
Console.WriteLine("2 - nešiojamas kompiuteris");
Console.WriteLine("3 - plansete");

int pasirinkimas = int.Parse(Console.ReadLine());

switch (pasirinkimas)
{
    case 1:
        Console.WriteLine("Stacionariuoju kompiuteriu galite naudotis tik namuose arba darbo vietoje");
        break;
    case 2:
        Console.WriteLine("Nesiojamuoju kompiuteriu galite naudotis visur");
        break;
    case 3:
        Console.WriteLine("Plansete galite naudotis visur");
        break;
    default:
        Console.WriteLine("Tokio pasirinkimo nera");
        break;
}

    }
}

