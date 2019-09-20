using System;

namespace rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio Veicular");
            //Entrada de dados

            Console.WriteLine("Digite o último número da sua placa");
            string placa = int.Parse(Console.ReadLine());
            

            int caracteres = placa.Lenght; //Serve para ler a quantidade de caracteres
            int final = int.Parse(placa.Substring(caracteres - 1)); //Pra pegar o último número ou caracter
            
            Console.WriteLine($"A posição 0 é: {final}");
            if(final == 0 || final==1){
                Console.WriteLine("Segunda-Feira");
            }else if(final == 2 || final == 3){
                Console.WriteLine("Terça-Feira");
            }else if(final == 4 || final == 5){
                Console.WriteLine("Quarta-Feira");
            }else if(final == 6 || final == 7){
                Console.Write("Quinta-Feira");
            }else if(final == 8 ||final == 9){
                Console.WriteLine("Sexta-Feira");
            }else{
                Console.WriteLine("Insira apenas o último dígito");
            }
        }
    }
}
