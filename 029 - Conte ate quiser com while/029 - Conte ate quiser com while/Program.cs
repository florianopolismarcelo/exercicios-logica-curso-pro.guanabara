using System;

namespace _029___Conte_ate_quiser_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, Contador;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("DESEJA CONTAR ATE QUANTO");
            Console.WriteLine("+----------------------+");
            Contador = int.Parse(Console.ReadLine());

            while (i <= Contador)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("+----------------+");
            Console.WriteLine("TERMINEI DE CONTAR");
            Console.WriteLine("+----------------+");
        }
    }
}
