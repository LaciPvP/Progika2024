List<string> proba = new List<string>();
List<string> proba2 = new List<string>();

StreamReader olvas = new StreamReader("kiserlet.txt");

//While-os kiíratások
while (!olvas.EndOfStream) 
{
    proba.Add(olvas.ReadLine());
    
}

//For ciklusos kiíratások
for (int i = 0; i < proba.Count; i++)
{
    Console.WriteLine(proba[i]);
}

for (int i = 0; i < proba2.Count; i++)
{
    Console.WriteLine(proba2[i]);
}

