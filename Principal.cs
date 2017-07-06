using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace ProjetoIICantina
{
    public partial class FrameMercado : Form
    {
        List<Listas> listaCompras = new List<Listas>();
        Listas listas;

        Dictionary<int, Produto> listaProdutos = new Dictionary<int, Produto>();
        Compra c = new Compra();
        Produto p;
        ProdutoDAO dao;
        Consulta consulta;
        private SQLiteConnection con;
        //Thread t;
        //FrameMercado fm;

        class Listas

        {
            int cod;
            string nome;
            int quant;
            double preco;

            public Listas(int cod, string nome, int quant, double preco)
            {
                this.cod = cod;
                this.nome = nome;
                this.quant = quant;
                this.preco = preco;
            }

            public int Cod
            {
                get
                {
                    return cod;
                }

                set
                {
                    cod = value;
                }
            }

            public string Nome
            {
                get
                {
                    return nome;
                }

                set
                {
                    nome = value;
                }
            }

            public int Quant
            {
                get
                {
                    return quant;
                }

                set
                {
                    quant = value;
                }
            }

            public double Preco
            {
                get
                {
                    return preco;
                }

                set
                {
                    preco = value;
                }
            }
        }



        public FrameMercado()
        {
            InitializeComponent();
           

           
            string path = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\";

            con = new SQLiteConnection("Data Source=" + path + "cantina.sqlite;Version=3");

            /*SQLiteCommand command = new SQLiteCommand(sql,con);
            SQLiteDataReader leitor = command.ExecuteReader();*/


            con.Open();

            CriaTabelaProduto(con);
            //CriaTabelaCliente(con);
            //CriaTabelaDivida(con);
            CriaTabelaCompra(con);
            //ProdutoDAO dao = new ProdutoDAO(con);
            //Produto batata = new Produto(1, 5.00, "Batata Ruffles", "batata.jpg");
            //dao.insereProduto(batata);
 
            //con.Close();

            //int contar = 0;
            //string linha;

            //No momento percorre o csv, a adiciona a listaProdutos todos os atributos q estão na lista.csv OBS: aparentemente não está funcionando, provavelmente um erro básico

           /* string caminhoDesktop = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\";
            System.IO.StreamReader file =
                  new System.IO.StreamReader(caminhoDesktop + "\\Cantina.sqlite");*/

            //listaProdutos = con.Query<int, Produto>(sql, new { }).ToDictionary();
             /*var dict = con.(int, Produto).ToDictionary(
                row => (string)row.UniqueString,
                row => (int)row.Id);*/
               

            /*while ((linha = file.ReadLine()) != null)
            {

                string[] l = linha.Split(',');
                int codProduto = Convert.ToInt32(l[0]);
                string nomeProduto = l[1];
                double preco = Convert.ToDouble(l[2]);
                string imagem = l[3];

                listaProdutos.Add(codProduto, new Produto(codProduto, preco, nomeProduto, imagem));

                contar++;
            }

            file.Close();*/
        }


        static void CriaTabelaProduto(SQLiteConnection con)
        {

            string sql = "CREATE TABLE IF NOT EXISTS T_PRODUTO "
              + "("
                + "IDPRODUTO       INT PRIMARY KEY,"
                + " PRECO      DECIMAL,"
                + " DESCRICAO          VARCHAR(50),"
                + " IMAGEM          VARCHAR(50)"
              + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
        }

        /*static void CriaTabelaCliente(SQLiteConnection con)
        {

            string sql = "CREATE TABLE IF NOT EXISTS T_CLIENTE "
                + "("
                + "IDCLIENTE       INT PRIMARY KEY NOT NULL,"
                + "NOME         VARCHAR(50) NOT NULL,"
                + "FUNCAO    VARCHAR(50) NOT NULL,"
                + "TELEFONE      VARCHAR(50) NOT NULL,"
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

        }*/

        static void CriaTabelaCompra(SQLiteConnection con)
        {

            string sql = "CREATE TABLE IF NOT EXISTS T_COMPRA"
                + "("
                + "IDCOMPRA        INT PRIMARY KEY UNIQUE,"
                + "DATACOMPRA      DATE,"
                + "VALORCOMPRA     DOUBLE"
                + ")";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

        }



        private void btFinalizaCompra_Click(object sender, EventArgs e)
        {
            dao = new ProdutoDAO(con);
            consulta = new Consulta();
            
            string cod = tbCodigo.Text;
            string qtde = tbQtde.Text;
            string prod = lbProduto.Text;
            string pre = lbPreco.Text;
            c.numCompra += 1;

            tbNotinha.Text = ("");
            tbQtde.Text = ("");
            lbProduto.Text = ("");
            lbPreco.Text = ("");
            

            String nome = c.numCompra + " - " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt";

            try
            {
                Stream saida = File.Open(nome, FileMode.Create);
                StreamWriter escritor = new StreamWriter(saida);
                escritor.WriteLine("+=======================================================+");
                escritor.WriteLine("|			Cantina FIEC			|");
                escritor.WriteLine("+=======================================================+");
                escritor.WriteLine("|			  Endereço                      |");
                escritor.WriteLine("|FIEC  I: Av Eng. Fábio R. Barnabé, 3405 - Jd. Esplanada|");
                escritor.WriteLine("|FIEC II: Rua Alberto Santos Dumont, 1849 - Cidade Nova |");
                escritor.WriteLine("|			Indaiatuba/SP			|");
                escritor.WriteLine("+==========|===============|==================|=========+");
                escritor.WriteLine("|  Codigo  |    Produto    |    Quantidade    |  Preco  |");
                foreach (var compra in listaCompras)
                {

                    escritor.WriteLine("|   " + compra.Cod + "    |    " + compra.Nome + "   |        " + compra.Quant + "         | " + compra.Preco + " |" + "\r\n");

                }
                escritor.WriteLine("+=======================================================+");
                foreach (var compra in listaCompras)
                {
                    double valort = compra.Preco;
                    double total =+ valort;

                }
                consulta.ValCompra = total;
                escritor.WriteLine("|                    Total                   |" + total + "");
                escritor.WriteLine("+=======================================================+");
                escritor.WriteLine("|Data da compra			     " + DateTime.Now + "|");
                escritor.WriteLine("+=======================================================+");
                escritor.WriteLine("|             A FIEC agradece a preferência             |");
                escritor.WriteLine("+=======================================================+");
                escritor.Close();
                saida.Close();
            }
            catch (IOException erro)
            {
                Console.WriteLine("Erro ocorrido: " + erro.ToString());
            }

            Process.Start(nome);
        }



        private void tbNotinha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrameMercado_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdcConta_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }



    private void btConfirmaProduto_Click(object sender, EventArgs e)
        {

            try {
                int cod = Convert.ToInt32(tbCodigo.Text);
                string nome = lbProduto.Text;
                int quant = Convert.ToInt32(tbQtde.Text);
                string preco = lbPreco.Text;

                tbNotinha.Text = "Codig:  " + cod + "\r\n" + "Nome: " + nome + "\r\n" + "Quant: " + quant + "\r\n" + "Preço: " + preco;

                tbCodigo.Text = ("");
                tbQtde.Text = ("");
                lbProduto.Text = ("--");
                lbPreco.Text = ("--");
                Console.Beep(2500, 50);
                pbImagemProduto.BackgroundImage = null;

                /*listaCompras.add(cod, nome, quant, preco);         <<lista de compras ERRO<<   
                /listBox1.DataSource = listaCompras;*/                  

            }
            catch (FormatException)
            {
                MessageBox.Show("Código e quantidade devem ser inseridos de maneira correta");
            }
        }

        private void btInsereProd_Click(object sender, EventArgs e)
        {
            Inserir i = new Inserir();
            i.setConnection(con);
            i.Show();


        }

        private void btRelatorioVenda_Click(object sender, EventArgs e)
        {
            RelatorioVenda r = new RelatorioVenda();
            r.setConnection(con);
            r.Show();
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProduto_Click(object sender, EventArgs e)
        {
            //Ao digitar o código referente no tbCodigo, aparecerá o nome do Produto, para isso temos q puxar de um dicionario o nome valor referente a chave int (no caso o código do produto)

            
            

            try
            {
                int i = Convert.ToInt32(tbCodigo.Text);
                string sql = "SELECT descricao FROM T_PRODUTO where idproduto=" + i + "";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                SQLiteDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    Console.WriteLine(leitor);
                    lbProduto.Text =(leitor[0].ToString());
              
                }
          
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Código não encontrado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Só inteiros são permitidos em Código");
            }
            //leitor.Close();

        }

        private void lbPreco_Click(object sender, EventArgs e)
        {
            
           // double valor = Convert.ToDouble(leitor);
           // double preco = valor*qtde;
            try
            {
                int i = Convert.ToInt32(tbCodigo.Text);
                int qtde = Convert.ToInt32(tbQtde.Text);
                string sql = "SELECT preco *" + qtde + " from T_PRODUTO where idproduto=" + i + "";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                SQLiteDataReader leitor = command.ExecuteReader();

                while (leitor.Read())
                {
                   // Console.WriteLine(leitor);

                    lbPreco.Text =(/*"R$: "+*/""+Convert.ToDouble(leitor[0].ToString()));

                }

            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Código não encontrado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Só inteiros são permitidos em Código");
            }
           //leitor.Close();



        }

        private void pbImagemProduto_Click(object sender, EventArgs e)
        {
           
            try
            {
                p = new Produto();

                int i = Convert.ToInt32(tbCodigo.Text);
                string sql = "SELECT imagem FROM T_PRODUTO where idproduto="+i+"";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                SQLiteDataReader leitor = command.ExecuteReader();



               
                while (leitor.Read())
                {
                    //if(leitor[0]=)

                 
                    p.Imagem = leitor[0].ToString();
                    
                    Bitmap minhaImagem = new Bitmap(p.retornaImagem());
                    pbImagemProduto.BackgroundImage = minhaImagem;
                    //pbImagemProduto.BackgroundImage = (leitor[0].ToString());
                }

            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Código não encontrado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Só inteiros são permitidos em Código");
            }
            //leitor.Close();


        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

