using Projeto1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Repository
{
    public class FuncionarioRepository
    {

        private const string path = @".\filefunc.txt";

        private int Id { get; set; }
        public FuncionarioRepository()
        {
            this.Id = this.GerarId();
        }
        public int GerarId()
        {
            if (File.Exists(path))
            {
                StreamReader streamread = new StreamReader(path);
                var textStream = streamread.ReadToEnd();
                string[] Split = textStream.Split(' ');
                streamread.Dispose();
                return Split.Length != 0 ? Split.Length : 0;
            }
            else
            {
                StreamWriter writer = new StreamWriter(path);
                writer.Dispose();
                return 0;
            }
        }
        public void Cadastrar(Funcionario funcionario)
        {
            try
            {
                StreamWriter ficheiro = new StreamWriter(path, true, Encoding.Default);
                funcionario.id = this.Id;
                ficheiro.WriteLine(funcionario.id + "-" + funcionario.nome
                    + ";" + funcionario.telefone + ";" + funcionario.salario + ";"
                    + funcionario.idade + " ");
                ficheiro.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao criar " + err, "Erro");
            }
        }
        public string ShowData()
        {
            StreamReader streamread = new StreamReader(path);
            string text = streamread.ReadToEnd();
            streamread.Dispose();
            string[] split = text.Split(' ');
            return split.Length >= this.Id-1 ? split[this.Id - 2].ToString() : "iNEXISTENTE";
        }
    }
}
