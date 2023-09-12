using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekeress
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine("A bekért szöveg: "+szoveg);

            szoveg = " ";
            while (szoveg != "")
            {
                Console.Write("Kérek egy szót ");
                szoveg = Console.ReadLine();



                Console.Write("Kérek egy számoz: ");
                double szam = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A szám négyzete: " + szam * szam);
            */

            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam; i++) 
            {
                Console.WriteLine("Kérem a(z)"+(i+1)+" szót: ");
                Console.ReadLine();

            } 


        }

    }
}
