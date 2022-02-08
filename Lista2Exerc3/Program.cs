using System;

namespace Lista2Exerc3
{

//      Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
//      sua condição de acordo com a tabela abaixo.

//      Formula IMC: peso / (altura)^2

//      IMC em adultos Condição
//      Abaixo de 18,5 Abaixo do peso
//      Entre 18,5 e 25 Peso normal
//      Entre 25 e 30 Acima do peso
//      Acima de 30 obeso

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
                        Console.WriteLine("Calculadora de IMC");
                        double peso = 0.0;
                        double altura = 0.0;

                        Console.WriteLine("Digite seu peso (kg): ");
                        peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite sua altura (cm - utilize a virgula para metros): ");
                        altura = double.Parse(Console.ReadLine());

                        double imc = peso / Math.Pow(altura, 2);

                        if (imc < 18.5)
                        {
                            Console.WriteLine("Você está: Abaixo do Peso\nIMC: {0}", Math.Round(imc, 2));
                            Console.WriteLine("Digite qualquer tecla para avançar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (imc > 18.5 && imc < 25)
                        {
                            Console.WriteLine("Você está: Peso normal\nIMC: {0}", Math.Round(imc, 2));
                            Console.WriteLine("Digite qualquer tecla para avançar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (imc > 25 && imc < 30)
                        {
                            Console.WriteLine("Você está: Acima do Peso\nIMC: {0}", Math.Round(imc, 2));
                            Console.WriteLine("Digite qualquer tecla para avançar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Você está: Obeso\nIMC: {0}", Math.Round(imc, 2));
                            Console.WriteLine("Digite qualquer tecla para avançar...");
                            Console.ReadKey();
                            Console.Clear();
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
