using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\";

            SQLiteConnection con;
            
            con = new SQLiteConnection("Data Source=" + path + "Cantina.sqlite;Version=3");

            con.Open();

            CriaTabelaProduto(con);
            CriaTabelaFunc(con);

            con.Close();
        }

        static void CriaTabelaProduto(SQLiteConnection con)
        {

            String sql = "CREATE TABLE T_PRODUTO "
              + "("
                + "CODIGO       INT PRIMARY KEY  NOT NULL,"
                + " NOME        VARCHAR(50), "
                + " PRECO       DOUBLE, "
                +"QUANTIDADE    INT"
              + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        static void CriaTabelaFunc(SQLiteConnection con)
        {

            String sql = "CREATE TABLE T_FUNC "
                + "("
                + "CODIGO       INT PRIMARY KEY NOT NULL,"
                + "NOME         VARCHAR(50),"
                + "PERIODO      ENUM('M','T','N')"
                + "PROFISSAO    VARCHAR(30),"
                + "DIVIDA       DOUBLE"
                + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }
    }
}
