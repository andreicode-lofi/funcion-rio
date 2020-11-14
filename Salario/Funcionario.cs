using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Salario
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        public Funcionario(string nome, double salario, double imposto)
        {
            Nome = nome;
            Salario = salario;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
          return   Salario -= Imposto;
        }

        public void AumentarSalario(double imp)
        {
           Salario = Salario + (Salario * imp / 100.00);
        }

        public override string ToString()
        {
            return Nome + ", $ " +  
            SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture);
        }


    }
}
