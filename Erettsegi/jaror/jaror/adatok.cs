using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaror
{
    internal class adatok
    {
        public int ora;
        public int perc;
        public int msperc;
        public string jarmu;
        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            ora = Convert.ToInt32(vag[0]);
            perc = Convert.ToInt32(vag[1]);
            msperc = Convert.ToInt32(vag[2]);
            jarmu = vag[3].Replace("-", " ");
            
        }
    }
}
