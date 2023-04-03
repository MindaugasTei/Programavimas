using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Iveskite temperatura:");

        int temperatura;
        if (int.TryParse(Console.ReadLine(), out temperatura))
        {
            if (temperatura <= 0)
            {
                Console.WriteLine("Ziauria salta!");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("Labai salta.");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("Salta.");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("Normali temperatura.");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("Karsta!");
            }
            else if (temperatura < 50)
            {
                Console.WriteLine("Ziauriai karsta!");


            }



        }

    }

    }