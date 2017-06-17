using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina
{
    class Produto
    {
        private int codigo;
        private int quantidade;
        private double preco;
        private string nome;



        public int Codigo { get => codigo; set => codigo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }

        public Produto(int codigo, int quantidade, double preco, string nome)
        {
            this.codigo = codigo;
            this.quantidade = quantidade;
            this.preco = preco;
            this.nome = nome;
        }
    }
}
