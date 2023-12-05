﻿List<int> szamok = new List<int>();
Random r = new Random();
for (int i = 0; i < 500; i++)
{
    szamok.Add(r.Next(10000,100000));
}

StreamWriter ir = new StreamWriter("szamok.csv");
for (int i = 0;i < szamok.Count; i++)
{
    ir.WriteLine(szamok[i]);
}
ir.Close();


int paros(List<int> szamLista)
{
    int db = 0;
    for(int i = 0; i < szamok.Count; i++)
    {
        if (szamLista[i]%2 == 0)
        { 
            db++;
        }
    }
    return db;
}
Console.WriteLine("{0} db páros van",paros(szamok));

void paratlan(List<int> szamok)
{
    int osszeg = 0;
    for (int i = 0; i < szamok.Count; i++)
    {
        if (szamok[i] % 2 == 1)
        {
            osszeg += szamok[i];
        }
    }
    Console.WriteLine("A páratlan számok összege: {0}", osszeg);

}
paratlan(szamok);

int osszeg1 = 0;
int osszeg2 = 0;   
for (int i = 0; i < szamok.Count / 2; i++)
{
    osszeg1 += szamok[i];
}
for(int i = szamok.Count / 2; i < szamok.Count; i++)
{
    osszeg2 += szamok[i];
}
if(osszeg1 == osszeg2)
{
    Console.WriteLine("egyenlők");
}
else if(osszeg1 > osszeg2)
{
    Console.WriteLine("párosak ertéke több");
}
else
{
    Console.WriteLine("páratlanok értéke több");
}





int db = 0;
for(int i = 0;i< szamok.Count; i++)
{
    if (szamok[i] / 10000 == 3)
    {
        db++;
    }
}


for( int i = 0;i<szamok.Count ; i++)
{
    ir =new StreamWriter(szamok[i]/10000+".csv",true);
}