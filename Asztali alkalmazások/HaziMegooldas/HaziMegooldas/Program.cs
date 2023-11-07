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
//sokszo[sokszo.Length - 1] = "aaaa";
//sokszo[sokszo.Length - 1] = "baaab";
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
    
}
Console.WriteLine("Többször előforduló szavak:" +tobbszoros.Substring(1));

//5.feladat
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length == 4) 
    {
        szavak[i] = szavak[i].Substring(0,1).ToUpper()+szavak[i].Substring(1);
        Console.WriteLine(szavak[i]);


    }


}

//6. Feladat
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        for (int k = 0; k < szavak.Length; k++) 
        {
            if (szavak[k].Length == 6) 
            {
                if (szavak[k].IndexOf(szavak[i].ToLower()) > -1)
                {
                    Console.WriteLine("{0} benne van ebben {1}" + szavak[i], szavak[k]); 
                }
            
            }
        
        }
    
    }


}

//7. Feladat
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 5) 
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
                                        
       

    }

}