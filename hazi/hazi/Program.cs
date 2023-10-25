// See https://aka.ms/new-console-template for more information
//1. szo bekerese es ellenorizettek hogy szo e es kotojel lehet 
//2. bekért szot karakterenkent megforditja es iratsa ki
//3. 2-vel megforditani
//4. szoveg bekeres es melyik betubol hany db

//Bekerkunb egys szot, vegignezzuk ciklussal  minden betut ellenorzunk  ha benne van akkor folyt kovi ha nincs kiirjuk hogy ez nem szo


Console.Write("Kérek egy szot: ");
string szo = Convert.ToString(Console.ReadLine());
string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm-";


bool joE = true;
for(int i=0; i < szo.Length; i++)
{
    if (betuk.IndexOf(szo[i]) < 0)
    {
        Console.WriteLine("Nem jo");
        joE = false;
        break;
    }
    if(joE) 
    {
        Console.WriteLine("{0} jó szó!", szo);
    }
    

}
string ujSzo = "";
for (int i = szo.Length - 1; i >= 0; i--)
{
    ujSzo += szo[i];
}
Console.WriteLine(ujSzo);

ujSzo = "";
for (int i = 0; i < szo.Length; i++)
{
    ujSzo+= szo[szo.Length-1 -i];
}
Console.WriteLine(ujSzo);

ujSzo = "";
for(int i = 0;i < szo.Length; i++)
{
    ujSzo = szo[i] + ujSzo;
}
Console.WriteLine(ujSzo);

ujSzo = "";
for(int i = 0;i<szo.Length ; i += 2)
{
    ujSzo += szo.Substring(szo.Length-1-1,2);
}



