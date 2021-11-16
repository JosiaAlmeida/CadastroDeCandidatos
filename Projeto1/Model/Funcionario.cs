using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Model
{
    public class Funcionario
    {
        public Funcionario() { }
        public Funcionario(string nome, string salario, string telefone, string idade)
        {
            this.nome = nome;
            this.salario = salario;
            this.telefone = telefone;
            this.idade = idade;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string salario { get; set; }
        public string telefone { get; set; }
        public string idade { get; set; }

    }
}
