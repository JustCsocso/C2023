
// See https://aka.ms/new-console-template for more information
//kerjunk ba szavakat es csak betu es -, és ezeket szavanket irjuk bele egy fajlba

string betu = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm-";
string beSzo = "mindegymi";


string gyujto = "";
while (beSzo!="")
	{ 
	bool joSzo = true;

	Console.Write("Kérek egy szót: ");
	beSzo=Console.ReadLine();

	for (int i = 0; i < beSzo.Length; i++)
	{
		if (betu.IndexOf(beSzo[i])==-1)
		{
			joSzo = false;
			Console.WriteLine("Nem jó szó!");
			break;
		}
		
	}
    if (joSzo)
    {
        gyujto += beSzo + " ";
    }
    
}
Console.WriteLine(gyujto);
string[] darabok = gyujto.Trim().Split(' ');

StreamWriter ir=new StreamWriter("szavak.txt");
for(int i = 0;i < darabok.Length; i++)
{
	ir.WriteLine(darabok[i]);
}
ir.Close();

File.WriteAllLines("szavak2.txt", darabok);
