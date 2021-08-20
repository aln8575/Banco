using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Funcionario

    {

        public static int TotalDeFuncionarios { get; private set;}

        public string Nome { get; set ; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            salario = salario;

            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
           // Salario = Salario + (Salario * 0.1);
           // Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        public virtual double GetObterBonificacao()
        {
            return Salario * 0.10;
        }
                                                          
    }
}
