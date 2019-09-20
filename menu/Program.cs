using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu");
            //Entrada de dados

            Console.WriteLine("Digite o 1° número");
          int n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite o 2º número");
          int n2 = int.Parse(Console.ReadLine());

          //processamento
          
          Console.WriteLine(" (1) A soma dos dos números");
          Console.WriteLine(" (2) Subtração do primeiro pelo segundo");
          Console.WriteLine(" (3) Subtração do segundo pelo primeiro");
          Console.WriteLine(" (4) Multiplicação dos dois números");
          Console.WriteLine(" (5) Divisão do primeiro pelo segundo");
          Console.WriteLine(" (6) Divisão do segundo pelo primeiro");


          string resposta = Console.ReadLine();

        switch(resposta){ 
            Console.WriteLine($"A soma");
            case "1"
        }

           
           
        
        }
    }
}
