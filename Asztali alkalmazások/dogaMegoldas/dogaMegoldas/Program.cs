//1. feladat
List<int> szamok = new List<int>();
Random szam = new Random();

for (int i = 0; i < 500; i++)
{

    szamok.Add(szam.Next(10000, 100000));

}

StreamWriter bele = new StreamWriter("szamok.csv");
for (int i = 0; i < szamok.Count; i++)
{
    bele.WriteLine(szamok[i]);


}
bele.Close();



//Páros számok
Console.Write("2. Feladat");
List<int> parOS = new List<int>();
void parosok()
{
    for (int i = 0; i < szamok.Count; i++)
    {
        if (szamok[i] % 2 == 0)
        {
            parOS.Add(szamok[i]);
        }
    }
}
parosok();
Console.WriteLine("Ennyi páros szám van a függvényben: {0}", parOS.Count);






//Páratlan számok
Console.Write("3. Feladat");
List<int> paratlan = new List<int>();
void paratlanok()
{
    for (int i = 0; i < szamok.Count; i++)
    {
        if (szamok[i] % 2 != 0)
        {
            paratlan.Add(szamok[i]);
        }
    }
}
paratlanok();
Console.WriteLine("Ennyi páratlan szám van a függvényben: {0}, és az összegük {1}", paratlan.Count, paratlan.Sum());



Console.WriteLine("4. Feladat");
List<int> elsofele = new List<int>();
List<int> masodikfele = new List<int>();

for (int i = 0; i < szamok.Count / 2; i++)
{

    elsofele.Add(szamok[i]);

}
//Console.WriteLine(elsoFel.Count);
for (int i = 250; i < 500; i++)
{
    masodikfele.Add(szamok[i]);
}
//Console.WriteLine(masodikFel.Count);

Console.WriteLine("A lista első felének összege {0}, a második felének összege {1}", elsofele.Sum(), masodikfele.Sum());
if (elsofele.Sum() > masodikfele.Sum())
{
    Console.WriteLine("Az első fele a nagyobb!");
}

else
{
    Console.WriteLine("A második fele a nagyobb!");
}