using System;

namespace final
{
    public class Challenge12
    {
        public void Run()
        {
            int n;
            Console.Write("Cantidad de números: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Ingrese un número válido: ");
            }

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                int num;
                Console.Write("Número: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.Write("Ingrese un número válido: ");
                }
                suma += num;
            }

            Console.WriteLine($"Suma: {suma}");
        }
    }
}