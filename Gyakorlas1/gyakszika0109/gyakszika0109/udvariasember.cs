using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakszika0109
{
    internal class udvariasember:ember
    {
        public udvariasember(string vNev, string kNev):base(vNev, kNev)
        {

        }
        public void koszon()
        {
            Console.WriteLine("Szia uram!");
        }
        public void koszon(ember emberValtozoNev)
        {
            Console.WriteLine("Szia {0} uram!",emberValtozoNev.teljesNev);
        }
        public void koszonoNeve()
        {
            Console.WriteLine("Szia uram! {0} vagyok!",teljesNev);
        }
        public void koszonoNeve(ember emberValtozoNev)
        {
            Console.WriteLine("Szia {1} uram! {0} vagyok!", teljesNev,emberValtozoNev.vezetekNev);
        }
    }
}
