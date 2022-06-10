using System;

namespace _030___Contador_com_salto_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor, Salto, i = 0;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("DESEJA CONTAR ATE QUANTO");
            Console.WriteLine("+----------------------+");
            Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("+------------------------+");
            Console.WriteLine("QUAL SERA O VALOR DO SALTO");
            Console.WriteLine("+------------------------+");
            Salto = int.Parse(Console.ReadLine());

            while (i <= Valor)
            {
                Console.WriteLine(i);
                i = i + Salto;
            }
            Console.WriteLine("+----------------+");
            Console.WriteLine("TERMINEI DE CONTAR");
            Console.WriteLine("+----------------+");
        }
    }
}
