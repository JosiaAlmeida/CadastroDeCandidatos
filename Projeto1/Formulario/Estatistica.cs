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
    public partial class Estatistica : Form
    {
        int TotalHomem = 0, TotalMulher =0;
        EstatiscaRepository estatisca = new EstatiscaRepository();
        public Estatistica()
        {
            InitializeComponent();
            timer1.Start();
            //MessageBox.Show(this.estatisca.Estatiscas().ToString());
        }

        private void Estatistica_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Progress.Value < this.estatisca.PerHomem)
            {
                Progress.Value ++;
            }
            else if (ProgressMulher.Value < this.estatisca.PercMulher)
                ProgressMulher.Value++;
            else if (this.TotalHomem < this.estatisca.TotalHomem)
            {
                this.TotalHomem++;
                hmTxt.Text = this.TotalHomem.ToString();
            }
            else if (TotalMulher < this.estatisca.TotalMulher)
            {
                this.TotalMulher++;
                MlhTxt.Text = this.TotalMulher.ToString();
            }
            else timer1.Stop();
        }
    }
}
