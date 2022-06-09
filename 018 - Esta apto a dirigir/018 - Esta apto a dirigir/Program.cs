using System;

namespace _018___Esta_apto_a_dirigir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnoAtual, AnoDeNascimento, Idade;

            Console.WriteLine("   ++++++++++++++++++++++++++  ");
            Console.WriteLine("   +DEPARTAMENTO DE TRANSITO+  ");
            Console.WriteLine("   ++++++++++++++++++++++++++  ");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("INFORME EM QUAL ANO NOS ESTAMOS");
            Console.WriteLine("+-----------------------------+");
            AnoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("                               ");
            Console.WriteLine("INFORME EM QUAL ANO VOCE NASCEU");
            Console.WriteLine("                               ");
            Console.WriteLine("+-----------------------------+");
            AnoDeNascimento = int.Parse(Console.ReadLine());

            Idade = (AnoAtual - AnoDeNascimento);


            if (Idade > 18)
            {
                Console.WriteLine("+----------------STATUS------------------+");
                Console.WriteLine("                                          ");
                Console.WriteLine("            VOCE TEM: " + Idade + "ANOS    ");
                Console.WriteLine("                                          ");
                Console.WriteLine("ESTA APTO A TIRAR A CARTEIRA DE MOTORISTA");
                Console.WriteLine("                                          ");
                Console.WriteLine("+----------------------------------------+");
            }
            else
            {
                Console.WriteLine("+-----------------STATUS------------------+");
                Console.WriteLine("                                           ");
                Console.WriteLine("             VOCE TEM: " + Idade + "ANOS    ");
                Console.WriteLine("                                           ");
                Console.WriteLine("ESTA INAPTO A TIRAR A CARTEIRA DE MOTORISTA");
                Console.WriteLine("                                           ");
                Console.WriteLine("+-----------------------------------------+");
            }
        }
    }
}
