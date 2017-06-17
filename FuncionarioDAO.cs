using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina
{
    class FuncionarioDAO
    {
        SQLiteConnection con;

        public FuncionarioDAO(SQLiteConnection con)
        {
            this.con = con;
        }

        public void insereFunc(Funcionario func)
        {

            string sql = "INSERT INTO T_FUNC" +
                        "(CODIGO,NOME,PERIODO,PROFISSAO,DIVIDA) VALUES(" + func.Codigo + ",'" + func.Nome + "','" + func.Periodo
                        + "','" + func.Profissao + "'," + func.Divida + ")";

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

        }

        public void modificaFunc(Funcionario func)
        {
            string sql = "UPDATE T_PRODUTO SET SET NOME='" + func.Nome + "',"
                          + "PERIODO='" + func.Periodo + "'," + "PROFISSAO='" + func.Profissao + "'"
                          + "," + "DIVIDA=" + func.Divida;

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        public void excluiFunc(Funcionario func)
        {
            string sql = "DELETE FROM T_PRODUTO WHERE ID=" + func.Codigo;

            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }



    }
}
