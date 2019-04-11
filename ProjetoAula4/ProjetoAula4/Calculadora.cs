using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula4
{
    /*Classe estática - pode ser acessada,
     sem ter uma instância*/
    static class Calculadora
    {
        public static double pi = 3.14;

        public static double CalcularTotal(
            Produto produto, int quantidade) {
            return produto.Valor * quantidade;
        }
    }
}
