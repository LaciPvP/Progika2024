string betuk = "öüóqwertzuiopúőűáélkjhgfdsaíyxcvbnm-";

string szo = "";
var rand = new Random();
for (int i = 0; i < szavak; i++)
{
    szo += betuk[rand.Next(betuk.Length)];
}

return szo;
}

var rand1 = new Random();
string[] szavak = new string[10000];
for (int i = 0; i < szavak.Length; i++)
{
    szavak[i] = szavak(rand1.Next(4, 7));
}



File.WriteAllLines("szavak.txt", szavak);

string[] file = File.ReadAllLines("szavak.txt");

string ugyanaz = "";

for (int i = 0; i < file.Length; i++)
{
    for (int j = 0; j < file.Length; j++)
    {
        if (file[i] == file[j] && i < j)
        {
            ugyanaz += file[i] + " ";
        }
    }
}
Console.WriteLine(ugyanaz);

for (int i = 0; i < file.Length; i++)
{
    if (file[i].Length == 4)
    {
        string a = "";
        a = file[i];
        file[i] = char.ToUpper(a[0]) + a.Substring(1);
    }
}





for (int i = 0; i < file.Length; i++)
{
    for (int j = 0; j < file.Length; j++)
    {
        if (file[i].Length == 4 && file[j].Length == 6)
        {
            if (file[j].IndexOf(file[i]) != -1)
            {
                Console.WriteLine(file[i] + file[j]);
            }
        }
    }
}

for (int i = 0; i < file.Length; i++)
{
    if (file[i].Length == 5)
    {
        file[i] = file[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
    }
}


string elso = "";
string masodik = "";
string harmadik = "";
for (int i = 0; i < file.Length; i++)
{
    if (file[i].Length == 4)
    {
        elso += file[i] + " ";
    }
    if (file[i].Length == 5)
    {
        masodik += file[i] + " ";
    }
    if (file[i].Length == 6)
    {
        harmadik += file[i] + " ";
    }
}

string[] negy1 = negy.Trim().Split(" ");
string[] ot1 = ot.Trim().Split(" ");
string[] hat1 = hat.Trim().Split(" ");
