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

var joltejelok = happyCows.Where(t => t.HetiAtlag != -1);

using StreamWriter sw = new($"{PRJDIR}\\joltejelok.txt");
foreach (var tehen in joltejelok)
    sw.WriteLine($"{tehen.Id} {tehen.HetiAtlag}");

Console.WriteLine("6. feladat");
Console.WriteLine($"{joltejelok.Count()} darab sort írtam az állományba");

Console.WriteLine("7. feladat");
Console.WriteLine("Kérem adja meg egy tehén azonosítóját!");
string azon = Console.ReadLine();
if (string.IsNullOrWhiteSpace(azon))
    throw new Exception("nem írtál be semmit :(");

int leszarmazottak = happyCows.Count(t => t.Id.StartsWith(azon) && t.Id != azon);
Console.WriteLine($"A leszármazottak száma: {leszarmazottak}");