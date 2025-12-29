using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 14)
            {
                Console.WriteLine("Você ainda é criança.");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Você ainda é muito jovem.");
            }
            else if (idade < 60)
            {
                Console.WriteLine("Você ja é Adulto.");
            }
            else
            {
                Console.WriteLine("Você é um idoso.");
            }
        }
    }
}