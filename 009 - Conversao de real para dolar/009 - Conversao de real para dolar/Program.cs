using System;

namespace _009___Conversao_de_real_para_dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Real, Dolar;
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("INFORME QUANDO REAIS VOCE TEM.");
            Console.WriteLine("+----------------------------+");
            Real = float.Parse(Console.ReadLine());

            Console.WriteLine("+-----------------------+");
            Console.WriteLine("INFORME O VALOR DO DOLAR.");
            Console.WriteLine("+-----------------------+");
            Dolar = float.Parse(Console.ReadLine());

            Dolar = (Real / Dolar);

            /*+Dolar.ToString("0.00") para formatar pode usar o ("N2") ou ("F") 
               consultar documentação "CADEIAS DE CARACTERES DE FORMATO NUMÉRICO PADRÃO C#."*/
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("POSSO TER: US$" + Dolar.ToString("0.00") + " DOLARES.");
            Console.WriteLine("+--------------------------+");
        }
    }
}
