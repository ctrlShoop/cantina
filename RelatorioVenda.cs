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
    public partial class RelatorioVenda : Form
    {
        private SQLiteConnection con;
        ProdutoDAO dao;



        public RelatorioVenda()
        {
            InitializeComponent();
        }
        public void setConnection(SQLiteConnection con)
        {
            this.con = con;
            dao = new ProdutoDAO(con);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RelatorioVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
