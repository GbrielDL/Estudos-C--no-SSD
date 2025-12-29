using System;

namespace aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[2,3];
            /*Exemplo:
            10 23 45
            34 67 90*/
            numbers[0,0] = 10;
            numbers[0,1] = 23;
            numbers[0,2] = 45;

            numbers[1,0] = 34;
            numbers[1,1] = 67;
            numbers[1,2] = 90;

            for (int cont = 0; cont < 2; cont++)
            {
                Console.Write(" | ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[cont, i]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}