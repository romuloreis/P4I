using System;

namespace ProjetoBanco2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando primeiro cliente
            Cliente clienteA = new Cliente();
            //Atribuindo valores às propriedades
            clienteA.Nome = "Joel Marinho";
            clienteA.Rg = "96857432";

            //Criando primeira Conta
            Conta contaA = new Conta();
            //Atribuindo valores às propriedades
            contaA.Numero = 001;
            contaA.Saldo = 0;
            contaA.titular = clienteA;

            Console.WriteLine("Dados da contaA:");
            Console.WriteLine("numero: "+contaA.Numero);
            Console.WriteLine("numero: " + contaA.titular.Nome);

            //Criando segundo Cliente e sua Conta
            Cliente clienteB = new Cliente("Gisele", "789543");
            Conta contaB = new Conta(002, 900, clienteB);

            Console.WriteLine("Dados da contaB:");
            Console.WriteLine("numero: " + contaB.Numero);
            Console.WriteLine("numero: " + contaB.titular.Nome);

            //Criando outro Cliente para mostrar
            //sobrecarga de método construtor
            Cliente clienteC = new Cliente("Fulaninho de Tal");

            //Demonstrando sobrecarga de método da classe Conta
            contaA.Sacar();
            contaB.Sacar(15);

            Console.WriteLine("Dados da contaA:");
            Console.WriteLine("numero: " + contaA.Numero);
            Console.WriteLine("numero: " + contaA.titular.Nome);

            Console.WriteLine("Dados da contaB:");
            Console.WriteLine("numero: " + contaB.Numero);
            Console.WriteLine("numero: " + contaB.titular.Nome);

            //Criando Conta com Cliente
            Conta contaC = new Conta(003, 4500, "Pedro", "857496");
            Console.WriteLine("Dados da contaC:");
            Console.WriteLine("numero: " + contaC.Numero);
            Console.WriteLine("numero: " + contaC.titular.Nome);
        }
    }
}
