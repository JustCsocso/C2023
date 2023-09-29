// See https://aka.ms/new-console-template for more information
Console.Write("Kérek egy számot: ");
int szam=Convert.ToInt32(Console.ReadLine());

while (szam % 5 != 0)
{
    
    Console.WriteLine("Kérek egy szamot: ");
    szam= Convert.ToInt32(Console.ReadLine()); 

}
if (szam % 10 == 0)
{
    Console.WriteLine("oszható"+szam);
}

else
{
    Console.WriteLine("nem"szam);
}