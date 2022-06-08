using System;

namespace _013___Maior_ou_menor_idade
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

            if (Idade >= 18)
            {
                Console.WriteLine("+-----------------------------------------+");
                Console.WriteLine("VOCE TEM: " + Idade + " ANOS E COMPLETOU A MAIOR IDADE");
                Console.WriteLine("+-----------------------------------------+");
            }
            else
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("VOCE TEM: " + Idade + " ANOS E MENOR DE IDADE");
                Console.WriteLine("+---------------------------------+");
            }
        }
    }
}
