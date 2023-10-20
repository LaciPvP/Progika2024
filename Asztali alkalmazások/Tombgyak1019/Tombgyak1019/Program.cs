//Készítsünk egy függvényt ami visszaad egy 10.000 tagú négy jegyű, pozitív számokat tartalmazó tömböt.
//Keressük meg az olyan pontosan 3 tagú szakaszokat, amik egymástól maximum(=) 10 távolságra vannak.


int[] Ujtomb(int darab, int minimum, int maximum)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i = 0; i < tomb.Length; i++) 
    {
        tomb[i] = rand.Next(minimum,maximum+1);

    
    
    }

    return tomb;

}

int[] szamok = Ujtomb(10000, 0, 9999);
