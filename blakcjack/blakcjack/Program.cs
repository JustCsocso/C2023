// See https://aka.ms/new-console-template for more information
List<string> kartyak=new List<string>();
List<string> szinek=new List<string>() {"Treff", "Pikk", "Kőr", "Káró"};
List<string> szamok=new List<string>() {"2","3","4","5","6","7","8","9","10","dáma","jumbo","király","ász" };
Random rand=new Random();
for (int i = 0; i < 52; i++)
{
    for (int j = 0; j <)
    kartyak.Add($"{randszin} {randszam}");
}

for (int i = 0;i < kartyak.Count; i++)
{
    Console.WriteLine(kartyak[i]);
}
/*
     string randszin = szinek[rand.Next(szinek.Count)];
    string randszam = szamok[rand.Next(szamok.Count)];
 */