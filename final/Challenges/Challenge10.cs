using System;

namespace final
{
    public class Challenge10
    {
        public void Run()
        {
            int n;
            Console.Write("Número: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ingrese un número válido: ");
            }

            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;

            Console.WriteLine($"Factorial: {fact}");
        }
    }
}