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

namespace Projeto1
{
    public partial class DadosFuncionario : Form
    {
        public DadosFuncionario()
        {
            InitializeComponent();
        }

        private void DadosFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            string DataS = funcionarioRepository.ShowData();
            string SubData = DataS.Replace("-", " ")
                .Replace(";", " ");
            string[] MainData = SubData.Split(' ');
            //nameTxt.Text = DataS.ToString();
            nameTxt.Text = MainData[1];
            salarioTxt.Text = MainData[2];
            telefoneTxt.Text = MainData[3];
            IdadeTxt.Text = MainData[4];

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
