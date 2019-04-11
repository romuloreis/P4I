using System;

namespace ProjetoAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instânciar objeto - construtor vazio*/
            Produto p1 = new Produto();
            //Implementa SET não padronizado
            //Foi criado um método público para
            //modificar o valor de _nome, que é
            //privado
            p1.SetNome("Havaianas");
            //O método SET de _descricao segue o 
            //padrão para Properties, note que a sintaxe
            //vai ser x = valor;
            p1.Descricao = "chinelos temáticos";
            //Método set em Java
            //Em Java ficaria como no trecho abaixo
            //p1.set_descricao("chinelo");
            p1.Codigo = 1234;
            p1.Valor = 50.00;
            Console.WriteLine("Dados do Produto p1: "+p1);

            /*Instânciar objeto - construtor com parâmetros*/
            Produto p2 = new Produto("ventilador", 
                "faz vento 220v", 536, 150.00);
            Console.WriteLine("Dados do Produto p2: " + p2);

            /*Instânciar objeto - construtor customizado*/
            Produto p3 = new Produto
            {
                Descricao = "Smartphone",
                Codigo = 324,
                Valor = 700.00
            };
            p3.SetNome("Moto G9");

            Console.WriteLine("Dados do Produto p3: " + p3);

            /*Instânciar objeto - construtor customizado*/
            Produto p4 = new Produto()
            {
                Descricao = "Smartphone",
                Codigo = 324,
                Valor = 700.00
            };
            p4.SetNome("Ventilador");
            Console.WriteLine("Dados do Produto p4: " + p4);
            //Não consigo acessar o método SET
            //da propriedade Marca, pois ele é
            //privado
            //p4.Marca = "Jequeti";
            Console.WriteLine("Marca: "+p4.Marca);

            /*Usando a classe Calculadora*/
            //Calculadora calc = new Calculadora();
            //double result = calc.CalcularTotal(p4, 5);
            double result = Calculadora.CalcularTotal(p4, 5);
            Console.WriteLine("Total: " + result);

            //Usando método estático para calcular raíz quadrada
            Console.WriteLine(Math.Sqrt(5));

            //Demonstrando atributo estático (Produto.Voltagem)
            Console.WriteLine("Atributo estático "+
                Produto.Voltagem);

            ProdutoConsumivel pc1 = new ProdutoConsumivel();
            pc1.DataValidade = "1 de abril de 2019";
            pc1.Codigo = 3246;
            pc1.Descricao = "Para beber";
            pc1.Valor = 3.50;
            pc1.SetNome("Cerveja Cristal");

            ProdutoConsumivel pc2 =
                new ProdutoConsumivel("dado beer", "bebida", 434, 3.60, 
                "3 de maio de 2019");

            Console.WriteLine("PC2: " + pc2 + " " + pc2.Descricao);
        }
    }
}
