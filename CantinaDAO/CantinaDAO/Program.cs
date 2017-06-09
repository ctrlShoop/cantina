using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaBD
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\";

            SQLiteConnection con =
                new SQLiteConnection("Data Source=" + path + "MyDatabase.sqlite;Version=3");
            con.Open();

            string sql = "CREATE TABLE T_PRODUTO "
              + "("
                + "CODIGO     INT PRIMARY KEY  NOT NULL,"
                + " NOME        CHAR(50), "
                + " PRECO            DOUBLE, "
                + " QUANTIDADE      INT"
              + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
            Console.ReadKey();

        }
    }
}
