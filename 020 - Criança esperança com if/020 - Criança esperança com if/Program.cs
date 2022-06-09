using System;

namespace _020___Criança_esperança_com_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor;
            float OutroValor;

            Console.WriteLine("    ++++++++++++++++++++++++++  ");
            Console.WriteLine("        CRIANCA ESPERANCA       ");
            Console.WriteLine("    ++++++++++++++++++++++++++  ");
            Console.WriteLine("    MUITO OBRIGADO POR AJUDAR   ");
            Console.WriteLine("    ++++++++++++++++++++++++++  ");
            Console.WriteLine("       [1] PARA DOAR R$10       ");
            Console.WriteLine("       [2] PARA DOAR R$25       ");
            Console.WriteLine("       [3] PARA DOAR R$50       ");
            Console.WriteLine("       [4] PARA DOAR OUTROS VALORES");
            Console.WriteLine("       [5] PARA CANCELAR        ");
            Console.WriteLine("                                ");

            Valor = int.Parse(Console.ReadLine());


            if (Valor == 1)
            {
                Console.WriteLine("+--------------------------+");
                Console.WriteLine("MUITO OBRIGADO POR DOAR R$10");
                Console.WriteLine("+--------------------------+");
            }
            else if (Valor == 2)
            {
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("MUITO OBRIGADO POR DOAR $25");
                Console.WriteLine("+-------------------------+");
            }
            else if (Valor == 3)
            {
                Console.WriteLine("+--------------------------+");
                Console.WriteLine("MUITO OBRIGADO POR DOAR R$50");
                Console.WriteLine("+--------------------------+");
            }
            else if (Valor == 4)
            {
                Console.WriteLine("+---------------------------------------+");
                Console.WriteLine("INFORME QUAL O VALOR QUE VOCE DESEJA DOAR");
                Console.WriteLine("+---------------------------------------+");
                OutroValor = float.Parse(Console.ReadLine());

                Console.WriteLine("                                         ");
                Console.WriteLine("+---------------------------------------+");
                Console.WriteLine("+       VOCE DOOU R$ " + OutroValor + " REAIS");
                Console.WriteLine("+                                       +");
                Console.WriteLine("   MUITO OBRIGADO POR DOAR OUTRO VALOR   ");
                Console.WriteLine("+---------------------------------------+");
            }
            else if (Valor == 5)
            {
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("VOCE TECLOU [5] PARA SAIR VOLTE EM BREVE");
                Console.WriteLine("+--------------------------------------+");

            }
        }
    }
}
