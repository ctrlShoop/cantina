using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIICantina
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
            string sql = "INSERT INTO T_PRODUTO" +" VALUES(" + produto.CodigoProd + ",'" + produto.Preco + "','"
                            + produto.Nome+"','"+produto.Imagem+"')";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void modificaProduto(Produto produto)
        {
            string sql = "UPDATE T_PRODUTO SET DESCRICAO='" + produto.Nome + "',"
                          + "PRECO=" + produto.Preco + ","
                          + "WHERE IDPRODUTO=" + produto.CodigoProd;

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void excluiProduto(Produto produto)
        {
            string sql = "DELETE FROM T_PRODUTO WHERE IDPRODUTO=" + produto.CodigoProd;

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void insereCompra(Compra compra)
        {
            string sql = "INSERT INTO T_COMPRA VALUES(" + compra.numCompra + "," + compra.Valor + ")";

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        /*  public void getImagem(Produto produto)
          {
              FrameMercado fm = new FrameMercado();

              string sql ="SELECT imagem FROM T_PRODUTO WHERE IDPRODUTO="+fm.tb
          }*/

    }
}
