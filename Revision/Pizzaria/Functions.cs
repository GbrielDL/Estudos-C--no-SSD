using System;
using System.Collections.Generic;

namespace pizzaria
{
    public enum Sabores{Bacon, Frango, Calabresa, Toscana, Nordestina};
    public static class Functions
    {
        public static int LerInteiro(string mensagem)
        {
            int valor;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error! Campo vazio.");
                    continue;
                }
                if (!int.TryParse(entrada, out valor))
                {
                    Console.WriteLine("Error! Digite um número inteiro.");
                    continue;
                }
                return valor;
            }
        }
    }
}