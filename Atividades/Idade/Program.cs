using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano_atual = DateTime.Now.Year;
            int mes_atual = DateTime.Now.Month;
            int dia_atual = DateTime.Now.Day;
            int idade = 0;


            Console.WriteLine("Qual dia voce nasceu?");
            int dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual mes voce nasceu?");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual foi o ano do seu nascimento?");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (ano <= ano_atual)
            {
                if (mes < mes_atual)
                {
                    idade = ano_atual - ano;
                    Console.WriteLine(idade);
                }
                else if (mes == mes_atual && dia <= dia_atual) 
                {
                    idade = ano_atual - ano;
                    Console.WriteLine(idade);
                }
                else
                {
                    idade = ano_atual - ano - 1;
                    Console.WriteLine(idade);
                }
            }
            else
            {
                Console.WriteLine("Ano invalido");
            }
            
            if (idade >= 18) 
            {
                Console.WriteLine("Maior de idade!!");
            }
            else
            {
                Console.WriteLine("Menor de idade!!");
            }
            Console.WriteLine(ano_atual);


            Console.ReadKey();
        }
    }
}
