using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using static calcular_media.Validador; // LerFloat, LerString, LerFloat

namespace calcular_media
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um dicionário com Nome e Notas dos alunos
            Dictionary<string, List<float>> dados = new();
            // Pergunta quantos alunos vão ser cadastrados
            int quant_alunos = LerInteiro("Quantos Alunos vão ser cadastrados? ");
            // Pergunta quantas notas vão ser cadastradas
            int quant_notas = LerInteiro("Quantas Notas vão ser cadastradas? ");
            // Pede Nome e as Notas
            for (int a = 0; a < quant_alunos; a++)
            {
                string nome = LerString($"Nome do {a+1}* Aluno: ");
                dados[nome] = new List<float>(); // Cria a lista de notas para o Aluno
                for (int n = 0; n < quant_notas; n++)
                {
                    float nota = LerFloat($"Digite a {n+1}* Nota de {nome}: ");
                    dados[nome].Add(nota);
                }
            }
            // Motra o resultado (Nome, Média, Situação(Aprovado, Recuperação, Reprovado))
            Console.WriteLine("--- Resultado Final ---\nAluno   Média   Situação");
            foreach (var aluno in dados)
            {
                float soma = 0;

                foreach (var nota in aluno.Value)
                {
                    soma += nota;
                }
                float media = aluno.Value.Count > 0 ? soma / aluno.Value.Count : 0;
                string resultado = media switch
                {
                    < 50 => "Reprovado",
                    < 60 => "Recuperação",
                    > 60 => "Aprovado",
                    _ => "Valor inválido"
                };
                Console.WriteLine($"{aluno.Key} | {media:F1} | {resultado}");
            }
        }
    }
}