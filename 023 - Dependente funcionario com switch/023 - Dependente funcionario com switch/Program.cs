using System;

namespace _023___Dependente_funcionario_com_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dependente;
            float Salario, NovoSalario;
            string Funcionario;

            Console.WriteLine("+------------------------+");
            Console.WriteLine("QUAL O NOME DO FUNCIONARIO");
            Console.WriteLine("+------------------------+");
            Funcionario = Console.ReadLine();

            Console.WriteLine("+---------------------------+");
            Console.WriteLine("QUAL O SALARIO DO FUNCIONARIO");
            Console.WriteLine("+---------------------------+");
            Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("QUAL A QUANTIDADE DE DEPENDENTE");
            Console.WriteLine("+-----------------------------+");
            Dependente = int.Parse(Console.ReadLine());


            switch (Dependente)

            {
                case var _ when Dependente == 0:
                    NovoSalario = Salario + (Salario * 5) / 100; //
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("                FUNCIONARIO                  ");
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("NOME: [" + Funcionario + "] ");
                    Console.WriteLine("NOVO SALARIO: R$" + NovoSalario);
                    Console.WriteLine("+-------------------------------------------+");
                    break;

                case var _ when (Dependente >= 1 && Dependente <= 3): //

                    NovoSalario = Salario + (Salario * 10) / 100;
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("                FUNCIONARIO                  ");
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("NOME: [" + Funcionario + "] ");
                    Console.WriteLine("NOVO SALARIO: R$" + NovoSalario);
                    Console.WriteLine("+-------------------------------------------+");
                    break;
                case var _ when (Dependente >= 4 && Dependente <= 6):

                    NovoSalario = Salario + (Salario * 15) / 100;
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("                FUNCIONARIO                  ");
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("NOME: [" + Funcionario + "] ");
                    Console.WriteLine("NOVO SALARIO: R$" + NovoSalario);
                    Console.WriteLine("+-------------------------------------------+");
                    break;

                default:
                    NovoSalario = Salario + (Salario * 18) / 100;
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("                FUNCIONARIO                  ");
                    Console.WriteLine("+-------------------------------------------+");
                    Console.WriteLine("NOME: [" + Funcionario + "] ");
                    Console.WriteLine("NOVO SALARIO: R$" + NovoSalario);
                    Console.WriteLine("+-------------------------------------------+");
                    break;
            }
        }
    }
}
