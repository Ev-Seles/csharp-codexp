﻿using System;

namespace Cargos_com_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do cargo para descobrir o salário");
            Console.WriteLine("---------------");
            Console.WriteLine("( 1 ) - Diretor");
            Console.WriteLine("( 2 ) - Gerente");
            Console.WriteLine("( 3 ) - Professor");
            Console.WriteLine("( 4 ) - Coordernador");
            Console.WriteLine("( 5 ) - Atendente");
            Console.WriteLine("-------------------");

            string resposta = Console.ReadLine();

            switch(resposta){
                case "1":
                Console.WriteLine("O Salário do Diretor é de R$ 18.000,00");
                break;
                case "2":
                Console.WriteLine("O Salário do Gerente é de R$12.000,00");
                break;
                case "3":
                Console.WriteLine("O Salário do Professor é de R$:1.000,00");
                break;
              case "4":
              Console.WriteLine("O Salário do Coodernador é de R$:9.000,00");
                break;
                case "5":
                Console.WriteLine ("O Salário do Atendente é de R$1.500,00");
                break;
                default:
                Console.WriteLine("Digite um valor entre 1 e 5");
                break;
            }



        }
    }
}
