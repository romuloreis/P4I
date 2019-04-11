using System;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um novo Cliente
            Cliente clienteA = new Cliente();
            clienteA.nome = "Joel da Silva";
            clienteA.cpf = "376436";
            clienteA.rg = "732465";
            clienteA.endereco = "Rua das Flores, 123";

            //Criar objeto Conta
            Conta c1 = new Conta();
            //Acessar variáveis do objeto
            c1.numero = 001;
            c1.titular = clienteA;
            c1.Depositar(150);

            Console.WriteLine("Saldo c1: " + c1.ConsultarSaldo());

            //Acessando método
            c1.Sacar();
            Console.WriteLine("Saldo c1: " + c1.ConsultarSaldo());
            //Acessando método com parâmetro
            c1.SacarValor(15);
            Console.WriteLine("Saldo c1: " + c1.ConsultarSaldo());
            //Acessar método que retorna um valor
            //A variável "resultado" recebe o retorno do método
            bool resultado = c1.SacarDinheiro(500);

            if (resultado)
            {
                Console.WriteLine("Sucesso!");
            }
            else {
                Console.WriteLine("Sem Sucesso!");
            }

            if (c1.SacarDinheiro(50))
            {
                Console.WriteLine("Sucesso!");
            }
            else {
                Console.WriteLine("Sem Sucesso!");
            }

            Console.WriteLine("Saldo c1: " + c1.ConsultarSaldo());

            //Criando o segundo Cliente
            Cliente clienteB = new Cliente();
            clienteB.nome = "Maria do Bairro";
            clienteB.cpf = "99996";
            clienteB.rg = "77777";
            clienteB.endereco = "Rua das Árvores, 555";


            //Criando uma segunda conta
            Conta c2 = new Conta();
            //Atribuindo valores para os atributos da conta c2
            c2.numero = 002;
            c2.titular = clienteB;
            c2.Depositar(800);
            //Conta c2 transfere R$ 200,00 para a conta c1
            if (c2.Transferir(200, c1))
            {
                Console.WriteLine(" Transferindo grana! ");
            }
            else {
                Console.WriteLine(" Falha na transferência! ");
            }

            //Vericando saldos
          
            Console.WriteLine("Saldo do "+c1.titular.nome+": " + c1.ConsultarSaldo());
            Console.WriteLine("Saldo do " + c2.titular.nome + ": " + c2.ConsultarSaldo());

        }
    }
}
