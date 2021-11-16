using Projeto1.classes;
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
using Projeto1.classes.Inscrever;

namespace Projeto1.Formulario
{
    public partial class Inscrever : Form
    {
        public Inscrever()
        {
            InitializeComponent();
        }

        private void Inscrever_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inscreverbtn_Click(object sender, EventArgs e)
        {
        }
        private void ClearInputs()
        {
            nametxt.Text = "";
            lastNametxt.Text = "";
            cursotxt.Text = "";
            nBItxt.Text = "";
        }

        private void inscreverbtn_Click_1(object sender, EventArgs e)
        {
            var dialogChange = MessageBox.Show("Inscrever Candidatos", "Deseja inscrever este candidato?", MessageBoxButtons.OKCancel);
            if (dialogChange.Equals(DialogResult.OK))
            {
                ValidateData validate = new ValidateData();
                validate.ValidateStringEmpty(nametxt.Text, lastNametxt.Text, cursotxt.Text, idadeDUP.Text, sexoDUP.Text, nBItxt.Text);
                ClearInputs();
            }
        }
    }
}
