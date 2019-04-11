using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco2
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }

        //Método Construtor
        public Cliente(string nome, string rg) {
            this.Nome = nome;
            this.Rg = rg;
        }
        //Método Contrustor padrão
        public Cliente() { }

        //Exemplo de sobrecarga de método construtor
        public Cliente(string nome)
        {
            this.Nome = nome;
            this.Rg = "00000";
        }
    }
}
