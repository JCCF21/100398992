//Laboratorio 2 primera parte
using System;
 


class Lab2A
{
    static void Main()
    {
        //declaracion de variables a usar
        string mensaje =  "Introduzaca un Valor numerico para cada Variable.:";
        double w= 0.0,x= 0.0,y = 0.0,z = 0.0;
        double exponente= 0.0,producto = 0.0, dividendo= 0.0, divisor = 0.0, resultado =0.0;

         //mostrando por pantalla
         Console.WriteLine(mensaje);
         Console.Clear();
        
         //capturando datos del usuario
        
         Console.Write("Entre x: ");
         x = double.Parse(Console.ReadLine());
         Console.Write("Entre y: ");
         y = double.Parse(Console.ReadLine());
         Console.Write("Entre z: ");
         z = double.Parse(Console.ReadLine());
         Console.Write("Entre w: ");
         w = double.Parse(Console.ReadLine());
        
         //prosesando datos
         
         dividendo = ( (0.045* x ) + ( 2.33* y) );
        
         exponente = x + ( (7.3*w) / ( (9.2*z) - (x*y) ) );

         divisor = ( (2.1* Math.Pow(z, exponente )  ) - ( (z/w) * 4.5 )  );

         producto = (x*y) * (z*w);

         resultado = ( ( dividendo / divisor) * producto );

        //salida de datos

        Console.WriteLine("\nResultado = {0}", resultado);

         
             
     



    }
}