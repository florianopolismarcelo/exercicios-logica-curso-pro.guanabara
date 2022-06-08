using System;

namespace _010___Conversao_temperatura_EUA_BRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TFahrenheit, TCelsius;
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("INFORME A TEMPERATURA ATUAL EUA");
            Console.WriteLine("+-----------------------------+");
            TFahrenheit = double.Parse(Console.ReadLine());

            TCelsius = (TFahrenheit - 32) / 1.8;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("NO BRASIL ESTARIA " + TCelsius.ToString("0.00"));
            Console.WriteLine("+----------------------+");
        }
    }
}
