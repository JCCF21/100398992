/*  para la formula "1 + x + x^2/2! + x^3/3! +...+ x^n/n!" escriba un programa que tome un valor x como entrada
    y vizualize la suma para cada uno de los valores de 1 hasta n, donde n representa la cantidad de anios que tu tienes.
*/
using System;

class Lab2B
{
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
    
        double n = 0.0, x = 0.0,sumatoria = 0.0, resultado = 0.0, f =0.0, p= 0.0;

        //obtencion de datos
        Console.Clear(); 
        Console.WriteLine("Introduzca valor de X: ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca valor de n: ");
        n = double.Parse( Console.ReadLine());
        Console.WriteLine();
        
        //proceso
        for (int i = 1; i <= n; i++)
        {
            f = calcularFactorial(i);
            p =Math.Pow(x,i);
           
            sumatoria = sumatoria + ( p / f );

            Console.WriteLine("{0} ) {1}",i, sumatoria);
                        
        }  
        {
            f = calcularFactorial(i);
            p =Math.Pow(x,i);
           
            sumatoria = sumatoria + ( p / f );

            Console.WriteLine("{0} ) {1}",i, sumatoria);
                        
        }  
        resultado = 1 + sumatoria;
        //salida
        Console.WriteLine("\n\nResultado = {0} ",resultado);        


    }
}