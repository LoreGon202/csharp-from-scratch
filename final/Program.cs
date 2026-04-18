
using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona un challenge (6-13): ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 6: new Challenge6().Run(); break;
                case 7: new Challenge7().Run(); break;
                case 8: new Challenge8().Run(); break;
                case 9: new Challenge9().Run(); break;
                case 10: new Challenge10().Run(); break;
                case 11: new Challenge11().Run(); break;
                case 12: new Challenge12().Run(); break;
                case 13: new Challenge13().Run(); break;
                default: Console.WriteLine("Opción no válida"); break;
            }
        }
    }
}