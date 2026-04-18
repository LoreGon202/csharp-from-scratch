using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa tu fecha de nacimiento (dd/mm/yyyy): ");
        DateTime fechaNacimiento;

        while (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
        {
            Console.Write("Formato incorrecto. Intenta de nuevo (dd/mm/yyyy): ");
        }

        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        if (DateTime.Now < fechaNacimiento.AddYears(edad))
        {
            edad--;
        }

        Console.WriteLine($"\nHola {nombre}, tienes {edad} años.");
        Console.WriteLine("¡Gracias por usar el programa!");
        Console.WriteLine("Hasta luego 👋");
    }
}