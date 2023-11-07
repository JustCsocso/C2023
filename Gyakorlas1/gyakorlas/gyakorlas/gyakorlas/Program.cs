using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            while (szam < 999999)
            {
                Console.Write("Kérek egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());

                if (szam > 100000)
                {
                    Console.WriteLine("A szám hatjegyű");
                }
                else if (szam > 10000)
                {
                    Console.WriteLine("A szám ötjegyű");
                }
                else if (szam > 1000) 
                {
                    Console.WriteLine("A szám negyjegyű");
                }
                else if (szam > 100)
                {
                    Console.WriteLine("A szám háromjegyű");
                }
                else if (szam > 10)
                {
                    Console.WriteLine("A szám ketjegyű");
                }
                else
                {
                    Console.WriteLine("A szám egyjegyű");
                }
            }
            

   
        }
    }
}
