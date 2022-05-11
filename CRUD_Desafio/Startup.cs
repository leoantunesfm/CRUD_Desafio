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
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Cadastrar um novo produto");
            Console.WriteLine("2 - Listar todos os produtos");
            Console.WriteLine("0 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                switch (opcao)
                {
                    case 1:
                        Produto.CadastraProduto();
                        break;
                    case 2:
                        Console.WriteLine("Ainda num tem");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Cadastrar um novo produto");
                Console.WriteLine("2 - Listar todos os produtos");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fim");

        }
    }
}
