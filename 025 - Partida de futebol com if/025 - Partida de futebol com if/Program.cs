using System;

namespace _025___Partida_de_futebol_com_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GolMadureira, GolBangu, Diferenca;
            Console.WriteLine("+------------------------+");
            Console.WriteLine("+--  BANGU x MADUREIRA --+");
            Console.WriteLine("+                        +");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("QUANTOS GOLS FEZ BANGU?");
            Console.WriteLine("+------------------------+");
            GolBangu = int.Parse(Console.ReadLine());

            Console.WriteLine("+---------------------+");
            Console.WriteLine("QUANTOS GOLS FEZ MADUREIRA?");
            Console.WriteLine("+---------------------+");
            GolMadureira = int.Parse(Console.ReadLine());


            if (GolBangu > GolMadureira)
            {
                Diferenca = (GolBangu - GolMadureira);
            }
            else
            {
                Diferenca = (GolMadureira - GolBangu);
            }
            if (Diferenca < 0)
            {
                Diferenca = (Diferenca * -1);
            }
            else if (Diferenca == 0)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("EMPATE: BANGU " + GolBangu + " x " + GolMadureira + " MARDUREIRA");
                Console.WriteLine("------------------------------");
            }
            else if (Diferenca >= 1 && Diferenca < 4)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("DIFERENCA: " + Diferenca);
                Console.WriteLine("PARTIDA NORMAL");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("DIFERENCA: " + Diferenca);
                Console.WriteLine("GOLEADA");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
