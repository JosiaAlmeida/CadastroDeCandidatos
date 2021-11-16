using Projeto1.Model;
using Projeto1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.classes.Inscrever
{
    class ValidateData
    {
        public bool state { get; set; }
        public ValidateData() {
            this.state = false;
        }
        public bool SendMessageError()
        {
            MessageBox.Show("Falha", "Houve um erro ao fazer login");
            return state;
        }
        public void ValidateStringEmpty(string name, string lastName, string Cours, string yearsOld, string sexo, string numeroBi)
        {
            CandidatoRepository candidato = new CandidatoRepository();
            try
            {
                if (!name.Contains(" ") && !lastName.Contains(" ") && Cours.Length >= 1 && !numeroBi.Contains(" "))
                {
                    state = false;
                    candidato.Cadastrar(new Candidato(
                        name,
                        lastName,
                        Cours,
                        sexo,
                        numeroBi,
                        yearsOld
                    ));
                    MessageBox.Show("Inscrição", "Inscrição feita com sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    state = true;
                    SendMessageError();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
