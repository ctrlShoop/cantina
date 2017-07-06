using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIICantina
{
    public class Funcionario
    {

        private int codigo;
        private string nome;
        private double divida;

        public Funcionario(int codigo, string nome, double divida)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.divida = divida;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
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

        public double Divida
        {
            get
            {
                return divida;
            }

            set
            {
                divida = value;
            }
        }
    }
}
