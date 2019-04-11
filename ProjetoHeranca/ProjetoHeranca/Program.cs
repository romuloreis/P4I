using System;

namespace ProjetoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor profA =
               new Professor("Pedro", "7643", 60, "Programação");
            Console.WriteLine("Nome profA: "+profA.Nome);
            profA.CalcularSalario();

            Tecnico tecA = new Tecnico("Maria", "8943", 60, "Zelador");
            Console.WriteLine("Nome profA: " + tecA.Nome);
            tecA.CalcularSalario();

        }
    }
}
