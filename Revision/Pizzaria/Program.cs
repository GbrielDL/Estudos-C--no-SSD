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
            //Escolhendo o Sabor da Pizza
            Console.WriteLine("--- Escolha o Sabor da Pizza ---");
            foreach (var sabor in Enum.GetNames(typeof(Sabores)))
            {
                contador++;
                Console.WriteLine($"{contador} - {sabor}");
            }
            // Verifica se a escolha está dentro das opções Sabores
            int escolha;
            while (true)
            {
                escolha = LerInteiro("Opção: ");
                if (escolha > Enum.GetNames<Sabores>().Length || escolha < 1)
                {
                    Console.WriteLine("Escolha inválida.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            //Escolhendo o Tamanho da Pizza
            char tamanho = LerTamPizza("Agora escolha o tamanho [P, M, G]: ");

            // Confirmando o pedido, e perguntando se quer bebida
            double valor_pizza = ValorPizza((Sabores)escolha-1, tamanho);
            Console.WriteLine($"Ótimo, você escolheu uma Pizza '{tamanho}' sabor {(Sabores)escolha-1}. Valor total {valor_pizza:c}");

            Console.Write("Alguma coisa pra beber? [S/N]: ");
            string resp = Console.ReadLine().ToUpper();
            // Caso escolha algo pra beber, entrar no if
            if (resp[0] != 'N')
            {
                int cont = 0;
                Console.WriteLine("Fique a vontade: ");
                foreach (var bebida in Enum.GetNames(typeof(Bebidas)))
                {
                    cont++;
                    Console.WriteLine($"{cont} - {bebida}");
                }
                int esc_bebida;
                while (true)
                {
                    esc_bebida = LerInteiro("Escolha: ");
                    if (esc_bebida > Enum.GetNames<Bebidas>().Length || esc_bebida < 1)
                    {
                        Console.WriteLine("Escolha inválida.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                double valor_total = valor_pizza + ValorBebida((Bebidas)esc_bebida-1);
                Console.Write($"--- Seu Pedido ---\n{(Sabores)escolha-1} '{tamanho}' {(Bebidas)esc_bebida-1,10}\nTotal: {valor_total:c}");
            }
            else
            {
                Console.Write($"--- Seu Pedido ---\n{(Sabores)escolha-1} '{tamanho}'\nTotal: {valor_pizza:c}");
            }
        }
    }
}