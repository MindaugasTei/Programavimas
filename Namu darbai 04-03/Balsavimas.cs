Console.Write("Iveskite savo amziu: ");
int amzius = int.Parse(Console.ReadLine());

if (amzius >= 18)
{
    Console.WriteLine("Galite balsuoti!");
}
else
{
    Console.WriteLine("Negalite balsuoti.");
}