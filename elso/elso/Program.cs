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
            int b;
            b = 76;
            switch (b) 
            {
                case 76:
                    Console.WriteLine("Hetvenhat");
                    break;
            }

            double num = 1;
            while(num<3)
            {
                Console.WriteLine(num);
                num += .1;
            }

            do
            {
                num -= .2;
                Console.WriteLine(num);
            }
            while (num > 2);

            char betu = 'a';
            while(betu<='z')
            {
                Console.Write(betu);
                betu = (char)(betu + 1);

            }
            Console.WriteLine();

            int kezd = 32;
            while (kezd<=255)
            {
                Console.Write((char)kezd + "  ");
                if (kezd % 8 == 7)
                {
                    Console.WriteLine();
                }
                kezd++;
               
            }
           
            Console.WriteLine();


            int szamol = 0;
            for (int i = 1; i <= 15; i++)
            {
                szamol += i;
            }
            Console.WriteLine(szamol);

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i)
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(9 - i);
            }
            for (int i = 10; i <= 95;i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine(i+" ");
                }
            }
        }
    }
}
