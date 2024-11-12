
using DataLib;

Console.WriteLine("*** ÜLKE ÜLKE ÜNLÜLER ***");

var sonuc = Veri.Unluler().GroupBy(u => u.UlkeId);

Console.WriteLine("TOPLAM GRUP ADEDİ: " + sonuc.Count());
Console.WriteLine();

foreach (var grup in sonuc)
{
    Console.WriteLine("### " + grup.Key + " GRUBU ###");
    Console.WriteLine("Gruptaki öğe adedi: " + grup.Count());

    foreach (Unlu unlu in grup)
    {
        Console.Write(unlu.Ad + "  ");
    }
    Console.WriteLine();

    Console.WriteLine();
}

Console.ReadKey();