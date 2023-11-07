using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = -1;
            while (szam < 0 && szam<999999 || szam <0 && szam > -999999)
            try
            {
                    Console.WriteLine("Kérek egy számot: ");
                    szam = Convert.ToInt32(Console.ReadLine());
                    if (szam < 0)
                    {
                        break;
                    }
            }
            catch
            {
                    Console.WriteLine("Nem szamot adott meg");
                    Console.WriteLine();
            }
            int szamjegy = 0;
            Console.WriteLine(szam);
            if (szam==0)
            {
                szamjegy += 1;
            }
            while (szam > 0)
            {
                szam /= 10;
                szamjegy += 1;
            }
            Console.WriteLine("A szam " + szamjegy +"szamjegybol all");




        }
    }
}