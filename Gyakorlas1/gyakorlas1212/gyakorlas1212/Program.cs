
using gyakorlas1212;

class auto
{
    public int keretSzam = 4;

    public void dudal()
    {
        Console.WriteLine("Tüüüüüüüüüü!!!");
    }

    private string _tulaj;
    public string tulajdonos
    {
        get
        {
            return _tulaj;
        }
        set 
        {
            if (value == "Bence")
            {
                Console.WriteLine("NEM");
                
            }
            else
            {
                _tulaj = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.keretSzam);

        kocsi.dudal();
        kocsi.tulajdonos = "Gabi";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Bence";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Ákos";
        Console.WriteLine(kocsi.tulajdonos);

        Laci laci = new Laci();
        laci.sug();
        
    }
}