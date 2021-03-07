using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_general
{
    class Program
    {
        static void Main(string[] args)
        {


            double a;
            double b;
            double c;
            double xuno;
            double xdos;
            double formula;


            Console.WriteLine("Formula general." );
            Console.WriteLine(" ");

            Console.WriteLine("Escribe el valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());


            formula = (b * b) - 4 * a * c;


            if (formula < 0)
              
            { 
                Console.WriteLine (" ");
                formula = -formula;
            }
            else 
             Console.WriteLine(" ");


            //valor 1
           

            xuno = (-b + Math.Sqrt(formula )) / (2 * a);

            //valor 2



            xdos = (-b - Math.Sqrt(formula)) / (2 * a);


            Console.WriteLine("Este es el valor de X1: " + xuno);
            Console.WriteLine(" ");
            Console.WriteLine("Este es el valor de X2: " + xdos);

            Console.ReadKey();


             
        }
    }
}
