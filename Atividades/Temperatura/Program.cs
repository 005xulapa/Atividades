using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temp_final = 0;

            Console.WriteLine("Qual a escala de origem (1-Celsius, 2-Fahrenheit)?");
            int origem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a temperatura de origem?");
            decimal temp_origem = Convert.ToDecimal(Console.ReadLine());

            if (origem == 1) 
            {
                temp_final = (temp_origem * 9 / 5) + 32;
            }
            else 
            {
                temp_origem = temp_origem - 32;
                temp_final = temp_origem * 5 / 9;
            }

            Console.WriteLine(temp_final);

            Console.ReadKey();
        }
    }
}
