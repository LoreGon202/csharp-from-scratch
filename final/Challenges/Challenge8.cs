using System;

namespace final
{
    public class Challenge8
    {
        public void Run()
        {
            Console.Write("Texto: ");
            string texto = Console.ReadLine() ?? "";

            int count = 0;
            foreach (char c in texto.ToLower())
            {
                if ("aeiou".Contains(c)) count++;
            }

            Console.WriteLine($"Vocales: {count}");
        }
    }
}