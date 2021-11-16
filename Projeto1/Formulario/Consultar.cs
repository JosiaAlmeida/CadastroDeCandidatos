using Projeto1.Repository;
using System;
using System.Windows.Forms;

namespace Projeto1.Formulario
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CandidatoRepository candidato = new CandidatoRepository();
            string Texto = candidato.Find(int.Parse(searchIdTxt.text));
            if (Texto != "" && Texto.Length != 0 && Texto!="0")
            {
                string strings = Texto.Replace(":", " ")
                .Replace(";", " ")
                .Replace("-", " ")
                .Replace(",", " ");
                string[] Split = strings.Split(' ');
                nameTxt.Text = Split[1] + " " + Split[2];
                cursoTxt.Text = Split[3];
                IdadeTxt.Text = Split[4];
                SexoTxt.Text = Split[5];
                NumeroBiTxt.Text = Split[6];
            }
            else
            {
                MessageBox.Show("Candidato inexistente","Pesquisa");
            }
        }
    }
}
