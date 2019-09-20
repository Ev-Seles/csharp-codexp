using System;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App cálculo de aumento salarial");

            Console.WriteLine("Digite o seu salário");
            float salario = float.Parse(Console.ReadLine());

            if (salario < 990){
                double reajuste = salario * 0.3;
                double sreajustado = salario + reajuste; 
                Console.WriteLine($"Seu salário reajustado fica em: {sreajustado}");
            }else{
                Console.WriteLine($"Você não tem direito ao aumento salarial");
            }
            

        }
    }
}
