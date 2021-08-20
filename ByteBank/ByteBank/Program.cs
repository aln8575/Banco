using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
         static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";
            

            carlos.AumentarSalario();
            Console.WriteLine("Novo salario de carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "roberta";

            Console.WriteLine(roberta.CPF);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);   

            Funcionario robertaTeste = roberta;
            roberta.AumentarSalario();
            Console.WriteLine("Novo salario de roberta " + roberta.Salario);

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + carlos.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações " + gerenciador.GetTotalBoneficacao());

            Console.ReadLine();
        }
    }
}
