using jaror;
using System.Collections.Generic;

List<adatok> muszaki=new List<adatok>();

StreamReader olvas = new StreamReader("jarmu.txt");
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    muszaki.Add(new adatok(sor));
}
olvas.Close();
Console.WriteLine("2. feladat");

int max = 0;
for(int i = 0; i < muszaki.Count; i++)
{

    max = muszaki[i].ora;
}
int min = muszaki[0].ora;
Console.WriteLine("Ennyi orat dolgoztak: {0}", (max + 1) - min);

Console.WriteLine("3. feladat: ");


List<string> jarmuvek = new List<string>();

int orak = 0;
for (int i = 0; i < muszaki.Count; i++)
{
    if (muszaki[i].ora > orak)
    {
        jarmuvek.Add(Convert.ToString(muszaki[i].ora) + " óra: " + muszaki[i].jarmu);
        orak++;

    }
}
for (int i = 0; i < jarmuvek.Count; i++)
{
    Console.WriteLine(jarmuvek[i]);
}


Console.WriteLine("4. feladat: ");

string kutya=Console.ReadLine();

int busz = 0;
int kamion = 0;
int motor = 0;
for(int i = 0; i < muszaki.Count; i++)
{
    if (muszaki[0].jarmu == "B")
    {
        busz++;
    }
    else if (muszaki[0].jarmu == "K")
    {
        kamion++;
    }
    else if (muszaki[0].jarmu == "M")
    {
        motor++;
    }
}
if (busz > 0)
{
    Console.WriteLine("Ennyi busz van: {0}",busz);
}
else
{
    Console.WriteLine("nincs busz");
}
if (busz > 0)
{
    Console.WriteLine("Ennyi kamion van: {0}", kamion);
}
else
{
    Console.WriteLine("nincs kamoin");
}
if (busz > 0)
{
    Console.WriteLine("Ennyi motor van: {0}", motor);
}
else
{
    Console.WriteLine("nincs motor");
}
Console.WriteLine("5. feladat: ");

