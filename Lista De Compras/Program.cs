using System;

namespace Lista_De_Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de compras!");

            string[] listadecompras = new string[6];
            

            int contador = 0;   
            while( contador <= 5){
                Console.WriteLine("Quais produtos você deseja?");
                listadecompras [contador] = Console.ReadLine();
                contador++;
            }
             contador = 0;
            while(contador <= 5){
                Console.WriteLine($"A lista de produtos {listadecompras[contador]}");
                contador++;
            }
            

        }
    }
}
