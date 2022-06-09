using System;

namespace _014___Viagem_disney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Dinheiro;
            Console.WriteLine("+---------------------------------+");
            Console.WriteLine("INFORME QUANTO VOCE TEM DE DINHEIRO");
            Console.WriteLine("+---------------------------------+");
            Dinheiro = float.Parse(Console.ReadLine());

            if (Dinheiro >= 10000)
            {
                Console.WriteLine("+-----------+");
                Console.WriteLine("PARTIU DISNEY");
                Console.WriteLine("+-----------+");
            }
            else if (Dinheiro >= 5000 && Dinheiro < 10000)
            {
                Console.WriteLine("+---------------+");
                Console.WriteLine("VISITAR A FAMILIA");
                Console.WriteLine("+---------------+");
            }
            else
            {
                Console.WriteLine("+-------+");
                Console.WriteLine("#CHATEADO");
                Console.WriteLine("+-------+");
            }
        }
    }
}
