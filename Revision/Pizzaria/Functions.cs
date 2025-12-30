using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace pizzaria
{
    // Sabores Pizzas
    public enum Sabores{Bacon, Frango, Calabresa, Toscana, Nordestina};
    // Bebidas
    public enum Bebidas{CocaCola, Fanta, Guaraná, Sprite};
    public static class Functions
    {
        public static int LerInteiro(string mensagem)
        {
            int valor;
            while (true)
            {
                // Ler mensagem do teclado
                Console.Write(mensagem);
                string entrada = Console.ReadLine();
                // Verifica se o campo está vazio
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error! Campo vazio.");
                    continue;
                }
                // Verifica se é um número inteiro
                if (!int.TryParse(entrada, out valor))
                {
                    Console.WriteLine("Error! Digite um número inteiro.");
                    continue;
                }
                return valor;
            }
        }

        public static string LerString(string mensagem)
        {
            while (true)
            {
                // Ler mensagem do teclado
                Console.Write(mensagem);
                string entrada = Console.ReadLine();
                // Verificar se o campo está vazio
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error! Campo vazio");
                    continue;
                }
                // Verificar se realmente tem apenas Letras
                bool apenasLetras = true;
                foreach (var c in entrada)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        apenasLetras = false;
                        break;
                    }
                }
                // Se não tiver apenas letras, repete tudo novamente
                if (!apenasLetras)
                {
                    Console.WriteLine("Error! Digite apenas letras (A - Z)");
                    continue;
                }
                return entrada;
            }
        }

        public static char LerTamPizza(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine().Trim().ToUpper();
                // Verifica se digitou apenas 1 Caractere
                if (entrada.Length != 1)
                {
                    Console.WriteLine("Error! Digite apenas um caractere");
                    continue;
                }

                char tamanho = entrada[0];
                // Verificar se é P, M ou G
                if (tamanho != 'P' && tamanho != 'M' && tamanho != 'G')
                {
                    Console.WriteLine("Error! Digite um tamanho válido.");
                    continue;
                }

                return tamanho;
            }
        }
        // Calculando o preço da Pizza
        public static double ValorPizza(Sabores sabor, char tamanho)
        {
            return (sabor, tamanho) switch
            {
                (Sabores.Bacon, 'P') => 24.4,
                (Sabores.Bacon, 'M') => 30,
                (Sabores.Bacon, 'G') => 45,

                (Sabores.Calabresa, 'P') => 22,
                (Sabores.Calabresa, 'M') => 28.5,
                (Sabores.Calabresa, 'G') => 36.7,

                (Sabores.Frango, 'P') => 18.5,
                (Sabores.Frango, 'M') => 23,
                (Sabores.Frango, 'G') => 29.9,

                (Sabores.Nordestina, 'P') => 25,
                (Sabores.Nordestina, 'M') => 30.4,
                (Sabores.Nordestina, 'G') => 38.6,

                (Sabores.Toscana, 'P') => 28,
                (Sabores.Toscana, 'M') => 35,
                (Sabores.Toscana, 'G') => 45,

                _ => 0
            };
        }
        // Calculando o preço da Bebida
        public static double ValorBebida(Bebidas bebida)
        {
            return (bebida) switch
            {
                Bebidas.CocaCola => 7.5,
                Bebidas.Fanta => 4.5,
                Bebidas.Guaraná => 5,
                Bebidas.Sprite => 3.5,

                _ => 0
            };
        }
    }
}