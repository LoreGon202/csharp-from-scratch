using System;

namespace final
{
    public class Challenge13
    {
        public void Run()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            int año;
            Console.Write("Año de nacimiento: ");
            while (!int.TryParse(Console.ReadLine(), out año))
            {
                Console.Write("Ingrese un año válido: ");
            }

            int edad = DateTime.Now.Year - año;

            Console.WriteLine($"Hola {nombre}, tienes {edad} años");
            Console.WriteLine("Hasta luego 👋");
        }
    }
}
