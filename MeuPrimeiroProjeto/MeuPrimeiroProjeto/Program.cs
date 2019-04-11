using System;

namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            double saldo;
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu saldo:");
            saldo = double.Parse(Console.ReadLine());
            if ((idade <= 10) && (saldo > 1000000))
            {
                Console.WriteLine("Criança Rica!");
            }
            else if((idade <= 10) && (saldo <= 1000000))
            {
                Console.WriteLine("Criança não Rica!");
            }

            while (saldo < 1000) {
                Console.WriteLine("saldo baixo!");
                Console.WriteLine("Digite seu saldo:");
                saldo = double.Parse(Console.ReadLine());
 
            }

            for (int i = 0; i < 3; i++) {
                Console.WriteLine("contador "+i);
            }

            ContaBancaria conta = new ContaBancaria();
            conta.nome = "Maria";
            conta.Deposito(500);
            conta.MeuSaldo();

        }
    }
}
