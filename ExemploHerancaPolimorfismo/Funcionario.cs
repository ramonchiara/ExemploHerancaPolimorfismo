using System;

namespace ExemploHerancaPolimorfismo
{
    public class Funcionario
    {
        private string nome;
        private decimal valor;
        private double horas;

        public Funcionario(string nome, decimal valor, double horas)
        {
            this.nome = nome;
            this.valor = valor;
            this.horas = horas;
        }

        public string GetNome() { return nome; }

        public decimal GetValor() { return valor; }

        public double GetHoras() { return horas; }

        public virtual decimal GetSalario()
        {
            return Convert.ToDecimal(horas) * valor;
        }

        public virtual string GetCargo() { return "funcionário"; }
    }
}
