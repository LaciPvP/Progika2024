using System.Collections.Concurrent;
using uzemanyag;

List<adatok> valtozasok = new List<adatok>();

StreamReader olvas = new StreamReader("uzemanyag.txt");
while (!olvas.EndOfStream) 
{
    valtozasok.Add(new adatok(olvas.ReadLine()));
}
olvas.Close();


Console.WriteLine("3. Feladat: Változások száma: {0}", valtozasok.Count);


adatok minimum = valtozasok[0];
for (int i = 0; i < valtozasok.Count; i++)
{
    if (valtozasok[i].kulobseg() < minimum.kulobseg()) 
    {
        minimum = valtozasok[i];
    
    
    }


}
Console.WriteLine("4. Feladat: A legkisebb különbség: {0}", minimum.kulobseg());

//5. Feladat

int db = 0;
for (int i = 0; i < valtozasok.Count; i++) 
{
    if (minimum.kulobseg() == valtozasok[i].kulobseg()) 
    {

        db++;
    }

}
Console.WriteLine("5. Feladat: A legkisebb külöbség előfordulása: {0}",db);


//6. Feladat
bool volt = false;
for (int i = 0; i < valtozasok.Count; i++) 
{
    if (DateTime.IsLeapYear(valtozasok[i].datum.Year)) 
    {
        if (valtozasok[i].datum.Month == 2 && valtozasok[i].datum.Day == 24) 
        {
            volt = true;
            break;
        }
    
    
    }

}