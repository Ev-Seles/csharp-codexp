using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Qual tabuada você deseja conhecer?");
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine()); 

            int n = 0; 
            while( n <=10){

                Console.WriteLine($"{numero} * {n} = {numero*n}");
                n = n + 1; 
            }

        }
    }
}
