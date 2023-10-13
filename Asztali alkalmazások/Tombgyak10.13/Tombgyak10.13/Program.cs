/*
Console.Write("Kérek egy számot: ");
int beker = Convert.ToInt32(Console.ReadLine());


string[] szavak = new string[beker];
for (int i = 0; i < beker; i++) 
{
    Console.Write("Kérem a szavakat: ");
    szavak[i] = Console.ReadLine();

    


}
string max = "";
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length > max.Length) 
    
    {

        max = szavak[i];
    
    }

}
Console.WriteLine("A leghosszabb szó: "+max);



//index keresés
int maxIndex = 0;
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i] == max) 
    {
        maxIndex = i;
    
    }


}





//Maximum érték keresése másként
max = "";
maxIndex = 0;
for (int i = 0; i < szavak.Length; i++) 
{
    if (szavak[i].Length > max.Length) 
    {
        max = szavak[i];
        maxIndex = i; 
    
    }


}





//Maximum érték keresése másként(2)

maxIndex = 0;
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length > szavak[maxIndex].Length)
    { 
        maxIndex = i;
    }
}
*/



int rIndex = 0;
int hIndex = 0;

string[] szavak = new string[] {"alma","körte","narancs","mandula","ananász","banán"};

string[] rovid = new string[szavak.Length]; //5 karakter vagy annál rövidebb
string[] hosszu = new string[szavak.Length]; //% karakternél több

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[rIndex] = szavak[i];
        rIndex++;


    }

    else 
    {
        hosszu[hIndex++] = szavak[i];
        hIndex++;
    }


}
Console.WriteLine();
Console.WriteLine();



