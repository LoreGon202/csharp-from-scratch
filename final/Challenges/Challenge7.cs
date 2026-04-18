Console.Write("Ingrese 3 números:\n");

int a, b, c;

Console.Write("Número 1: ");
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.Write("Ingrese un número válido: ");
}

Console.Write("Número 2: ");
while (!int.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Ingrese un número válido: ");
}

Console.Write("Número 3: ");
while (!int.TryParse(Console.ReadLine(), out c))
{
    Console.Write("Ingrese un número válido: ");
}