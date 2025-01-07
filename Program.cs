using CSHARP25010702;

const string PRJDIR = "E:\\PROJECTS\\CSHARP25010702\\src";

List<Tehen> happyCows = [];

using StreamReader sr = new($"{PRJDIR}\\hozam.txt");
while (!sr.EndOfStream)
{
    string[] adatSor = sr.ReadLine().Split(';');
    string id = adatSor[0];
    string nap = adatSor[1];
    string mennyiseg = adatSor[2];

    Tehen aktTehen = new(id);
    if (!happyCows.Contains(aktTehen)) happyCows.Add(aktTehen);
    int index = happyCows.IndexOf(aktTehen);
    happyCows[index].EredmenytRogzit(nap, mennyiseg);
}

Console.WriteLine("3. feladat");
Console.WriteLine($"Az állomány {happyCows.Count} tehén adatait tartalmazza.");