// Factorial de un numero usando Funciones
using System;

class FactorialV2
{
    static void subrayarMensaje(string pMensaje)
    {
        for (int i = 0; i <pMensaje.Length; i++)
        {
            Console.Write("-");
        }
    }

    static int calcularFactorial(int pNumero)
    {
        int factorial = 1;
        for (int i = 1; i<=pNumero; i++)
        {
            factorial = factorial * i;
        }  
        return factorial;
    }

    static void Main()
    {
        //declaracion de variables
        string mensaje = "Programa que calcula el Factorial de un Numero";
        int numero = 0, factorial = 1;

        //pantalla
        Console.Clear();
        Console.WriteLine(mensaje);
        subrayarMensaje(mensaje);

        //entrada de datos
        Console.Write("\nIntroduzca el numero para calcular el factorial: ");
        numero = int.Parse(Console.ReadLine());

        //proceso 
        factorial = calcularFactorial(numero);
        
        //salida por pantalla

        Console.WriteLine("El factorial del {0} es {1}.",numero, factorial);
    }
}