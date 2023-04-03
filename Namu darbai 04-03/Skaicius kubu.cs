namespace skaiciuskubu;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Iveskite skaiciu: ");
        double skaicius = double.Parse(Console.ReadLine());
        double rezultatas = Math.Pow(skaicius, 3);
        Console.WriteLine($"{skaicius} Pakelta kubu yra: {rezultatas}");

    }

}