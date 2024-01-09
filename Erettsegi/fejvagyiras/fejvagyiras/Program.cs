
List<string> uj=new List<string>();

List<string> lista1=new List<string>();

List<string> lista2 = new List<string>();
/*
StreamReader olvas = new StreamReader("kiserlet.txt");
while (!olvas.EndOfStream)
{
    lista1.Add(olvas.ReadLine());
}
for(int i=0; i<lista1.Count; i++)
{
    Console.WriteLine(lista1[i]);
}
olvas.Close();
*/

File.ReadAllLines("kiserlet.txt");
for (int i = 0; i < uj.Count; i++)