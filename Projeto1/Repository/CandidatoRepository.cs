using Projeto1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Repository
{
    public class CandidatoRepository
    {

        private const string path = @".\file.txt";

        private int Id { get; set; }
        public CandidatoRepository()
        {
             this.Id= this.GerarId();
        }
        public List<string> Listar()
        {
            StreamReader streamread = new StreamReader(path);
            List<string> candidatos1 = new List<string>();
            string candidatos = streamread.ReadToEnd();
            string[] Split = candidatos.Split(' ');
            streamread.Dispose();
            foreach(var item in Split)
            {
                candidatos1.Add(item.ToString());
            }

            return candidatos1;
        }
        public void Cadastrar(Candidato candidato)
        {
            try
            {
                StreamWriter ficheiro = new StreamWriter(path, true, Encoding.Default);
                candidato.id = this.Id;
                ficheiro.WriteLine(candidato.id + "-" + candidato.Nome
                    + ";" + candidato.LastName + ";" + candidato.curso + ";"
                    + candidato.idade + ";" + candidato.sexo
                    + ";" + candidato.numeroBI + " ");
                ficheiro.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao criar " + err, "Erro");
            }
        }
        public string Find(int id)
        {
            StreamReader streamread = new StreamReader(path);
            string text = streamread.ReadToEnd();
            streamread.Dispose();
            string[] split = text.Split(' ');
            return split.Length > id ? split[id-1].ToString(): "";
        }

        public void Delete(int id)
        {
            try
            {
                StreamReader streamread = new StreamReader(path);
                int cont = 0;
                string text = streamread.ReadToEnd();
                string[] split = text.Split(' ');
                streamread.Dispose();
                //split[id - 1].Replace(split[id - 1]," ");
                StreamWriter ficheiro = new StreamWriter(path, false, Encoding.Default);
                foreach (var item in split)
                {
                    if (id - 1 == cont)
                        ficheiro.Write("0 ");
                    else
                        ficheiro.Write(item+ " ");
                    cont++;
                }
                ficheiro.Dispose();
                MessageBox.Show("Candidato eliminado com sucesso", "Sucesso");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao eliminar " + err, "Erro");
            }

        }
        public string update(string candidato, Candidato candidato1)
        {
            StreamReader streamread = new StreamReader(path);
            int cont = 0;
            string text = streamread.ReadToEnd();
            string[] split = text.Split(' ');
            streamread.Dispose();
            StreamWriter ficheiro = new StreamWriter(path, false, Encoding.Default);
            foreach (var item in split)
            {
                if (item.Equals(candidato))
                {
                    candidato1.id = cont+1;
                    ficheiro.WriteLine(candidato1.id + "-" + candidato1.Nome
                        + ";" + candidato1.LastName + ";" + candidato1.curso + ";"
                        + candidato1.idade + ";" + candidato1.sexo
                        + ";" + candidato1.numeroBI + " ");
                }
                else
                    ficheiro.Write(item + " ");
                cont++;
            }
            ficheiro.Dispose();
            return candidato;
        }

        public int GerarId()
        {
            StreamReader streamread = new StreamReader(path);
            var textStream = streamread.ReadToEnd();
            string[] Split = textStream.Split(' ');
            streamread.Dispose();
            return Split.Length != 0 ? Split.Length : 0 ;
        }
    }
}
