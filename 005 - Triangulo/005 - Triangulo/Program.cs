using System;

namespace _005___Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Lado1, Lado2, Lado3;
            Boolean Triangulo, Equilatero, Escaleno, Esoseles;

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

            // ABAIXO É CONDICAO LOGICA PARA VERIFICAR SE É UM TRIANGULO
            Triangulo = (Lado1 < Lado2 + Lado3 && Lado2 < Lado1 + Lado3 && Lado3 < Lado1 + Lado2);

            Console.WriteLine("+----------------------------+");
            Console.WriteLine("PODE FORMAR UM TRIANGULO? " + Triangulo);

            //TRIANGULO EQUILATERO: TODOS OS LADOS SÃO IGUAIS
            Equilatero = (Lado1 == Lado2 && Lado2 == Lado3);
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("TRIANGULO E EQUILATERO: " + Equilatero);
            Console.WriteLine("+----------------------------+");


            //TRIANGULO ESCALENO: TODOS OS LADOS SÃO DIFERENTES
            Escaleno = (Lado1 != Lado2 && Lado2 != Lado3 && Lado1 != Lado3);


            Console.WriteLine("TRIANGULO E ESCALENO: " + Escaleno);
            Console.WriteLine("+----------------------------+");


            // TRINGULO ISOSCELES: APENAS DOIS LADOS SÃO IGUAIS
            Esoseles = (Lado1 == Lado2 && Lado2 != Lado3) || (Lado2 == Lado3 && Lado3 != Lado1) || (Lado3 == Lado1 && Lado3 != Lado2);
            Console.WriteLine("TRIANGULO E ESOSELES: " + Esoseles);
            Console.WriteLine("+----------------------------+");
        }
    }
}
