//Kérjünk be szavakat, és ezek szavak legyenek(hibakezelés),és ezeket szavanként írjuk bele egy fileba!

string betuk = "öüóqwertzuiopőúűáélkmnjhbvgfcxdsyaí";
string beSzo = "asd";
string gyujto = "";

while (beSzo != "") 
{
    bool joSzo = true;

    Console.Write("Kérek egy szót: ");
    beSzo = Console.ReadLine();

    for (int i = 0; i < beSzo.Length; i++) 
    {
        if (betuk.IndexOf(beSzo[i]) == -1)
        {
        joSzo = false;
            Console.WriteLine("A {0} nem jó szó!", beSzo);
            break;

        }
    
    
    
    }


    if (joSzo) 
    {
        gyujto += beSzo + " ";
    
    }

}
Console.WriteLine(gyujto);
string[] darabok = gyujto.Trim().Split(" ");

for (int i = 0; i < darabok.Length; i++) 
{
    Console.WriteLine(darabok[i]);
}


StreamWriter ir = new StreamWriter("szavak.txt");
for (int i = 0; i < darabok.Length; i++) 
{
    ir.WriteLine(darabok[i]);
}
ir.Close();

