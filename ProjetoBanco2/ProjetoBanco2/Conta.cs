using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco2
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente titular { get; set; }

        //Método Construtor padrão - vazio
        public Conta() { }

        //Método Construtor com parâmetros
        public Conta(int numero, double saldo, Cliente titular) {
            this.Numero = numero;
            this.Saldo = saldo;
            this.titular = titular;
        }

        public Conta(int numero, double saldo, string nome, string rg) {
            this.Numero = numero;
            this.Saldo = saldo;
            Cliente cliente = new Cliente(nome, rg);
            this.titular = cliente;
        }

        //Exemplo de sobrecarga de método
        public bool Sacar() {
            if (this.Saldo >= 5) {
                this.Saldo -= 5;
                return true;
            }
            return false;
        }
        //Exemplo de sobrecarga de método
        public bool Sacar(double valor) {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }



    }
}
