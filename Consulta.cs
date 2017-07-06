using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIICantina
{
    public partial class Consulta : Form
    {
        private SQLiteConnection con;

        public Consulta()
        {
            InitializeComponent();
            string path = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\";
            con = new SQLiteConnection("Data Source=" + path + "cantina.sqlite;Version=3");
            //con = new SQLiteConnection("Data Source=" + path + "cantina.sqlite;Version=3");
            con.Open();
        }

        static void CriaTabelaCliente(SQLiteConnection con)
        {

            string sql = "CREATE TABLE IF NOT EXISTS T_CLIENTE "
                + "("
                + "IDCLIENTE       INT PRIMARY KEY NOT NULL,"
                + "NOME         VARCHAR(50) NOT NULL,"
                + "FUNCAO    VARCHAR(50) NOT NULL,"
                + "TELEFONE      VARCHAR(50) NOT NULL,"
                + "COMPRANOVA DOUBLE,"
                + "DIVIDAPENDENTE       DOUBLE"
                + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        static void CriaTabelaDivida(SQLiteConnection con)
        {

            string sql = "CREATE TABLE IF NOT EXISTS T_DIVIDA"
                + "("
                + "IDDIVIDA      INT PRIMARY KEY NOT NULL,"
                + "VALOR        DOUBLE,"
                + "IDCLIENTE    INT,"
                + "FOREIGN KEY(IDCLIENTE) REFERENCES T_CLIENTE(IDCLIENTE)"
                + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
        }
        
        public void AddValorATabela(SQLiteConnection con)
        {
            
            int c = Convert.ToInt32(tbCodigo.Text);
            double valCompra = 50.00;
            

            try
            {
                string sql = "UPDATE T_CLIENTE SET DIVIDAPENDENTE = DIVIDAPENDENTE +" + valCompra + " WHERE IDCLIENTE=" + c + "";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteReader();
                
            }
            catch (Exception QUE)
            {
                MessageBox.Show(QUE.ToString());
            }
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            int c;
            try
            {
                c = Convert.ToInt32(tbCodigo.Text);

                string sql2 = "SELECT DIVIDAPENDENTE FROM T_CLIENTE WHERE IDCLIENTE=" + tbCodigo.Text + "";
                SQLiteCommand command = new SQLiteCommand(sql2, con);
                
            
                SQLiteDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {    
                    tbDivida.Text = ("Dívida pendente = "+leitor[0].ToString());
                }  
            }
            catch (KeyNotFoundException naoSeiONome)
            {
                MessageBox.Show("Erro: " + naoSeiONome);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro (??) "+erro);
            }
        }

        private void tbDivida_TextChanged(object sender, EventArgs e)
        {
        }

        private void btEncerrarConsulta_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = (" ");
            tbDivida.Text = (" ");
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbRotulo_Click(object sender, EventArgs e)
        {
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE T_CLIENTE SET DIVIDAPENDENTE=0.00 WHERE IDCLIENTE=" + tbCodigo.Text + "";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Dívida paga com sucesso");
                tbCodigo.Text = ("");
                tbDivida.Text = ("");
            }
            catch (Exception)
            {

            }
        }
    }
}
