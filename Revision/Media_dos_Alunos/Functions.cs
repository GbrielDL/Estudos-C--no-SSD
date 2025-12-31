using System;

namespace calcular_media
{
    public class Validador
    {
        public static float LerFloat(string mensagem)
        {
            float valor;
            // Verficai se o campo está vazio ou se é um número float
            while (true)
            {
                Console.Write(mensagem);
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error! Campo vazio.");
                    continue;
                }
                if (!float.TryParse(entrada, out valor))
                {
                    Console.WriteLine("Error! Digite um número float");
                    continue;
                }
                return valor;
            }
        }
        // Varificar se o número é inteiro
        public static int LerInteiro(string mensagem)
        {
            int valor;

            while (true)
            {
                Console.Write(mensagem);
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error! Campo vazio");
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
        // Verifica uma string
        public static string LerString(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error! Campo vazio.");
                    continue;
                }

                bool apenasLetras = true;
                foreach (char c in entrada)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        apenasLetras = false;
                    }
                }
                if (!apenasLetras)
                {
                    Console.WriteLine("Error! Digite apenas Letras (A - Z)");
                    continue;
                }
                return entrada;
            }
        }
    }
}