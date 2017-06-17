using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCantina
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private string profissao;
        private double divida;
        private char periodo;

        public Funcionario(int codigo, string nome, string profissao, double divida, char periodo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.profissao = profissao;
            this.divida = divida;
            this.periodo = periodo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Profissao { get => profissao; set => profissao = value; }
        public double Divida { get => divida; set => divida = value; }
        public char Periodo { get => periodo; set => periodo = value; }
    }
}
