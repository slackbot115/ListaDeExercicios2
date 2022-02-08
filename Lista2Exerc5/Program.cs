using System;

namespace Lista2Exerc5
{

//      Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
//      iguais deverá se somar os dois, caso contrário multiplique A por B.

//      Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//      variável C e mostrar seu conteúdo na tela.

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
                    if(op == 1)
                    {
                        Console.Clear();
                        Console.Write("Digite o valor de A: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de B: ");
                        int b = int.Parse(Console.ReadLine());
                        if (a == b)
                        {
                            int c = a + b;
                            Console.WriteLine("A soma de A + B é {0}", c);
                        }
                        else
                        {
                            int c = a * b;
                            Console.WriteLine("A multiplicação de A + B é {0}", c);
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
