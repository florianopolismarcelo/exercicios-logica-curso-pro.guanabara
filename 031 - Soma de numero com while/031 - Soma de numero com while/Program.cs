using System;

namespace _031___Soma_de_numero_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, Numero = 1, Soma = 0;
            while (i <= 5)
            {
                Console.WriteLine("+------------------------+");
                Console.WriteLine("QUAIS NUMERO DESEJA SOMAR?");
                Console.WriteLine("+------------------------+");
                Numero = int.Parse(Console.ReadLine());
                Console.WriteLine(Numero);
                Soma = Soma + Numero;
                i = i + 1;
            }

            Console.WriteLine("+----------------------+");
            Console.WriteLine("A SOMA DE TODOS NUMEROS E: " + Soma);
            Console.WriteLine("+----------------------+");
        }
    }
}
