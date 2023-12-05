
List<int> szam=new List<int> ();
Random szamok = new Random();
for (int i = 0; i < 500; i++)
{
    
    szam.Add (szamok.Next(10000,100000));
}

StreamWriter ir = new StreamWriter("szamok.csv");
for (int i = 0;i < szam.Count; i++) 
{ 
    ir.WriteLine(szam[i]); 
}
ir.Close ();

void paros()
{
    int par = 0;
    for (int i = 0;i<szam.Count ; i++)
    {
        if (szam[i] % 2 == 0)
        {
            par++;
            
        }
        
    }
    Console.WriteLine("Összesen ennyi páratlan szám van: "+par);
}
paros();

void parat()
{
    int paratlan = 0;
    for (int i = 0; i < szam.Count; i++)
    {
        if (szam[i] % 2 == 1)
        {
            paratlan++;
        }
    }

    Console.WriteLine("Összesen ennyi páratlan szám van: "+paratlan);
}
parat();

/*
int elso = 0;
int masodik = 0;
for (int i = 0; i < szam.Count; i++)
{
    if (szam[i] < 250)
    {
        sza++;
    }
    else if(szam[i] >250)
    {
        masodik++;
    }
}


Console.WriteLine(elso);
Console.WriteLine(masodik);
*/

int harmas = 0;
for (int i = 0;i<szam.Count ; i++)
{
    if (szam[i] /10000== 3)
    {
        harmas++;
    }

}
Console.WriteLine("Öszesen ennyi 3xxxx szerű szám van: " + harmas);


int egyes = 0;
int kettes = 0;
int har = 0;
int negy = 0;
int ot = 0;
int hat = 0;
int het = 0;
int nyolc = 0;
int kilenc = 0;
for (int i = 0; i < szam.Count; i++)
{
    if (szam[i] / 10000 == 1)
    {
        egyes++;
    }
    if (szam[i] / 10000 == 2)
    {
        kettes++;
    }
    if (szam[i] / 10000 == 3)
    {
        har++;
    }
    if (szam[i] / 10000 == 4)
    {
        negy++;
    }
    if (szam[i] / 10000 == 5)
    {
        ot++;
    }
    if (szam[i] / 10000 == 6)
    {
        hat++;
    }
    if (szam[i] / 10000 == 7)
    {
        het++;
    }
    if (szam[i] / 10000 == 8)
    {
        nyolc++;
    }
    if (szam[i] / 10000 == 9)
    {
        kilenc++;
    }

}
Console.WriteLine("egyes: "+egyes);
Console.WriteLine("kettes: "+kettes);
Console.WriteLine("harmas: "+har);
Console.WriteLine("negyes: "+negy);
Console.WriteLine("otos: "+ot);
Console.WriteLine("hatos: "+hat);
Console.WriteLine("hetes: "+het);
Console.WriteLine("nyolc: "+nyolc);
Console.WriteLine("kilences: "+kilenc);
/*
StreamWriter egy = new StreamWriter("egyes.csv");
for (int i = 0; i < egy; i++)
egy.Close();
*/