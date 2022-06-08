using System;

namespace _011___Imposto_do_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Preco, Imposto, ValorPagar;
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("INFORME QUAL O VALOR DO PRODUTO");
            Console.WriteLine("+-----------------------------+");
            Preco = float.Parse(Console.ReadLine());

            Imposto = (Preco * 60) / 100;
            ValorPagar = Imposto + Preco;
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("O VALOR DO IMPOSTO SERA: R$" + Imposto);
            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine("E O VALOR FINAL DO PRODUTO SERA DE: R$" + ValorPagar);
            Console.WriteLine("+----------------------------------------+");
        }
    }
}
