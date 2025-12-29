using System;

namespace aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha uma fruta:\n[1] Maça\n[2] Uva\n[3] Banana\nOpção: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu Maça");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu Uva");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu Banana");
                    break;
                default:
                    break;
            }
        }
    }
}