using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

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

        public void CadastraProduto()
        {
            Repository.SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO PRODUTO VALUES ('" + Codigo + "','" + Descricao + "'," + Preco.ToString("F2").Replace(',', '.') + "," + QtdEstoque + ")", Repository.SqlConnection);
            sqlCommand.ExecuteNonQuery();
            Repository.SqlConnection.Close();
        }

        public void SetPreco (double preco)
        {
            Preco = preco;
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
