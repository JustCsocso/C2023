
int[] tombKeszit(int darab,int legkisebb,int legnagyobb)
{
    int[]tomb=new int[darab];
    Random rand= new Random();

    for(int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb,legnagyobb+1);
    }
    
    return tomb;
}

int[] szamok=tombKeszit(1000, 100, 999);
int a = 0;
int b = 0;

for(int i = 0;i < szamok.Length; i++)
{
    if (szamok[i] % 2 == 0)
    {
        a += 1;
    }
    else
    {
        b += 1;
    }
}
Console.WriteLine("Páros számok: " +a);
Console.WriteLine("Páratlan számok: " + b);

//kovetkezo elem vizsgalata
bool vagyEgyenloSzomszedos = false;
for(int i = 1; i < szamok.Length; i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        vagyEgyenloSzomszedos=true;
        //break;
        Console.WriteLine("Egyenlő: {0}. és {1}, {2}={3}", i - 1, i, szamok[i - 1], szamok[i]);
    }
}

if (vagyEgyenloSzomszedos)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem!"); 
}


void szakasz2(int[] szakTomb)
{
    int kezd = 0;
    int veg = 0;
    int Maxkezd = 0;
    int Maxveg = 0;

    for(int i = 1;i < szakTomb.Length; i++)
    {
        if (szakTomb[i-1] < szakTomb[i]) 
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > Maxveg - Maxkezd + 1)
            {
                Maxveg = veg;
                Maxkezd = kezd;
            }
            kezd = i;
        }
    }
    Console.WriteLine("A legnagyobb növekvő {0} számsorozat: ",Maxveg-Maxkezd);
    for(int i = Maxkezd; i < Maxveg+1;i++)
    {
        Console.Write("{0}, ",szakTomb[i]);
    }
    Console.WriteLine();
}
szakasz2(szamok);