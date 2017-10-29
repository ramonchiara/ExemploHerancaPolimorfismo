using System;

namespace ExemploHerancaPolimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Valor da Hora: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Horas Trabalhadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("É gerente (s/n)? ");
            string cargo = Console.ReadLine();

            Funcionario funcionario;
            if (cargo.ToLower() == "s")
            {
                Console.Write("Valor do Bônus: ");
                decimal bonus = decimal.Parse(Console.ReadLine());

                funcionario = new Gerente(nome, valor, horas, bonus);
            }
            else
            {
                funcionario = new Funcionario(nome, valor, horas);
            }

            Console.WriteLine("O {0} {1} trabalhou {2} horas por R$ {3:F2} e irá receber R$ {4:F2}",
                              funcionario.GetCargo(), funcionario.GetNome(),
                              funcionario.GetHoras(), funcionario.GetValor(), funcionario.GetSalario());
        }
    }
}
