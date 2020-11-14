using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario F = new Funcionario(nome, salario, imposto);

            Console.WriteLine("Funcionario: " + F);
            
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double imp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(imp);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionario atualizados: " + F);
        }
    }
}
