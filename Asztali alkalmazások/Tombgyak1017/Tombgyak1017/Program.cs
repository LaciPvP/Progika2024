


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
for (int i = 0; i < szamok.Length-1; i++) 
{
    if (szamok[i] == szamok[i + 1]) 
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



//előző elem vizsgálata
bool vanEgyenloSzomszedos1 = false;
for (int i = 1; i < szamok.Length - 1; i++)
{
    if (szamok[i] == szamok[i + -1])
    {
        vanEgyenloSzomszedos1 = true;
        Console.WriteLine("Egyenlő(k): {0}, és {1}, és {2} = {3}", i - 1, i, szamok[i - 1], szamok[i]);

    }
}
if (vanEgyenloSzomszedos1)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");

}
else
{
    Console.WriteLine("Nincs szomszédos elem!");
}



void szakasz2(int[] szamTomb) 
{
    int kezd = 0;
    int veg = 0;
    int Maxkezd = 0;
    int Maxveg = 0;

    for (int i = 1; i < szamTomb.Length; i++) 
    {
        if (szamTomb[i - 1] < szamTomb[i]) 
        {
        
        
        
        }

        else
        {
            veg = i - 1;
            if (veg -kezd+1>Maxveg-Maxkezd+1) 
            {
                Maxveg = veg;
                Maxkezd = kezd;
            
            
            }
            kezd = i;

        }


    }
    for (int i = Maxkezd; i < Maxveg + 1; i++) 
    {
        Console.WriteLine("a legnagyobb növekvő számsorozat {0} elemű: ", Maxveg-Maxkezd);


    }

    
}
szakasz2(szamok);

