using System;

namespace _002___Valor_absoluto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Numero, ValorAbsoluto;

            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("DIGITE O NÚMERO QUE VOCÊ DESEJA SABER O VALOR ABSOLUTO");
            Console.WriteLine("+----------------------------------------------------+");
            Numero = float.Parse(Console.ReadLine());

            ValorAbsoluto = (float)Math.Abs(Numero);

            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("O VALOR ABSOLUTO DE : " + Numero + " É = " + ValorAbsoluto);
            Console.WriteLine("+----------------------------------+");
            Console.ReadLine();
        }
    }
}
