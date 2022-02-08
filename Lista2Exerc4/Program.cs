using System;

namespace Lista2Exerc4
{

//    Faça um algoritmo para receber um número qualquer e informar na tela se
//    é par ou ímpar.

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 para prosseguir\n0 para sair");
                try
                {
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Clear();
                        Console.Write("Digite um número: ");
                        int num = int.Parse(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.WriteLine("O número {0} é par", num);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("O número {0} é impar", num);
                            Console.ReadKey();
                        }
                    }
                    else if (op == 0)
                    {
                        Console.WriteLine("Fechando o programa...");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ocorreu um erro, tente novamente...");
                }
                
            }
        }
    }
}
