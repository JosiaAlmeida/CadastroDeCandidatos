using Projeto1.Model;
using Projeto1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Formulario
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarBtn_Click(object sender, EventArgs e)
        {
        }

        private void ClearInputs()
        {
            nameTxt.Text = "";
            cursoTxt.Text = "";
            NumeroBiTxt.Text = "";
            IdadeTxt.Text = "";
            SexoTxt.Text = "";
        }
        //Metodo para atualizar
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            CandidatoRepository candidato = new CandidatoRepository();
            //Busca o candidato
            string Texto = candidato.Find(int.Parse(searchIdTxt.text));
            string[] fullName = nameTxt.Text.Split(' ');
            //Atualiza o candidato
            if (int.Parse(IdadeTxt.Text) >= 12 && int.Parse(IdadeTxt.Text) <= 20)
            {
                if (SexoTxt.Text.ToUpper().Equals("M")
                    || SexoTxt.Text.ToUpper().Equals("F"))
                    candidato.update(Texto, new Candidato(fullName[0], fullName[1],
                        cursoTxt.Text, SexoTxt.Text, NumeroBiTxt.Text, IdadeTxt.Text));
                else MessageBox.Show("Digite apenas F para feminino e M para Masculino", "Falha");
            }
            else MessageBox.Show("A idade deve estar entre os 12 a 20 anos", "Idade Invalida");
            this.ClearInputs();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            CandidatoRepository candidato = new CandidatoRepository();
            string Texto = candidato.Find(int.Parse(searchIdTxt.text));
            if (Texto != "" && Texto.Length != 0 && Texto != "0")
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
                MessageBox.Show("Candidato inexistente");
            }
        }
    }
}
