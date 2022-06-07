using System;

namespace _003___Raiz_quadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Numero, RaizQuadrada;

            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("DIGITE O NÚMERO QUE VOCÊ DESEJA SABER A RAIZ QUADRADA");
            Console.WriteLine("+---------------------------------------------------+");
            Numero = float.Parse(Console.ReadLine());

            RaizQuadrada = (float)Math.Sqrt(Numero);

            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("A RAIZ QUADRADA DE: " + Numero + " É = " + RaizQuadrada);
            Console.WriteLine("+----------------------------------+");
            Console.ReadLine();
        }
    }
}
