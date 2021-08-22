/*Ejercicio 2:
Calcular el número de pulsaciones que debe tener una persona por cada 10 segundos de ejercicio aeróbico; la formula que
se aplica cuando el
sexo es femenino es:
pulsaciones = (220 - edad) / 10
si el sexo es masculino:
pulsaciones = (210 - edad) / 10 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo; 
            int edad;
            double pulsaciones = 0;

            Console.WriteLine("\n ----PULSACIONES----");
            Console.WriteLine("DIGITE SU SEXO: ");
            sexo = Console.ReadLine();
            Console.WriteLine("DIGITE SU EDAD: ");
            edad = Convert.ToInt32 (Console.ReadLine());

            if (sexo.ToUpper().Equals("M"))
            {
                pulsaciones = (210 - edad) / 10;
            }
            else if (sexo.ToUpper().Equals("F"))
            {
                pulsaciones = (220 - edad) / 10;
            }
            Console.WriteLine("SU PULSACION ES: " + pulsaciones);
            Console.ReadKey();

        }
    }
}