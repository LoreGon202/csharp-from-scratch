using System;

namespace FinalProject.Challenges
{
    public class Challenge6
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabla del {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}