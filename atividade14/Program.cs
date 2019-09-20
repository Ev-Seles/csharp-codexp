using System;

namespace atividade14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 7)
            {
          Console.WriteLine("Categoria Infantil A");
            }

            else if (idade <=10)
            {Console.WriteLine("Categoria Infantil B");
            }

            else if(idade <=13)
            {Console.WriteLine("Categoria Juvenil A");
            }

            else if(idade <=17)
            {Console.WriteLine("Categoria Juvenil B");
            }
             
             else (idade > 18)
             Console.WriteLine("Categoria Adulto"); 
        
    
        }
        


        }
    }
}
