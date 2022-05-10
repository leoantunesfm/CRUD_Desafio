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
