using System;

namespace final
{
    public class Challenge9
    {
        public void Run()
        {
            int a, b;

            Console.Write("Número 1: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Ingrese un número válido: ");
            }

            Console.Write("Número 2: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Ingrese un número válido: ");
            }

            Console.WriteLine($"Mayor: {Math.Max(a, b)}");
        }
    }
}