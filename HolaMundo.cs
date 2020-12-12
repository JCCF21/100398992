//HolaMundo.cs

using System;

class HolaMundo
{
    static void Main()
    {
        String matricula, nombre;

        Console.Write("\nMatricula: ");
        matricula = Console.ReadLine();

        Console.Write("Nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("\n*** Salida por consola ***\n");
        Console.WriteLine("Su nombre es: \t\t" + nombre);
        Console.WriteLine("Su matricula es: \t" + matricula);
    }
}