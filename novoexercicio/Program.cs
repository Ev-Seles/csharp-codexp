﻿using System;

namespace novoexercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("App de Média escolar");

            Console.WriteLine("Digite o seu nome");
            string nome =  Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");
            string valorDigitado = Console.ReadLine(); 
            float nota1 = float.Parse(valorDigitado); //converte o texto em número(float)

            Console.WriteLine("Digite a segunda nota");
            float nota2 = float.Parse(Console.ReadLine()); //Recebe o valor digitado e converte em número
            float media = (nota1+nota2)/2;
            string resultado;//string sem valor
            if(media>=7){
                resultado = "Aprovado"; //Atribui valor 
            }else{
                resultado = "Reprovado";
                
               
            }
            Console.WriteLine($"{nome} sua media é: {media} e você foi {resultado}");

            
        }
    }
}
