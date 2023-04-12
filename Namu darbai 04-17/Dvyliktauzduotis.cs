namespace Dvyliktauzduotis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite 3 skaicius:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int maxNum = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine("Didziausias skaicius yra: " + maxNum);
    }
}

