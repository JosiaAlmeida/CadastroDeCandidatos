using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Projeto1.Formulario;
using Projeto1.Repository;
using Projeto1.Model;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            FuncionarioRepository funcionario = new FuncionarioRepository();
            if (nomeTxt.Text.Length > 0
                && salarioTxt.Text.Length > 0
                && telefoneTxt.Text.Length > 0)
            {
                funcionario.Cadastrar(new Funcionario(nomeTxt.Text, salarioTxt.Text, telefoneTxt.Text, idadeDp.selectedValue));
                var dialog = MessageBox.Show("Deseja Ver Dados Do Funcionario?", "Notificação",MessageBoxButtons.YesNo);
                if (dialog.Equals(DialogResult.Yes))
                {
                    DadosFuncionario dadosFuncionario = new DadosFuncionario();
                    dadosFuncionario.Show();
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                }
            }
            else MessageBox.Show("Por favor, Preencha os espaços em branco", "Falha de login");
        }
    }
}
