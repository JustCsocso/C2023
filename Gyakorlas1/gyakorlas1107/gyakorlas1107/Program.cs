// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

static string szo(int darab)
{
    Random rand = new Random();
    string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
    string mgh = "auioe";
    string msh = "qwrtzpsdfghjklyxcvbnm";
    string szo = "";
    for (int i = 0; i < darab; i++)
    {
        int index = rand.Next(betuk.Length);
        szo += betuk[index];
    }
    string szo1 = "";
    for (int i = 0; i < darab; i++)
    {
        if ();
    }
    return szo;
}



string[] sokSzo=new string[10000];
Random rand = new Random();
for (int i = 0;i < sokSzo.Length; i++)
{
    sokSzo[i]=szo(rand.Next(2,11));
}


sokSzo[sokSzo.Length - 1] = "aa";
sokSzo[0] = "sziamiauki";
File.WriteAllLines("szavak.txt", sokSzo);
/*
for (int i = 0; i < 50; i++)
{
    Console.WriteLine(sokSzo[i]);  
}
*/

string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for (int i = 0;i<szavak.Length ; i++)
{
    for(int k = i+1; k < szavak.Length; k++)
    {
        if (szavak[i] == szavak[k])
        {
            tobbszoros+= ";"+szavak[k];
            break;
        }
    }
}
if (tobbszoros != "")
{
    tobbszoros = tobbszoros.Substring(1);
    Console.WriteLine("Többször előforduló szavak: " + tobbszoros);

}

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        szavak[i] = szavak[i].Substring(0, 1).ToUpper() + szavak[i].Substring(1);
        Console.WriteLine(szavak[i]);
    }
}

for(int i = 0; i < szavak.Length; i++)
{
    Console.WriteLine(szavak[i]);
    if (szavak[i].Length == 4)
    {
        for(int k = 0; k < szavak.Length; k++)
        {
            if (szavak[k].Length == 6)
            {
                if (szavak[k].IndexOf(szavak[i].ToLower()) > -1)
                {
                    Console.WriteLine("{0} benne van ebben: {1}", szavak[i], szavak[k]);
                }
            }
        }
    }
}

for(int i = 0;i < szavak.Length; i++)
{
    if (szavak[i].Length == 5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
        Console.WriteLine(szavak[i]);
    }

}

string[] valogat = new string[11];

for(int i = 0; i < szavak.Length; i++)
{
    valogat[szavak[i].Length] += szavak[i] + ";";
}
for(int i = 2; i < valogat.Length; i++)
{
    string[] darabolt = valogat[i].Substring(0, valogat[i].Length - 1).Split(';');

    Array.Sort(darabolt);
    File.WriteAllLines(i+"betus.txt", darabolt);
}