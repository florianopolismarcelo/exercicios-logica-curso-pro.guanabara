using System;

namespace _019___Aluno_aprovado_ou_reprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Nota1, Nota2, Media;

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("INFORME A PRIMEIRA NOTA DO ALUNO");
            Console.WriteLine("+------------------------------+");
            Nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("INFORME A SEGUNDA NOTA DO ALUNO5");
            Console.WriteLine("+------------------------------+");
            Nota2 = float.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2) / 2;

            if (Media >= 7 && Media <= 10)
            {
                Console.WriteLine("+----------------+");
                Console.WriteLine("ALUNO APROVADO " + Media);
                Console.WriteLine("+----------------+");
            }
            else if (Media >= 5 && Media < 7)
            {
                Console.WriteLine("+---------------------+");
                Console.WriteLine("ALUNO EM RECUPERACAO " + Media);
                Console.WriteLine("+---------------------+");
            }
            else
            {
                Console.WriteLine("+----------------+");
                Console.WriteLine("ALUNO REPROVADO " + Media);
                Console.WriteLine("+----------------+");
            }
        }
    }
}
