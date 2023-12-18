class auto
{
    public int kerekSzam = 4;

    public void dudal() 
    {
        Console.WriteLine("Tü Tűűűt!!!");
    
    }
    private string tulaj;
    public string tulajdonos 
    {
        get
        {
            return tulaj;
        }

        set
        {
            if (value == "Bence") 
            {
                Console.WriteLine("NEM!");

            }
            else 
            {

            }
            tulaj = value;
        }
    
    }
}

class Program 
{
    static void Main() 
    {
        auto kocsi = new auto();
        Console.WriteLine(kocsi.kerekSzam);

        kocsi.dudal();
        kocsi.tulajdonos = "Gabi";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Bence";
        Console.WriteLine(kocsi.tulajdonos);

    }


}
