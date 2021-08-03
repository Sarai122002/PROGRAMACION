using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, resta, multip, multiplicacion, Dato1, Dato2;


            Console.WriteLine("Ingrese el primer dato: ");
            Dato1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo dato: ");
            Dato2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            suma = Dato1 + Dato2;

            resta = Dato1 - Dato2;

            multip = suma * resta;

            multiplicacion = Dato1 * 2 - Dato2;

            Console.WriteLine("El resultado de la suma es: R/ " + suma);
            Console.WriteLine("El resultado de la resta es: R/ " + resta);
            Console.WriteLine("El resultado de (a+b)*(a-b) es:  R/ " + multip);
            Console.WriteLine("El resultado de a2-b es: R/ " + multiplicacion);
            Console.ReadKey();


        }
    }
}