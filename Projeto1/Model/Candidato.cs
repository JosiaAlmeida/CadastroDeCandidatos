using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Model
{
    public class Candidato
    {
        public Candidato(long id, string nome, string lastName, string curso, string sexo, string numeroBI, string idade)
        {
            this.id = id;
            Nome = nome;
            LastName = lastName;
            this.curso = curso;
            this.sexo = sexo;
            this.numeroBI = numeroBI;
            this.idade = idade;
        }
        public Candidato(string nome, string lastName, string curso, string sexo, string numeroBI, string idade)
        {
            Nome = nome;
            LastName = lastName;
            this.curso = curso;
            this.sexo = sexo;
            this.numeroBI = numeroBI;
            this.idade = idade;
        }
        public Candidato(string nome, string curso, string sexo, string numeroBI, string idade)
        {
            Nome = nome;
            this.curso = curso;
            this.sexo = sexo;
            this.numeroBI = numeroBI;
            this.idade = idade;
        }
        public Candidato()
        {

        }
        public long id { get; set; }
        public string Nome { get; set; }
        public string LastName { get; set; }
        public string curso { get; set; }
        public string sexo { get; set; }
        public string numeroBI { get; set; }
        public string idade { get; set; }
    }
}
