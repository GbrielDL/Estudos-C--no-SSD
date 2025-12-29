using System;

namespace aula07
{
    class Program
    {
        //Enumeradores "enum"
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
        static void Main(string[] args)
        {
            int cont = 1;

            Console.WriteLine("--- Escolha um dia para reunião ---");
            foreach (var dia in Enum.GetNames(typeof(DiasSemana)))
            {
                Console.WriteLine($"{cont} - {dia}");
                cont++;
            }
            Console.Write("Opção: ");
            int resp = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ótimo, reunião marcada para {(DiasSemana)resp-1}");
        }
    }
}