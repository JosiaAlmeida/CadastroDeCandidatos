using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Repository
{
    public class EstatiscaRepository
    {
        public EstatiscaRepository()
        {
            this.Analise();
        }
        public float TotalHomem { get; set; }
        public float TotalMulher { get; set; }
        public float PerHomem { get; set; }
        public float PercMulher { get; set; }

        public float Estatiscas()
        {
            StreamReader reader = new StreamReader(@"./file.txt");
            var AllUser = reader.ReadToEnd();
            string[] SplitUser = AllUser.Split(' ');
            reader.Dispose();

            return (TotalHomem / 100) * float.Parse(SplitUser.Length.ToString());
        }
        private void Analise()
        {
            StreamReader reader = new StreamReader(@"./file.txt");
            var AllUser = reader.ReadToEnd();
            string[] SplitUser = AllUser.Split(';');
            reader.Dispose();
            foreach(var item in SplitUser)
            {
                if (item.Equals("M")) this.TotalHomem++;
                if (item.Equals("F")) this.TotalMulher++;
            }
            this.PerHomem = (TotalHomem / 100)* float.Parse(SplitUser.Length.ToString());
            this.PercMulher = (TotalMulher / 100) * float.Parse(SplitUser.Length.ToString());
        }
    }
}
