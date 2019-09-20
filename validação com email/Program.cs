using System;

namespace validação_com_email
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string email; 
            do
            {
            Console.WriteLine("Digite seu email");
            email= Console.ReadLine();
            } while (!email.Contains("@")|| !email.Contains("."));
            
            string senha;
            do
            {
                Console.WriteLine("Digite a senha");
                senha = Console.ReadLine(); 
                
            } while (senha.Length <=6);
    
        
        }
    }
}
