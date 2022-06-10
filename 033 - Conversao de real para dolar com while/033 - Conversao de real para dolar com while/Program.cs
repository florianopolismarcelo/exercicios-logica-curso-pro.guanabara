using System;

namespace _033___Conversao_de_real_para_dolar_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 1, Real = 1, Dolar = 0;
            int Conversao;
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("QUANTOS VEZES VOCE QUER CONVERTER");
            Console.WriteLine("+-------------------------------+");
            Conversao = int.Parse(Console.ReadLine());
            while (i <= Conversao)
            {
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("+         COTACAO DO DOLAR HOJE 4.81     +");
                Console.WriteLine("+                                        +");
                Console.WriteLine("QUANTOS REAIS VOCE TEM PARA COMPRAR DOLAR?");

                Real = double.Parse(Console.ReadLine());
                Console.WriteLine(Real);
                Dolar = (Real / 4.80);
                i = i + 1;

                Console.WriteLine("VOCE COMPROU USD: " + Dolar.ToString("0.00"));
            }
        }
    }
}
