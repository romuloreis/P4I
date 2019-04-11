using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoHeranca
{
    //A palavra "sealed" indica que essa classe é FINAL, 
    //ou seja, nenhuma classe pode extender Tecnico
    sealed class Tecnico : Profissional
    {
        public string Funcao { get; set; }

        public Tecnico(string nome, string cpf, double salario, string funcao)
            :base(nome, cpf, salario) {

            Funcao = funcao;
        }

        //A palavra "override" indica que esse métodos esta
        //sobrescrevendo o método herdado
        public override void CalcularSalario() {
            double salarioTotal = (Salario * 120)*1.20;
            Console.WriteLine("Salário Total: " + salarioTotal);
        }

    }
}
