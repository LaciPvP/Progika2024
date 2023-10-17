int[] tombkeszit(int darab,int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb,legnagyobb+1);
    
    
    }



    return tomb;


}

int[] szamok = tombkeszit(1000, 100, 999);

int parosdb  = 0;
for (int i = 0; i < szamok.Length; i++) 
{
    if (szamok[i] % 2 == 0)
    {

        parosdb++;

    }
    

    


}
Console.WriteLine("A számok között {0} páros, és {1} páratlan volt.", parosdb, szamok.Length - parosdb);


//következő szám vizsgálása
bool vanEgyenloSzomszedos = false;
for (int i = 0; i < szamok.Length-2; i++) 
{
    if (szamok[i] == szamok[i + 2]) 
    {
        vanEgyenloSzomszedos = true;
        break;
    
    }


}
if (vanEgyenloSzomszedos)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");

}
else
{
    Console.WriteLine("Nincs szomszédos elem!");
}
