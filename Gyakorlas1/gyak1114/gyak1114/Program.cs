// See https://aka.ms/new-console-template for more information

List<string> szavak=new List<string>();

szavak.Add("Benc-e?");
szavak.Add("Ver Bulecz");
szavak.Add("Vörös Bor");
Console.WriteLine(szavak);

for(int i = 0; i < szavak.Count; i++)
{
    Console.WriteLine(szavak[i]);
}

foreach(string s in szavak)
{
    Console.WriteLine(s);
}

Console.WriteLine(szavak.Contains("Bence"));
Console.WriteLine(szavak.IndexOf("Bence"));
Console.WriteLine(szavak.IndexOf("Vörös Bor"));

var a = szavak[szavak.IndexOf("Vörös Bor")][0];

Dictionary<string,int> p=new Dictionary<string,int>();

p.Add("Laci", 3);
p.Add("Bence", 0);
Console.WriteLine(p.Count);

p["Tomi"] = 4;
Console.WriteLine(p.Count);
p["Tomi"] = -4;
try
{
    p.Add("Bence", 10);
}
catch (Exception)
{

	p["Bence"]--;
}
p.Remove("Bence");
Console.WriteLine(p["Bence"]);

foreach(KeyValuePair<string,int> e in p)
{
    Console.WriteLine(e.Key);
}