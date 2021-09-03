using System;

namespace l_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("\nDesenvolva um programa que mostre na tela uma tabuada escolhida pelo usuário.\n");
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (int multiplicando = 0; multiplicando <= 10; multiplicando++)
            {
                Console.WriteLine(num + " x " + multiplicando + " = " + (num * multiplicando));
            }
            Console.ReadKey();
        }
    }
}
