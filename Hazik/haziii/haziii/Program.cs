using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 5; a <= 10; a++)
            {
                Console.Write(a + " ");

                Console.Write(a * a + " ");
                Console.WriteLine();
            }


            string szo = "a";
            while (szo != "")
            {
                Console.WriteLine("Kérek egy szót:");
                Console.ReadLine();
            }
        }
    }
}