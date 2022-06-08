using System;

namespace _012___Emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Valor, Parcelas, Emprestimo;
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("QUAL VALOR DE EMPRESTIMO VOCE PRECISA");
            Console.WriteLine("+-----------------------------------+");
            Emprestimo = float.Parse(Console.ReadLine());

            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("EM QUANTAS PARCELAS VOCE DESEJA PAGAR O EMPRESTIMO");
            Console.WriteLine("+------------------------------------------------+");
            Parcelas = float.Parse(Console.ReadLine());


            Valor = (Emprestimo * 20) / 100;
            Valor = (Valor / Parcelas) + Emprestimo / Parcelas;
            Console.WriteLine("+----------------------------------------------------------+");
            Console.WriteLine("COM EMPRESTIMO DE R$" + Emprestimo + " VOCE TERA QUE PAGAR: " + Parcelas + "X DE: R$" + Valor);
            Console.WriteLine("+----------------------------------------------------------+");
        }
    }
}
