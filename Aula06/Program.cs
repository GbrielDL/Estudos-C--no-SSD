using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lendo valores e mostrando na saída
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digie sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome e {nome}, tem {idade} anos");
        }
    }
}