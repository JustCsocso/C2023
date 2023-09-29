// See https://aka.ms/new-console-template for more information
using System;
/*
Console.Write("Kérek egy befogót(a):");
int szam = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérek még egy befogót(b):");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ez az átfogó(c):" + szam * szam + szam1*szam1);
*/

int a = 3;
int b = 4;
double c=Math.Sqrt(a*a + b*b);

Console.WriteLine("{0,5} {1,5} {2,5}", "a", "b", "c");

for (int i = 1; i < 50; i++)
{
    for(int k = i; k < 50; k++)
    {
        c = Math.Sqrt(i*i + k*k);
        if (c%1==0)
        {
            Console.WriteLine("{0,5} {1,5} {2,5}",i,k,c);
        }
    }
}

for(int i = 1;i < 10; i++)
{
    Console.WriteLine("{0:0.00}",Math.Sqrt(i));
}