using System;

Console.Write("Número: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n > 0 ? "Positivo" : n < 0 ? "Negativo" : "Cero");
