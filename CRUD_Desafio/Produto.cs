using System;

namespace CRUD_Desafio
{
    class Produto
    {
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public int QtdEstoque { get; private set; }

        public Produto() { }
        public Produto(string codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
        public Produto(string codigo, string descricao, double preco, int quantidade) : this (codigo, descricao)
        {
            this.SetPreco(preco);
            this.SetEstoque(quantidade);
        }

        public void SetPreco (double preco)
        {
            Preco = preco;
        }

        public void SetEstoque (int quantidade)
        {
            QtdEstoque = quantidade;
        }

        public static void CadastraProduto()
        {
            Console.Write("Informe a quantidade de produtos que serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Informe os dados do {i}º produto:");
                Console.Write("Informe o código do produto: ");
                string codigo = Console.ReadLine();
                Console.Write("Informe a descrição do produto: ");
                string descricao = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Informe a Quantidade em estoque do produto: ");
                int qtestoque = int.Parse(Console.ReadLine());

                Repository repository = new Repository();
                repository.InsertProduto(new Produto(codigo, descricao, preco, qtestoque));
            }
        }

        public override string ToString()
        {
            return Codigo
                + " - "
                + Descricao
                + " - Valor: "
                + Preco.ToString("F2")
                + " - Estoque: "
                + QtdEstoque;
        }
    }
}
