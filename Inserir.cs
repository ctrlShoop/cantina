using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIICantina
{
    public partial class Inserir : Form
    {
        private SQLiteConnection con;
        ProdutoDAO dao;

        //SQLiteConnection con;

        public Inserir()
        {
            InitializeComponent();
            
            
            
            
            

        }

        public void setConnection(SQLiteConnection con)
        {
            this.con = con;
            dao = new ProdutoDAO(con);
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
          // con = new SQLiteConnection("Data Source =/ path / to/ Projeto.sqlite");
            //con.Open();

            int cod = Convert.ToInt32(tbCod.Text);
            double preco = Convert.ToDouble(tbPreco.Text);
            string desc = Convert.ToString(tbDesc.Text);
            string img = Convert.ToString(tbImagem.Text);

            Produto insert = new Produto(cod, preco, desc, img);
           
                dao.insereProduto(insert);

                //SQLiteCommand command = new SQLiteCommand(sql.CommandText, con);
                //command.ExecuteNonQuery();

                MessageBox.Show("Produto inserido com sucesso");
            
           
           
               
        }

        private void lbRotulo_Click(object sender, EventArgs e)
        {

        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            tbCod.Text = ("");
            tbDesc.Text = ("");
            tbPreco.Text = ("");
            tbImagem.Text = ("");
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }
    }
}
