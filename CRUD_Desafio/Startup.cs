using System;
using System.Collections.Generic;

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

            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine(" 1 - Cadastrar um Produto ");
            Console.WriteLine(" 2 - Alterar um produto ");
            int opcao = int.Parse(Console.ReadLine());

            Produto produto = new Produto();
            List<Produto> lstprodutos = new List<Produto>();

            switch (opcao)
            {
                case 1:
                    Console.Write("Informe o código do produto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.Write("Informe a descrição do produto: ");
                    string descricao = Console.ReadLine();

                    produto = new Produto(codigo, descricao);
                    lstprodutos.Add(produto);

                    Console.WriteLine();
                    Console.WriteLine("Cadastre um novo produto:");
                    Console.Write("Informe o código do produto: ");
                    codigo = int.Parse(Console.ReadLine());
                    Console.Write("Informe a descrição do produto: ");
                    descricao = Console.ReadLine();

                    produto = new Produto(codigo, descricao);
                    lstprodutos.Add(produto);

                    break;

                case 2: Console.WriteLine("Opção 2");

                    break;
            }

            foreach(Produto p in lstprodutos)
            {
                Console.WriteLine(produto);
            }      


        }
    }
}
