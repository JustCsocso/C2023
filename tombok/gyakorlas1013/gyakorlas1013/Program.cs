// See https://aka.ms/new-console-template for more information
/*
Console.Write("Kérek egy szám: ");
int szam=Convert.ToInt32(Console.ReadLine());

string[] szoveg = new string[szam];

for (int i = 0; i < szoveg.Length; i++)
{
    Console.Write("Kérek egy szöveget: ");
    szoveg[i] = Console.ReadLine();
}

string max = "";
//maximum keresés
for (int i = 0;i < szoveg.Length; i++)
{
    if (szoveg[i].Length > max.Length)
    {
        max = szoveg[i];
    }
}
Console.WriteLine(max);

//index keresés

int maxIndex = 0;
for (int i = 0; i<= szoveg.Length; i++)
{
    if (szavak[i] == max)
    {
        maxIndex = i;
    }
}

//maximum keresés másként

max = "";
maxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i].Length>max.Length)
    {
        max = szoveg[i];
        maxIndex = i;
    }
}

//max keresés 3

maxIndex = 0;
for (int i = 0;i<szoveg.Length; i++)
{
    if (szoveg[i].Length > szoveg[maxIndex].Length)
    {
        maxIndex = i;
    }
}

*/

string[] szavak = new string[] {"alma","körte",
                "narancs","mandula",
                "ananász","banán" };

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];

int rovidIndex = 0;
int hoszzuIndex=0;

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length >= 5)
    {
        rovid[rovidIndex] = szavak[i];
        rovidIndex++;
    }
    else
    {
        hosszu[hoszzuIndex++]= szavak[i];

    }
}

for (int i = 0;i < rovid.Length; i++)
{
    Console.WriteLine(rovid[i]);
}
for(int i = 0;i>hosszu.Length ; i++)
{
    Console.WriteLine(hosszu[i]);
}