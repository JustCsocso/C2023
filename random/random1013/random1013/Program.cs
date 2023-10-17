// See https://aka.ms/new-console-template for more information

//1000 3 jegyű random szám 
int[] szamok = new int[1000];
Random rand = new Random();
for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = rand.Next(100, 1000);
}
foreach (int s in szamok)
{
    Console.WriteLine(s);
}
/*
0. sor: 2-vel osztható
1. sor: 3-mal osztható
2. sor: 4-gyel osztható
3. sor: 5-tel osztható
4. sor: 6-tal osztható
*/
int[,] oszthato = new int[5, 1000];
int sor0 = 0;
int sor1 = 0;
int sor2 = 0;
int sor3 = 0;
int sor4 = 0;
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 2 == 0)
    {
        oszthato[0, sor0++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 3 == 0)
    {
        oszthato[1, sor1++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 4 == 0)
    {
        oszthato[2, sor2++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 5 == 0)
    {
        oszthato[3, sor3++] = szamok[i];
    }
}
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (szamok[i] % 6 == 0)
    {
        oszthato[4, sor4++] = szamok[i];
    }
}
foreach (int s in oszthato)
{
    Console.WriteLine(s);
}

int kettoveloszthato = 0;
for (int i = 0; i < oszthato.GetLength(1); i++)
{
    if (oszthato[0, i] != 0)
    {
        kettoveloszthato++;
    }
}
Console.WriteLine(kettoveloszthato);