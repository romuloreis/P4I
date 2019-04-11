using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoHeranca
{
    class Profissional:Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Profissional(string nome, string cpf, double salario) {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }
        //A palavra "virtual" permite que esse método seja sobrescrito
        public virtual void CalcularSalario() {
            double salarioTotal = Salario * 120;
            Console.WriteLine("Salário Total: "+salarioTotal);
        }

        public void MostrarDados() {
            Console.WriteLine("nome :" 
                + this.Nome+"\nValor Hora: R$" + Salario);
        }

    }

    

}
