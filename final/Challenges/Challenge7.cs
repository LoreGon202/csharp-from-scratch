using System;

namespace final
{
    public class Challenge7
    {
        public void Run()
        {
            Console.Write("Ingrese 3 números:\n");

            Console.Write("Número 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            int c = int.Parse(Console.ReadLine());

            double promedio = (a + b + c) / 3.0;

            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}