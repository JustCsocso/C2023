// See https://aka.ms/new-console-template for more information

int[]szam=new int[1000];
for (int i = 0; i < szam.Length; i++)
{
    Random rand = new Random();
    szam[i]= rand.Next(100, 1001);
}
