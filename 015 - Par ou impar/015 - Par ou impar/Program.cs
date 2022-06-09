using System;

namespace _015___Par_ou_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Numero;
            Console.WriteLine("+-----------------------+");
            Console.WriteLine("DIGITE UM NUMERO QUALQUER");
            Console.WriteLine("+-----------------------+");
            Numero = float.Parse(Console.ReadLine());

            if (Numero % 2 == 0)
            {
                Console.WriteLine("+-----------------+");
                Console.WriteLine("O NUMERO [" + Numero + "] E PAR");
                Console.WriteLine("+-----------------+");
            }
            else
            {
                Console.WriteLine("+-------------------+");
                Console.WriteLine("O NUMERO [" + Numero + "] E IMPAR");
                Console.WriteLine("+-------------------+");
            }
        }
    }
}
