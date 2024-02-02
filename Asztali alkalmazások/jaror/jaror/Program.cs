using jaror;
using System.ComponentModel;

List<adatok> tarolas = new List<adatok>();

//1. Feladat
StreamReader olvas = new StreamReader("jarmu.txt");
  while (!olvas.EndOfStream) 
    {
    string sor = olvas.ReadLine();
    tarolas.Add(new adatok(sor));

    }

olvas.Close();

Console.WriteLine("2. Feladat");
int min = tarolas[0].ora;
int max = 0;

for (int i = 0; i < tarolas.Count; i++)
{
    max = tarolas[i].ora;
}
Console.WriteLine("Ennyi órát dolgoztak egy nap: {0}", (max + 1) - min);


Console.WriteLine("3. Feladat");
List<string> orakBan = new List<string>();
int szam = 0;
for (int i = 0; i < tarolas.Count; i++) 
{
    
    if (tarolas[i].ora > szam) 
    {
        orakBan.Add(Convert.ToString(tarolas[i].ora) + tarolas[i].rendszam);
        szam++;
    }

}

for (int i = 0; i < orakBan.Count; i++) 
{
    Console.WriteLine(orakBan[i]);
}


Console.WriteLine("4. Feladat");



