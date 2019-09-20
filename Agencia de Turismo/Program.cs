using System;

namespace Agencia_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");

            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data = new DateTime[5]; //É uma array também, assim como string mas armazena data

            int opcao = 0;
            int contador = 0;

            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Listar Passagens");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Vamos cadastrar agora");
                        string resposta = "";
                        do
                        {
                            if (contador < 2)
                            {
                                Console.WriteLine("Digite o nome do passageiro");
                                nome[contador] = Console.ReadLine();

                                Console.WriteLine("Digite a origem");
                                origem[contador] = Console.ReadLine();

                                Console.WriteLine("Digite o Destino");
                                destino[contador] = Console.ReadLine();

                                Console.WriteLine("Digite a Data do Vôo");
                                data[contador] = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Você deseja cadastrar mais um? S/N");
                                resposta = Console.ReadLine();
                                contador++;
                            }
                            else
                            {
                               Console.WriteLine("Número de passagens excedidas"); 
                            }
                        } while (resposta == "S");
                        break;

                    case 2:
                        Console.WriteLine("Listando as Passagens");
                        int contadorB = 0;
                        while(contadorB < 2)
                        {
                            Console.WriteLine($"Passageiro nome: {nome[contadorB]}, origem: {origem[contadorB]}");
                            contadorB++;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por usar nosso sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                        //fim switch
                }

            } while (opcao != 0);
        }
    }
}
