using System;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somando dois números e mostrando o resultado
            int num1, num2;

            Console.WriteLine("Escreva dois números para somar: ");
            Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma de {num1} + {num2} é igual a {num1+num2}");
        }
    }
}