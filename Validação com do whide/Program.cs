using System;

namespace Validação_com_do_whide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com DO WHILE");

            string nome;

            do
            {
                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();
            } while (nome.Length <= 1); //do while verifica a verificação dps
        }
    }
}
