using System;

namespace _032___Soma_dos_numeros_mostra_o_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, Numero = 1, Soma = 0, Maior = 0;
            while (i <= 5)
            {
                Console.WriteLine("+------------------------+");
                Console.WriteLine("QUAIS NUMERO DESEJA SOMAR?");
                Console.WriteLine("+------------------------+");
                Numero = int.Parse(Console.ReadLine());
                Console.WriteLine(Numero);
                Soma = Soma + Numero;
                i = i + 1;
                if (Numero > Maior)
                {
                    Maior = Numero;
                }
            }
            Console.WriteLine("+----------------------+");
            Console.WriteLine("A SOMA DE TODOS NUMEROS E: " + Soma);
            Console.WriteLine("+----------------------+");
            Console.WriteLine("O MAIOR NUMEROS E: " + Maior);
        }
    }
}
