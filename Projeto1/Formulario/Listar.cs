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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
            this.ShowList();
        }
        public void ShowList()
        {
            CandidatoRepository candidato = new CandidatoRepository();
            int ContID = 0;
            foreach (var item in candidato.Listar())
            {
                string[] Split = item.Replace(";"," ").Replace("-"," ").Split(' ');
                if(Split.Length<=1 && Split[0]=="0" 
                    || Split.Length <= 1 && Split[0] == "0 "
                    || Split.Length <= 1)
                {
                }
                else
                {
                    ContID++;
                   listId.Items.Add(ContID);
                   listNome.Items.Add(Split[1] + " " + Split[2]);
                   listCurso.Items.Add(Split[3].ToString());
                   listIdade.Items.Add(Split[4].ToString());
                   listSexo.Items.Add(Split[5].ToString());
                   listNBI.Items.Add(Split[6].ToString());
                }
            }
            
        }
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listar_Load(object sender, EventArgs e)
        {

        }
    }
}
