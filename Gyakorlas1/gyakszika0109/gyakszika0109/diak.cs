using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakszika0109
{
    internal class diak:udvariasember
    {
        private int kor;
        public diak(string vNev,string kNev,int kor):base(vNev,kNev) 
        {
            this.kor = kor;
        }

        public void iskola()
        {
            if (kor < 2) { Console.WriteLine("ÓÓÓÓÓÓÓÓÓÓaaaaaaaaaaa!"); }
            else if (kor < 3) { Console.WriteLine("Bölcsibe!"); }
            else if (kor < 7) { Console.WriteLine("Óvodás vagyok!"); }
            else if (kor < 11) { Console.WriteLine("Alsós vagyok!"); }
            else if (kor < 15) { Console.WriteLine("Felső tagozatos vagyok!"); }
            else if (kor < 20) { Console.WriteLine("Techikumba járok!"); }
            else if (kor < 25) { Console.WriteLine("Egyetem! Egyetem! Egyetem!"); }
            else { Console.WriteLine("Felnőttoktatásban!"); }
        }
        public void koszon(diak diakValtozo)
        {
            Console.WriteLine("Csá {0}!", diakValtozo.keresztNev);
        }
    }
}
