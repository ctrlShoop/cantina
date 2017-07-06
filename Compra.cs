using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIICantina
{
    public class Compra: Produto
    {

        // Talvez teremos q fazer um método construtor nessa classe

        private int codigoCompra;
        private string nomeFunc;
        private string nomeProd;
        public int quantidade;
        private double valor;

        public int numCompra = 1;

        public double computarPreco()
        {
            return quantidade * preco;
        }

        public void retornaValor()
        {
            valor = computarPreco();
        }

        public int CodigoCompra
        {
            get
            {
                return codigoCompra;
            }

            set
            {
                codigoCompra = value;
            }
        }

        public string NomeFunc
        {
            get
            {
                return nomeFunc;
            }

            set
            {
                nomeFunc = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string NomeProd
        {
            get
            {
                return nomeProd;
            }

            set
            {
                nomeProd = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }
    }
}
