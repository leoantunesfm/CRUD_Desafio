using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Desafio
{
    class Produto
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public int QtdEstoque { get; private set; }

        public Produto(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public void SetPreco (double valor)
        {
            Preco = valor;
        }
    }
}
