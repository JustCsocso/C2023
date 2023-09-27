using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy szamot: ");
            int szam=Convert.ToInt32(Console.ReadLine()); 
            for (int i=0;i<szam; i++)
            {
                Console.WriteLine(i*10);
                Console.WriteLine();
            }


            for(int i = 1; i <= 5; i++)
            {
                for (int k=1;k<=5;k++)
                {
                    Console.Write(i*k+"\t");
                }
                Console.WriteLine();    
            }


            Console.Write("Kérek egy számot: ");
            int szam2=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= szam2; i++)
            {
                for(int k=1;k<=szam2; k++)
                {
                    Console.Write(i*k+"\t");
                }
                Console.WriteLine();
            }

            int szamos = 0;
            for(int i = 0; i <= 999; i++)
            {
                szamos += i;
                if (szamos <= 999)
                {
                    Console.WriteLine(szamos);
                }
                else
                {
                    Console.WriteLine(i - 1);
                    break;
                }
            }
            
        }
    }
}
