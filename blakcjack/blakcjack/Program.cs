// See https://aka.ms/new-console-template for more information
List<string> kartyak=new List<string>();
List<string> szinek=new List<string>() {"Treff", "Pikk", "Kőr", "Káró"};
List<string> szamok=new List<string>() {"2","3","4","5","6","7","8","9","10","dáma","jumbo","király","ász" };
Random rand=new Random();
for (int i = 0; i < szinek.Count; i++)
{
    for (int k = 0; k <szamok.Count;k++)
    {
        kartyak.Add($"{szinek[i]} {szamok[k]}");
    }
   
}


Dictionary<string,int> ertekek=new Dictionary<string,int>();

for (int i = 0;i<kartyak.Count ; i++)
{
    if (kartyak[i].IndexOf("jumbo") != -1 && kartyak[i].IndexOf("dáma") != -1 && kartyak[i].IndexOf("király") != -1)
    {
        ertekek.Add(kartyak[i], 10);

    }
    else if (kartyak[i].IndexOf("ász") != -1)
    {
        ertekek.Add(kartyak[i], 11);
    }
    else
    {
        ertekek.Add(kartyak[i], Convert.ToInt32(kartyak[i].Split(" ")[1]));
    }
}
for(int i = 0; i < 100; i++)
{
    for (int k = 0; k < ertekek.Count; k++)
    {
        int temprand = rand.Next(0, ertekek.Count - 1);
        string temp1 = "";
        kartyak[i] = kartyak[temprand];
        kartyak[temprand] = temp1;
    }
}

for (int i = 0;i < kartyak.Count; i++)
{
    Console.WriteLine(kartyak[i])
}



