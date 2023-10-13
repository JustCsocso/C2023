// See https://aka.ms/new-console-template for more information



Console.Write("Kérek egy szám: ");
int szam=Convert.ToInt32(Console.ReadLine());

string[] szoveg = new string[szam];

for (int i = 0; i < szoveg.Length; i++)
{
    Console.Write("Kérek egy szöveget: ");
    szoveg[i] = Console.ReadLine();
}

string max = "";
for (int i = 0;i < szoveg.Length; i++)
{
    if (szoveg[i].Length > max.Length)
    {

    }
}