// Factorial de un numero
using System;

class Factorial 
{
    static void Main()
    {
        //Declaracion de variables
        string mensaje = " Programa que calcula el Factorial de un numero";
        int numero = 0, factorial = 1;

        //pantalla
        Console.Clear();
        Console.WriteLine(mensaje);

        //entrada de Datos
        Console.Write ("Introduzca numero para calcular el factorial.: ");
        numero = int.Parse(Console.ReadLine());

        //proceso
        for(int i=1; i<= numero; i++)
        {
            factorial = factorial * i;
            Console.WriteLine("Factorial: {0}", factorial);

        }

        //salida
        Console.WriteLine("EL factorial del numero {0} es.: {1}",numero,factorial );
        Console.ReadLine();
    }

}
