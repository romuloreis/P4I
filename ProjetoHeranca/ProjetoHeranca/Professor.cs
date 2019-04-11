using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoHeranca
{
    class Professor : Profissional
    {
        public string Area { get; set; }

        public Professor(string nome, string cpf, 
            double salario, string area) 
            :base(nome, cpf, salario) {
            Area = area;
        }

        //A palavra "override" indica que esse métodos esta
        //sobrescrevendo o método herdado
        //Exemplo de como usar "base"
        //Por ser um método "sealed" selado, os filhos dessa
        //classe não poderão sobreescrever esse método
        public sealed override void CalcularSalario()
        {
            base.CalcularSalario();
            //Poderia chamar outras funções aqui
        }


        }


}
