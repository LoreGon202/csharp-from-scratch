using System;

namespace final
{
    public class Challenge11
    {
        public void Run()
        {
            int n;
            Console.Write("Número: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ingrese un número válido: ");
            }

            Console.WriteLine(n % 2 == 0 ? "Par" : "Impar");
        }
    }
}