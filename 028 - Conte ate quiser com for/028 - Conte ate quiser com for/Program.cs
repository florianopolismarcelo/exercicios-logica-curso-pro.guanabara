using System;

namespace _028___Conte_ate_quiser_com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Contador;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("DESEJA CONTAR ATE QUANTO");
            Console.WriteLine("+----------------------+");
            Contador = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Contador; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("+----------------+");
            Console.WriteLine("TERMINEI DE CONTAR");
            Console.WriteLine("+----------------+");
        }
    }
}
