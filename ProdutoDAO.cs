using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina
{
    class ProdutoDAO
    {
        SQLiteConnection con;

        public ProdutoDAO(SQLiteConnection con)
        {
            this.con = con;
        }

        public void insereProduto(Produto produto)
        {
            string sql = "INSERT INTO T_PRODUTO" +
                          "(CODIGO,NOME,PRECO,QUANTIDADE) VALUES(" + produto.Codigo + ",'" + produto.Nome + "',"
                            + produto.Preco + "," + produto.Quantidade + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void modificaProduto(Produto produto)
        {
            string sql = "UPDATE T_PRODUTO SET SET NOME='" + produto.Nome + "',"
                          + "PRECO=" + produto.Preco + ","+"QUANTIDADE=" + produto.Quantidade;

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void excluiProduto(Produto produto)
        {
            string sql = "DELETE FROM T_PRODUTO WHERE CODIGO=" + produto.Codigo;

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

    }
}
