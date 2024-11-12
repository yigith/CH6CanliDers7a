
// 1970 Öncesinde Doğan Ünlüler

using DataLib;

//IEnumerable<Unlu> sonuc1 = Veri.Unluler().Where(unlu => unlu.DogumYili < 1970);

IEnumerable<Unlu> sonuc1 = Veri.Unluler().Where(Olcut);

Console.WriteLine("*** 1970 Öncesinde Doğan Ünlüler ***");
foreach (Unlu unlu in sonuc1)
{
    Console.WriteLine(unlu.Ad + " (" + unlu.DogumYili + ")");
}

Console.WriteLine();
Console.WriteLine("*** İsmi A ile Başlayan Ünlüler ***");
//var sonuc2 = Veri.Unluler().Where(AdiAIleBaslarMi);
var sonuc2 = Veri.Unluler().Where(u => u.Ad.StartsWith("A"));
foreach (var unlu in sonuc2)
{
    Console.WriteLine(unlu.Ad);
}

Console.WriteLine();
Console.WriteLine("*** 1970 ve Sonrası Doğan Oyuncu Ünlüler ***");

foreach (var unlu in Veri.Unluler().Where(x => x.DogumYili >= 1970 && x.Meslek.Contains("Oyuncu")))
{
    Console.WriteLine(unlu.Ad + " (" + unlu.DogumYili + ")");
}

Console.WriteLine();
Console.WriteLine("*** 1970 ve Sonrası Doğan Oyuncu Ünlüler ***");

foreach (var unlu in Veri.Unluler().Where(x => x.DogumYili >= 1970).Where(x => x.Meslek.Contains("Oyuncu")))
{
    Console.WriteLine(unlu.Ad + " (" + unlu.DogumYili + ")");
}

Console.WriteLine();
Console.WriteLine("*** 1970 ve Sonrası Doğan Oyuncu Ünlüler (Yıla Göre Sıralı) ***");

foreach (var unlu in Veri.Unluler()
    .Where(x => x.DogumYili >= 1970)
    .Where(x => x.Meslek.Contains("Oyuncu"))
    .OrderBy(x => x.DogumYili)
    .ThenByDescending(x => x.Ad)
    )
{
    Console.WriteLine(unlu.Ad + " (" + unlu.DogumYili + ")");
}

// Yukarıdaki sorguda aynı yılda doğanların isimlerine göre tersten sıralanmış olduğuna dikkat ediniz!

bool Olcut(Unlu unlu)
{
    return unlu.DogumYili < 1970;
}

bool AdiAIleBaslarMi(Unlu unlu)
{
    return unlu.Ad.StartsWith("A");
}


Console.ReadKey();