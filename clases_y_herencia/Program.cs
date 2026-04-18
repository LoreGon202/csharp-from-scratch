using System;

class Animal 
{ 
    public void Hablar() => Console.WriteLine("Sonido"); 
}

class Perro : Animal 
{ 
    public void Ladrar() => Console.WriteLine("Guau"); 
}

class Program
{
    static void Main()
    {
        var p = new Perro();
        p.Hablar();
        p.Ladrar();
    }
}
