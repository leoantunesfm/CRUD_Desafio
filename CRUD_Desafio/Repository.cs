using System;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Desafio
{
    class Repository : IDisposable
    {
        private string _connectionStrings = @"Data Source=LAPTOP-387NSB75;Initial Catalog=CRUD;User Id=sa;Password=Abc123;";
        //private string _connectionStrings = @"Data Source=LEANDRO-DELLG3;Initial Catalog=DESAFIO;User Id=usr_adm;Password=Abc123;";
        private SqlConnection _sqlConnection = null;

        public Repository()
        {
            _sqlConnection = new SqlConnection(_connectionStrings);
            _sqlConnection.Open();
        }

        public void CadastraProduto(Produto produto)
        {
            using (Repository repository = new Repository())
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO PRODUTO VALUES ('" + produto.Codigo + "','" + produto.Descricao + "'," + produto.Preco.ToString("F2").Replace(',', '.') + "," + produto.QtdEstoque + ")", _sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            if (_sqlConnection != null)
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }
    }
}

