using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, dividir;

            Console.WriteLine("Ingrese el primer dato: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo dato: ");
            numero2 = Convert.ToInt32(Console.ReadLine());


            if (numero2 <= 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                dividir = numero1 / numero2;

                Console.WriteLine("Resultado: {0}", dividir);

            }
            Console.ReadKey();
        }
    }
} 