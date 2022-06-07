using System;

namespace _007___Triangulo_com_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Lado1, Lado2, Lado3;
            int Numero;
            Boolean Equilatero = true, Isoseles = true, Escaleno = true;
            Console.WriteLine("+------------------------------------------+");
            Console.WriteLine("DIGITE 1 PARA FORMAR UM TRIANGULO EQUILATERO");
            Console.WriteLine("DIGITE 2 PARA FORMAR UM TRIANGULO ISOSELES");
            Console.WriteLine("DIGITE 3 PARA FORMAR UM TRIANGULO ESCALENO");
            Console.WriteLine("+------------------------------------------+");
            Numero = int.Parse(Console.ReadLine());

            switch (Numero)
            {
                case 1:
                    Console.WriteLine("+------------------------------------------------------------+");
                    Console.WriteLine("ATENÇÂO!!! O TRIANGULO EQUILATERO POSSUI TODOS OS LADOS IGUAIS");

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

                    if (Lado1 == Lado2 && Lado3 == Lado2)
                    {
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine("PARABENS O TRIANGULO E EQUILATERO: " + Equilatero);
                        Console.WriteLine("+---------------------------------+");
                    }
                    else
                    {
                        Console.WriteLine("+----------------------------------------------+");
                        Console.WriteLine("ERRADO!!! VOCE NAO DIGITOU TODOS OS LADOS IGUAIS");
                        Console.WriteLine("+----------------------------------------------+");
                        Console.WriteLine("LADO 1: " + Lado1);
                        Console.WriteLine("LADO 2: " + Lado2);
                        Console.WriteLine("LADO 3: " + Lado3);
                    }
                    break;
                case 2:
                    Console.WriteLine("+---------------------------------------------------------------------+");
                    Console.WriteLine("ATENÇÂO!!! O TRINGULO ISOSCELES POSSUI DOIS LADOS IGUAIS E UM DIFERENTE");

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

                    if (Lado1 == Lado2 && Lado2 != Lado3 || Lado2 == Lado3 && Lado3 != Lado1 || Lado3 == Lado1 && Lado3 != Lado2)
                    {
                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("PARABENS O TRIANGULO E ISOSELES: " + Isoseles);
                        Console.WriteLine("+-------------------------------+");
                    }
                    else
                    {
                        Console.WriteLine("+---------------------------------------------------------+");
                        Console.WriteLine("ERRADO!!! VOCE NAO DIGITOU DOIS LADOS IGUAIS E UM DIFERENTE");
                        Console.WriteLine("+---------------------------------------------------------+");
                        Console.WriteLine("LADO 1: " + Lado1);
                        Console.WriteLine("LADO 2: " + Lado2);
                        Console.WriteLine("LADO 3: " + Lado3);
                    }
                    break;
                case 3:
                    Console.WriteLine("+-----------------------------------------------------------+");
                    Console.WriteLine("ATENÇÂO!!! O TRIANGULO ESCALENO TODOS OS LADOS SAO DIFERENTES");

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

                    if (Lado1 != Lado2 && Lado2 != Lado3 && Lado1 != Lado3)
                    {
                        Console.WriteLine("+--------------------------------+");
                        Console.WriteLine("PARABENS! O TRIANGULO E ESCALENO: " + Escaleno);
                        Console.WriteLine("+--------------------------------+");
                    }
                    else
                    {
                        Console.WriteLine("+--------------------------------------------------+");
                        Console.WriteLine("ERRADO!!! VOCE NAO DIGITOU TODOS OS LADOS DIFERENTES");
                        Console.WriteLine("+--------------------------------------------------+");
                        Console.WriteLine("LADO 1: " + Lado1);
                        Console.WriteLine("LADO 2: " + Lado2);
                        Console.WriteLine("LADO 3: " + Lado3);

                    }
                    break;
            }
        }
    }
}
