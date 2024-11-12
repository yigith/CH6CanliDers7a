using DataLib;

Console.WriteLine("*** MESLEKLER ***");

var meslekler = Veri.Unluler().Select(x => x.Meslek).Distinct();

foreach(string meslek in meslekler)
{
    Console.WriteLine(meslek);
}

Console.WriteLine();
Console.WriteLine("Meslek Çeşit Adedi: " + meslekler.Count());

Console.ReadKey();