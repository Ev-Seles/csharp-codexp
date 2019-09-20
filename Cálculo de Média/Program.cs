using System;

namespace Cálculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        

            int n1,n2,n3;

            Console.WriteLine("Digite a 1ª nota");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3ª nota");
            n3 = int.Parse(Console.ReadLine());
            
            float soma = (n1+n2+n3);
            float media = soma/3;

            Console.WriteLine($"A média é de: {media}");

        }
         

