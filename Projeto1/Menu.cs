using Projeto1.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        bool exist { get; set; }
        private void Menu_Load(object sender, EventArgs e)
        {
            DadosFuncionario dados = new DadosFuncionario();
            dados.Close();
            Form1 form1 = new Form1();
            form1.Close();
            if (File.Exists(@".\filefunc.txt")) this.exist = true;
        }

        private void Inscreverbtn_Click(object sender, EventArgs e)
        {
            Inscrever inscrever = new Inscrever();
            inscrever.Show();
        }
        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            if (exist)
            {
                Consultar consultar = new Consultar();
                consultar.Show();
            }
        }

        private void ListarBtn_Click(object sender, EventArgs e)
        {
            if (exist)
            {
                Listar listar = new Listar();
                listar.Show();
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (exist)
            {
                Eliminar eliminar = new Eliminar();
                eliminar.Show();
            }
        }

        private void EstatisticaBtn_Click(object sender, EventArgs e)
        {
            if (exist)
            {
                Estatistica estatistica = new Estatistica();
                estatistica.Show();
            }
        }

        private void AtualizarBtn_Click(object sender, EventArgs e)
        {
            if (exist)
            {
                Atualizar atualizar = new Atualizar();
                atualizar.Show();
            }
        }

        private void IntegrantesBtn_Click_1(object sender, EventArgs e)
        {
            Integrantes integrantes = new Integrantes();
            integrantes.Show();
        }
    }
}
