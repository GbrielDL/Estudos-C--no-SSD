using System;
using System.Collections.Generic;
using static pizzaria.Functions;
//Funções: LerInteiro

namespace pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            Console.WriteLine("--- Escolha o Sabor da Pizza ---");
            foreach (var sabor in Enum.GetNames(typeof(Sabores)))
            {
                contador++;
                Console.WriteLine($"{contador} - {sabor}");
            }
            int escolha = LerInteiro("Opção: ");

            Console.WriteLine($"Ótimo, você escolheu o sabor {(Sabores)escolha-1}");
        }
    }
}