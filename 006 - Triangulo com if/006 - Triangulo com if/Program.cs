using System;

namespace _006___Triangulo_com_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Lado1, Lado2, Lado3;
            Boolean Triangulo = true, Equilatero = true, Escaleno = true, Esoseles = true;

            Console.WriteLine("+--------------------+");
            Console.WriteLine("DIGITE O PRIMEIRO LADO");
            Console.WriteLine("+--------------------+");
            Lado1 = float.Parse(Console.ReadLine());

            Console.WriteLine("+-------------------+");
            Console.WriteLine("DIGITE O SEGUNDO LADO");
            Console.WriteLine("+-------------------+");
            Lado2 = float.Parse(Console.ReadLine());

            Console.WriteLine("+--------------------+");
            Console.WriteLine("DIGITE O TERCEIRO LADO");
            Console.WriteLine("+--------------------+");
            Lado3 = float.Parse(Console.ReadLine());

            // ABAIXO É CONDICAO LOGICA PARA VERIFICAR SE E UM TRIANGULO
            if (Lado1 < Lado2 + Lado3 && Lado2 < Lado1 + Lado3 && Lado3 < Lado1 + Lado2)
            {

                Console.WriteLine("+----------------------+");
                Console.WriteLine("PODE FORMAR UM TRIANGULO: " + Triangulo);
                Console.WriteLine("+----------------------+");
            }

            //TRIANGULO EQUILATERO: TODOS OS LADOS SÃO IGUAIS
            if (Lado1 == Lado2 && Lado3 == Lado2)
            {
                Console.WriteLine("+--------------------+");
                Console.WriteLine("TRIANGULO E EQUILATERO: " + Equilatero);
            }

            //TRIANGULO ESCALENO: TODOS OS LADOS SÃO DIFERENTES
            if (Lado1 != Lado2 && Lado2 != Lado3 && Lado1 != Lado3)
            {
                Console.WriteLine("TRIANGULO E ESCALENO: " + Escaleno);
            }

            // TRINGULO ISOSCELES: APENAS DOIS LADOS SÃO IGUAIS
            if (Lado1 == Lado2 && Lado2 != Lado3 || Lado2 == Lado3 && Lado3 != Lado1 || Lado3 == Lado1 && Lado3 != Lado2)
            {
                Console.WriteLine("TRIANGULO E ESOSELES: " + Esoseles);
                Console.WriteLine("+----------------------------+");
            }
            else
            {
                Console.WriteLine("+--------------------------+");
                Console.WriteLine("NAO PODE FORMAR UM TRIANGULO");
                Console.WriteLine("+--------------------------+");
            }
        }
    }
}
