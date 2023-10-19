// See https://aka.ms/new-console-template for more information

int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();

    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }

    return tomb;
}

int[] szamok = tombKeszit(1000, 100, 999);
int a = 0;
int b = 0;