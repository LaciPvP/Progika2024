//2011 októberi emelt érettségi feladat(Pitypang)
static int fizetendo(int erkezes, int tavozas, int szemelydb, bool etkezes) 
{
    int szobaar = 0;
    if (erkezes < 121) szobaar = 9000;
    else if (erkezes < 244) szobaar = 10000;
    else szobaar = 8000;

    int Ejdb = tavozas - erkezes;
    if (szemelydb > 2) 
    {
        szobaar += 2000;
    }

    if (etkezes) 
    {
        szobaar = szemelydb * 1100;
    }

    return szobaar * Ejdb;
}




//1.fealadat

//file beolvasás
StreamReader olvas = new StreamReader("pitypang.txt");
olvas.ReadLine();
//listák a fileok széttagolására
List<int> sorszam = new List<int>();
List<int> szobaszam = new List<int>();
List<int> erkezes = new List<int>();
List<int> tavozas = new List<int>();
List<int> vendeg = new List<int>();
List<bool> etkezes = new List<bool>();
List<string> nev = new List<string>();

//file beolvasása végéig
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();

    //"1 5 3 13 1 1 Huszar_Hajnalka"
    string[] vag = sor.Split(" ");

    //listak feltoltése
    sorszam.Add(Convert.ToInt32(vag[0]));
    szobaszam.Add(Convert.ToInt32(vag[1]));
    erkezes.Add(Convert.ToInt32(vag[2]));
    tavozas.Add(Convert.ToInt32(vag[3]));
    vendeg.Add(Convert.ToInt32(vag[4]));
    etkezes.Add(vag[5] == "1");
    nev.Add(vag[6]);
}

//tesztelés hogy van e a listaban elem
//Console.WriteLine(szobaSzamok.Count());
olvas.Close();


//2.feladat
int maxEj = 0;
int maxId = 0;

for (int i = 0; i < sorszam.Count; i++)
{
    int hossz = tavozas[i] - erkezes[i];
    if (hossz > maxEj)
    {
        maxEj = hossz;
        maxId = i;
    }
}
Console.WriteLine("2. feladat");
Console.WriteLine("{0} ({1}) - {2}", nev[maxId], erkezes[maxId], maxEj);

StreamWriter ir = new StreamWriter("bevetel.txt");
for (int i = 0; i < sorszam.Count; i++) 
{
    ir.WriteLine("{0}:{1}", sorszam[i], fizetendo(erkezes[i], tavozas[i], vendeg[i], etkezes[i])); 

}

ir.Close();