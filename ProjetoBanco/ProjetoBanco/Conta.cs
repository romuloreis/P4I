using System;

namespace ProjetoBanco { 

    public class Conta
    {
        //Declaração de variáveis
        public int numero;
        public Cliente titular;
        private double saldo;

        //Métodos da classe Conta
        public void Sacar() {
            if (this.saldo >= 50) {
                this.saldo -= 50;
            }
        }
        //Método com parâmetro
        public void SacarValor(double valor) {
            if (this.saldo >= valor) {
                this.saldo -= valor;
            }
        }
        //Método com retorno
        public bool SacarDinheiro(double valor) {
            //Se eu tiver saldo suficiente eu saco o valor
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }


        public bool Transferir(double valor, Conta destino) {
            /*Se eu conseguir sacar o valor da minha conta
            quer dizer que eu tinha saldo suficiente
            Então, adiciono esse valor no saldo da conta
            destino*/
            if (this.SacarDinheiro(valor)) {
                //destino.saldo += valor;
                destino.Depositar(valor);
                return true;
            }
            return false;
        }

        public void Depositar(double valor) {
            this.saldo += valor;
        }

        public double ConsultarSaldo() {
            return this.saldo;
        }
    }
}