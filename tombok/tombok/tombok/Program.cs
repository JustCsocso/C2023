void kiir(int[] tomb)
{
    foreach (int i in tomb)
    {
        Console.WriteLine("{0}.szam", i);
    }
}

// See https://aka.ms/new-console-template for more information
int[]szamok= new int[100];

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = i+1;
}

Console.WriteLine(szamok);
foreach (int i in szamok)
{
    Console.WriteLine("{0}.szam",i);
}

for (int i = 0;i < szamok.Length; i++)
{
    szamok[i] = szamok[i] * 2;
}
foreach (int i in szamok)
{
    Console.WriteLine("{0}.szam", i);
}

kiir(szamok);

//szorzotabla egyestol 10ig megvalositasa 2 dimenzios tombbel es kiirasa tablazat szeruen