using System;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores e Operações
            string user = "gabriel";
            string password = "123biel";
            //Lendo usuário
            Console.Write("Digite o Usuário: ");
            string usuario = Console.ReadLine();
            //Lendo senha
            Console.Write("Digite a Senha: ");
            string senha = Console.ReadLine();

            bool ativo = (user == usuario) && (password == senha);
            //Conferindo se 'ativo' está True
            if (!ativo)
            {
                Console.WriteLine("Acesso negado!");
            }
            else
            {
                Console.WriteLine($"Bem vindo {usuario}.");   
            }
        }
    }
}