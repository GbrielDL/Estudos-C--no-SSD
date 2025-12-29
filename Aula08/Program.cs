using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Cadastrar Pessoa ---");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            //Veerifcando a idade com IF
            if (idade < 18)
            {
                Console.WriteLine($"{nome} é MENOR de Idade!");
            }
            else
            {
                Console.WriteLine($"{nome} é MAIOR de idade.");
            }
        }
    }
}