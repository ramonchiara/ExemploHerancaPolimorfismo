using System;

namespace ExemploHerancaPolimorfismo
{
    public class Gerente : Funcionario
    {
        private decimal bonus;

        public Gerente(string nome, decimal valor, double horas, decimal bonus)
            : base(nome, valor, horas)
        {
            this.bonus = bonus;
        }

        public override decimal GetSalario()
        {
            return base.GetSalario() + bonus;
        }

        public override string GetCargo() { return "gerente"; }
    }
}
