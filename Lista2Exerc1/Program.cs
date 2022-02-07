using System;

namespace Lista2Exerc1
{
//    Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
//    soma de A + B é menor que C.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            int dif = a + b;
            if(dif < c)
            {
                Console.WriteLine("A soma de A + B é menor que C");
                Console.WriteLine("{0} < {1}", dif, c);
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C");
                Console.WriteLine("{0} > {1}", dif, c);
            }

        }
    }
}
