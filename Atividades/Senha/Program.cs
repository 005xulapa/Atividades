using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma senha: ");
            string senha = Console.ReadLine();

            if (senha.Length >= 8)
            {
                if (senha.Any(char.IsUpper))
                {
                    if (senha.Any(char.IsLower))
                    {
                        if (senha.Any(char.IsNumber))
                        {
                            Console.WriteLine("Parabéns senha válida");
                        }
                        else
                        {
                            Console.WriteLine("Você digitou uma senha inválida, sem numero!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você digitou uma senha inválida, sem letra minuscula!!");
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou uma senha inválida, sem letra maiuscula!!");
                }
            }
            else
            {
                Console.WriteLine("Você digitou uma senha com menos de 8 caractéres!!");
            }


        }
    }
}
