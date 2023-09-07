using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helló Világ!");
            double szam = 12.5;
            Console.WriteLine(szam);
            string k = "Alma";
            Console.WriteLine(k);
            char kar = 'a';
            Console.WriteLine(kar);
            Console.WriteLine((char)(kar + 2));
            Convert.ToInt32(3);
            Console.WriteLine(10 % 3);

            int a;
            a = 5;
            if (a > 2)
            {
                Console.WriteLine("Nagyobb");
            }
            else if (a < 2)
            {
                Console.WriteLine("Kisebb");
            }
            else if (a % 2==0) 
            {
                Console.WriteLine("Páros");
            }
            else 
            {
                Console.WriteLine("Egyenlő");
            }


            switch (a) 
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("kettő");
                    break;
                case 3:
                    Console.WriteLine("három");
                    break;
                case 4:
                    Console.WriteLine("négy");
                    break;
                default:
                    Console.WriteLine("valami más");
                    break;

            }

        }
    }
}
