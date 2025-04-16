using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, prom;
            Console.WriteLine("Ingresar la nota T1(10%): ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota T2(20%): ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota T3(30%): ");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota EF(40%): ");
            nota4 = float.Parse(Console.ReadLine());

            prom = (nota1 * 0.10) + (nota2 * 0.20) + (nota3 * 0.30) + (nota4 * 0.40);

            Console.WriteLine("Promedio: " + prom);
            if (prom > 11.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aprobado");
            }
            else
            { 
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Desaprobado");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}