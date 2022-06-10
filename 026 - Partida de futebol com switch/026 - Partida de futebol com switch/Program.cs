using System;

namespace _026___Partida_de_futebol_com_switch
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
            switch (Diferenca)
            {
                case var _ when (Diferenca == 0):
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("EMPATE: BANGU " + GolBangu + " x " + GolMadureira + " MARDUREIRA");
                    Console.WriteLine("------------------------------");
                    break;
                case var _ when (Diferenca >= 1 && Diferenca < 4):
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("DIFERENCA: " + Diferenca);
                    Console.WriteLine("PARTIDA NORMAL");
                    Console.WriteLine("------------------------------");
                    break;
                default:
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("DIFERENCA: " + Diferenca);
                    Console.WriteLine("GOLEADA");
                    Console.WriteLine("------------------------------");
                    break;
            }
        }
    }
}
