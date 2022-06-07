using System;

namespace _008___Creuza_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnoAtual, AnoDeNascimento, Idade;
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("INFORME EM QUAL ANO NOS ESTAMOS");
            Console.WriteLine("+-----------------------------+");
            AnoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("INFORME EM QUAL ANO VOCE NASCEU");
            Console.WriteLine("+-----------------------------+");
            AnoDeNascimento = int.Parse(Console.ReadLine());

            Idade = (AnoAtual - AnoDeNascimento);
            Console.WriteLine("+----------------+");
            Console.WriteLine("VOCE TEM: " + Idade + " ANOS");
            Console.WriteLine("+----------------+");
        }
    }
}
