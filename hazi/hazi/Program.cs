using System;

//1. feladat

string betuk = "qwertzuiopöüóőúasdfghjkléáűíyxcvbnm";
var random = new Random();
string[] szavak = new string[10000];

for (int i = 0; i < 10000; i++)
{
    string szo = "";
    int hossz = random.Next(4, 7);
    for (int k = 0; k < hossz; k++)
    {
        szo += betuk[random.Next(betuk.Length)];
    }
    szavak[i] = szo;
}

File.WriteAllLines("szavak.txt", szavak);

//2. feladat

string[] fajl = File.ReadAllLines("szavak.txt");
for (int i = 0; i < fajl.Length; i++)
{
    //Console.WriteLine(fajl[i]);
}
for (int i = 0; i < fajl.Length; i++)
{
    if (fajl[i] == szavak[i])
    {
        Console.WriteLine(fajl[i]);
    }
    else
    {

    }
}

string szoveg = "";
for (int i = 0; i < fajl.Length; i++)
{
    if (fajl[i].Length == 4)
    {
        Console.WriteLine(fajl[i].ToUpper);
    }
}

//ennyi ment, marmint fele se jo, de legalabb valami