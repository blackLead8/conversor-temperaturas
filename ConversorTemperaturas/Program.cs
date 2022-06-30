using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;
            Console.WriteLine("----CONVERSOR DE TEMPERATURAS: ----");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            //Calculo para Fahrenheit(c * 9/5) + 32;
            f = (c * 9 / 5) + 32;

            //Calculo para Kelvin (c + 273,15);
            k = c + 273.15;

            Console.WriteLine(c + "Graus Celsius =  " + f + " Graus Fahrenheit");
            Console.WriteLine(c + "Graus Celsius =  " + k + " Graus Kelvin");
            Console.WriteLine("-----------------------");
            Console.ReadKey();





        }
    }
}
