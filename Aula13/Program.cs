using System;

namespace aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cont = 0; cont < 5; cont++)
            {
                Console.WriteLine($"{cont+1} - Hello World.");
            }
            
            Console.WriteLine();
            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"{contador+1} - Olá, Mundo!");
                contador++;
            }
        }
    }
}