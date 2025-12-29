using System;

namespace aula02
{
    class Program
    {  
        static void Main(string[] args)
        {
            //Pegando dados de fora
            Console.Write("Você escreveu: ");
            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }
            else
            {
                Console.WriteLine("Nada");
            }
        }
    }
}