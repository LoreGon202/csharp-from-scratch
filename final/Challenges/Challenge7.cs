using System;

namespace final
{
    public class Challenge7
    {
        public void Run()
        {
            int a, b, c;

            Console.Write("Número 1: ");
            while (!int.TryParse(Console.ReadLine(), out a)) {}

            Console.Write("Número 2: ");
            while (!int.TryParse(Console.ReadLine(), out b)) {}

            Console.Write("Número 3: ");
            while (!int.TryParse(Console.ReadLine(), out c)) {}

            double promedio = (a + b + c) / 3.0;
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}