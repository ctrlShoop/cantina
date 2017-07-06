using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIICantina
{
    public class Produto
    {
        //SQLiteConnection con;

        private int codigoProd;
        protected double preco;
        private string nome;
        private string imagem;

        public Produto(int codigoProd, double preco, string nome, string imagem)
        {
            this.codigoProd = codigoProd;
            this.preco = preco;
            this.nome = nome;
            this.imagem = imagem;
        }

        public Produto()
        {
        }

        public string retornaImagem()
        {
            return Environment.GetEnvironmentVariable("HOMEPATH") + "\\Desktop\\cantina\\imgCantina\\" + imagem;
        }


        public string Imagem
        {
            get
            {
                return imagem;
            }

            set
            {
                imagem = value;
            }
        }

        public int CodigoProd
        {
            get
            {
                return codigoProd;
            }

            set
            {
                codigoProd = value;
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
    }
}
