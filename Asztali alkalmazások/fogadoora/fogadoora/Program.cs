using fogadoora;
using System.Globalization;

List<adaatok> adat = new List<adaatok>();

StreamReader olvas = new StreamReader("fogado.txt");
while (!olvas.EndOfStream) 
{
    string sor = olvas.ReadLine();
    adat.Add(new adaatok(sor));

}

olvas.Close();

Console.WriteLine("2. Feladat");
Console.WriteLine("Foglalások száma: {0}",adat.Count());

Console.WriteLine("3. Feladat");
Console.Write("Adjon meg egy nevet: ");
string tanar = Console.ReadLine();
//Console.WriteLine("Adjon meg egy tanár nevet:");
int db = 0;
for (int i = 0; i < adat.Count(); i++) 
{
    if (tanar == adat[i].nev)
    {
        db++;
    }
    if (db > 0)
    {
        Console.WriteLine("{0} néven ennyi időpontfoglalás volt: {1}", tanar, db);
    }
    else 
    {
        Console.WriteLine("A megadott néven nem volt időpontfoglalás");
    }
}

Console.WriteLine("4. Feladat");
Console.Write("Adjon meg egy érvéney időpontot: ");
string idopont = Console.ReadLine();
List<string> nevek =  new List<string>();

for (int i = 0; i < adat.Count(); i++) 
{
    if (idopont == adat[i].idopont) 
    {
        nevek.Add(adat[i].nev);
    }
}
nevek.Sort();
for (int i = 0; i < nevek.Count; i++)
{
    Console.WriteLine(nevek[i]);
}

File.WriteAllLines(idopont.Replace(":", "") + ".txt", nevek);