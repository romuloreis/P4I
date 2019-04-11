using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula4
{
    class ProdutoConsumivel : Produto
    {
        /*Propriedade exclusiva da classe 
         * ProdutoConsumivel*/
        public string DataValidade { get; set; }

        public ProdutoConsumivel() {}

        public ProdutoConsumivel(string nome, string
            descricao, int codigo, double valor, string data)
            :base(nome, descricao, codigo, valor) {
            /*DataValidade recebe valor passado por parâmetro*/
            DataValidade = data;
        }

    }
}
