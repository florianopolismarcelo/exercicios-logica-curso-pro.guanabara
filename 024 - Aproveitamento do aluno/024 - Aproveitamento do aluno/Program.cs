using System;

namespace _024___Aproveitamento_do_aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Nota1, Nota2, Media;
            string Nome;

            Console.WriteLine("+--------------------+");
            Console.WriteLine("DIGITE O NOME DO ALUNO");
            Console.WriteLine("+--------------------+");
            Nome = Console.ReadLine();

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("DIGITE A PRIMEIRA NOTA DO ALUNO");
            Console.WriteLine("+-----------------------------+");
            Nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("+----------------------------+");
            Console.WriteLine("DIGITE A SEGUNDA NOTA DO ALUNO");
            Console.WriteLine("+----------------------------+");
            Nota2 = float.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2) / 2;
            switch (Media)

            {

                case var _ when (Media >= 9 && Media <= 10):
                    Console.WriteLine("+------------------------------+");
                    Console.WriteLine("ALUNO: " + Nome);
                    Console.WriteLine("                                ");
                    Console.WriteLine("NOTA: " + Media + " COM APROVEITAMENTO A");
                    Console.WriteLine("+------------------------------+");
                    break;

                case var _ when (Media >= 8 && Media < 9):
                    Console.WriteLine("+------------------------------+");
                    Console.WriteLine("ALUNO: " + Nome);
                    Console.WriteLine("                                ");
                    Console.WriteLine("NOTA: " + Media + " COM APROVEITAMENTO B");
                    Console.WriteLine("+------------------------------+");
                    break;

                case var _ when (Media >= 7 && Media < 8):
                    Console.WriteLine("+------------------------------+");
                    Console.WriteLine("ALUNO: " + Nome);
                    Console.WriteLine("                                ");
                    Console.WriteLine("NOTA: " + Media + " COM APROVEITAMENTO C");
                    Console.WriteLine("+------------------------------+");
                    break;

                case var _ when (Media >= 6 && Media < 7):
                    Console.WriteLine("+------------------------------+");
                    Console.WriteLine("ALUNO: " + Nome);
                    Console.WriteLine("                                ");
                    Console.WriteLine("NOTA: " + Media + " COM APROVEITAMENTO D");
                    Console.WriteLine("+------------------------------+");
                    break;

                case var _ when (Media >= 5 && Media < 6):
                    Console.WriteLine("+------------------------------+");
                    Console.WriteLine("ALUNO: " + Nome);
                    Console.WriteLine("                                ");
                    Console.WriteLine("NOTA: " + Media + " COM APROVEITAMENTO E");
                    Console.WriteLine("+------------------------------+");
                    break;

                case var _ when (Media < 5):
                    Console.WriteLine("+------------------------------+");
                    Console.WriteLine("ALUNO: " + Nome);
                    Console.WriteLine("                                ");
                    Console.WriteLine("NOTA: " + Media + " COM APROVEITAMENTO F");
                    Console.WriteLine("+------------------------------+");
                    break;
            }
        }
    }
}
