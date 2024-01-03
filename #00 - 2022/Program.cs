using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */
namespace _00___2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i  = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0) Console.WriteLine($"{i} = fizz");
                else if (i % 5 == 0 && i % 3 != 0) Console.WriteLine($"{i} = buzz");
                else if (i % 5 == 0 && i % 3 == 0) Console.WriteLine($"{i} = fizzbuzz");
                else Console.WriteLine($"{i} no es múltiplo ni de 3 ni de 5");
            }

            Console.ReadKey();
        }
    }
}
