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

        public Produto() { }
        public Produto(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
        public Produto(int codigo, string descricao, double valor, int quantidade) : this (codigo, descricao)
        {
            this.SetPreco(valor);
            this.SetEstoque(quantidade);
        }

        public void SetPreco (double valor)
        {
            Preco = valor;
        }

        public void SetEstoque (int quantidade)
        {
            QtdEstoque = quantidade;
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
