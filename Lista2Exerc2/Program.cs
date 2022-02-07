using System;

namespace Lista2Exerc2
{

//    Escreva um algoritmo que leia três valores inteiros e diferentes e
//    mostre-os em ordem decrescente.

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite 1 para prosseguir\nDigite 0 para sair");
                try
                {
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.Clear();
                        // Recebendo o n1
                        Console.Write("Digite o primeiro valor: ");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = 0;
                        int n3 = 0;
                        // Recebendo e verificando o n2
                        while (true)
                        {
                            Console.Write("Digite o segundo valor: ");
                            n2 = int.Parse(Console.ReadLine());
                            if (n1 == n2)
                            {
                                Console.WriteLine("Digite um valor diferente do número anterior\n");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // Recebendo e verificando o n3
                        while (true)
                        {
                            Console.Write("Digite o terceiro valor: ");
                            n3 = int.Parse(Console.ReadLine());
                            if (n3 == n1 || n3 == n2)
                            {
                                Console.WriteLine("Digite um valor diferente dos números anteriores\n");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("\nExibindo os valores em ordem decrescente: ");
                        // Verificando ordem baseada em n1
                        if (n1 > n2)
                        {
                            if (n1 > n3)
                            {
                                if (n2 > n3)
                                {
                                    Console.WriteLine("{0} > {1} > {2}", n1, n2, n3);
                                    Console.WriteLine("Digite qualquer tecla para prosseguir...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("{0} > {1} > {2}", n1, n3, n2);
                                    Console.WriteLine("Digite qualquer tecla para prosseguir...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        // Verificando ordem baseada em n2
                        if (n2 > n1)
                        {
                            if (n2 > n3)
                            {
                                if (n1 > n3)
                                {
                                    Console.WriteLine("{0} > {1} > {2}", n2, n1, n3);
                                    Console.WriteLine("Digite qualquer tecla para prosseguir...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("{0} > {1} > {2}", n2, n3, n1);
                                    Console.WriteLine("Digite qualquer tecla para prosseguir...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                        }
                        // Verificando ordem baseada em n3
                        if (n3 > n1)
                        {
                            if (n3 > n2)
                            {
                                if (n1 > n2)
                                {
                                    Console.WriteLine("{0} > {1} > {2}", n3, n1, n2);
                                    Console.WriteLine("Digite qualquer tecla para prosseguir...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("{0} > {1} > {2}", n3, n2, n1);
                                    Console.WriteLine("Digite qualquer tecla para prosseguir...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
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
                    Console.WriteLine("Opção inválida, digite novamente...");
                }
            }

        }
    }
}
