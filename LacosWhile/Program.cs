using System;

namespace LacosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor limite");
            int limite = int.Parse(Console.ReadLine());
            while(contador <= limite)
            {
                
            Console.WriteLine("Laço de Repetição While!");
            int contador = 0;

                Console.WriteLine(contador);

                contador = contador + 1;
                //fim do While

            }
        }
    }
}
