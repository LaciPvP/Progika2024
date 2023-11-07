//1. Feladat
static string szo(int darab)
{
    Random rand = new Random();
    string betuk = "öüóqwertzuiopőúáűléjkghdfsayíxcvbmn";


    string szo = "";
    for (int i = 0; i < darab; i++)
    {
        int index = rand.Next(betuk.Length);
        szo += betuk[index];

    }
    return szo;
}

//2. feladat
string[] sokszo = new string[10000];
Random rand = new Random();
for (int i = 0; i < sokszo.Length; i++) 
{
    sokszo[i] = szo(rand.Next(4,7));

}

File.WriteAllLines("szavak.txt", sokszo);

/* //Debugolás
for (int i = 0; i < 50; i++) 
{
    Console.WriteLine(sokszo[i]);

}
*/

//3. Feladat
string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for (int i = 0; i < szavak.Length; i++) 
{
    for (int j = i+1; j < szavak.Length; j++) 
    {
        if (szavak[i] == szavak[j]) 
        { 
        tobbszoros += ";"+szavak[j];
            break;
        }
    
    }
    Console.WriteLine(tobbszoros);
    //Console.WriteLine("Többször előforduló szavak:" +tobbszoros.Substring(1));
}

//5.feladat
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length == 4) 
    {
        szavak[i] = szavak[i].Substring(0,1).ToUpper();
        Console.WriteLine(szavak[i]);


    }


}
