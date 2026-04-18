using System;

namespace final
{
    public class Challenge6
    {
        public void Run()
        {
            int n;
            Console.Write("Número: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ingrese un número válido: ");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}