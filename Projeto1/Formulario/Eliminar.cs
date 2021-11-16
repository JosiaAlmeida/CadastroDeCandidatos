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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
        }

        private void IdDeleteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {
            CandidatoRepository candidato = new CandidatoRepository();
            candidato.Delete(int.Parse(IdDeleteTxt.text));
        }
    }
}
