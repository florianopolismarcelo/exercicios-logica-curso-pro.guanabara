using System;

namespace _017___Calculo_do_IMC_com_swith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Imc, Peso, Altura;
            Console.WriteLine("+--------------+");
            Console.WriteLine("INFORME SEU PESO");
            Console.WriteLine("+--------------+");
            Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("+----------------+");
            Console.WriteLine("INFORME SUA ALTURA");
            Console.WriteLine("+----------------+");
            Altura = double.Parse(Console.ReadLine());

            Imc = (Peso / (Math.Pow(Altura, 2)));

            switch (Imc)
            {
                case var _ when Imc < 17:
                    Console.WriteLine("VOCE ESTA MUITO ABAIXO DO PESO " + Imc.ToString("0.00"));
                    break;
                case var _ when (Imc >= 17 && Imc < 18.5):
                    Console.WriteLine("VOCE ESTA ABAIXO DO PESO: " + Imc.ToString("0.00"));
                    break;
                case var _ when (Imc >= 18.5 && Imc < 25):
                    Console.WriteLine("VOCE TEM O PESO IDEAL: " + Imc.ToString("0.00"));
                    break;
                case var _ when (Imc >= 25 && Imc < 30):
                    Console.WriteLine("VOCE ESTA COM SOBREPESO: " + Imc.ToString("0.00"));
                    break;
                case var _ when (Imc >= 30 && Imc < 35):
                    Console.WriteLine("VOCE ESTA OBESO: " + Imc.ToString("0.00"));
                    break;
                case var _ when (Imc >= 35 && Imc < 40):
                    Console.WriteLine("OBESIDADE SEVERA: " + Imc.ToString("0.00"));
                    break;
                case var _ when (Imc > 40):
                    Console.WriteLine("OBESIDADE MORBIDA: " + Imc.ToString("0.00"));
                    break;
            }
        }
    }
}
