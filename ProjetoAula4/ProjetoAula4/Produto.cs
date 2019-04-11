using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula4
{
    class Produto
    {
        /*Atributo estático, vai ser o mesmo para
         todas as instâncias, é um valor da classe*/
        public static string Voltagem = "Bivolt";

        /*Propriedade que permite apenas leitura*/
        public string Marca { get; private set; }

        /*TODO atributo privado (private) segue o seguinte
         padrão de nomeclatura*/
        /*nome inicia com _ (underline), seguido 
         de letra minuscula*/
        private string _nome;

        /*propriedades autoimplmentadas*/
        public int Codigo { get; set; }

        public double Valor;

        /*Atributo da Propriety privado*/
        private string _descricao;
        
        /*Propriety com set customizado*/
        public string Descricao {
            get {
                return _descricao;
            }
            set {
                if (value != null && value.Length > 2) {
                    _descricao = value;
                }
            }
        }

        /*Exemplo de SET personalizado (feito na mão)*/
        /*public void SetDescricao(string desc) {
            if(desc != null && desc.Length > 2) { 
                _descricao = desc;
            }
        }*/


        /*usa-se a palavra chave OVERRIDE, pois esse 
         * método já é implementado pela clase Object*/
        public override string ToString()
        {
            return _nome + " R$ " + Valor;
        }

        public Produto(string nome, string 
            descricao, int codigo, double valor)
        {
            this.Marca = "PEREIRA";
            this._nome = nome;
            this._descricao = descricao;
            this.Codigo = codigo;
            this.Valor = valor;
        }

        public Produto() {
            this.Marca = "PEREIRA";
        }

        /*Criando meu método de acesso GET
         da propriedade _nome*/
        public string GetNome() {
            return _nome;
        }

        /*Criando meu método de acesso SET
         da propriedade _nome*/
        public void SetNome(string nome) {
            _nome = nome;
        }

    }
}
