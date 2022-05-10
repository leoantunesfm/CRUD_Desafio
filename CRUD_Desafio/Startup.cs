using System;

namespace CRUD_Desafio
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|--------- Cadastro de Produtos ----------|");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine();

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

                Produto produto = new Produto(codigo, descricao, preco, qtestoque);
                Repository repository = new Repository();
                repository.CadastraProduto(produto);
            }
           

        }
    }
}
