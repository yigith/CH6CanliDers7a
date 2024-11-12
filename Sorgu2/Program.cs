
using DataLib;

Console.WriteLine("*** ÜNLÜLER VE ÜLKELERİ *** ");

var sonuc = Veri.Unluler().Join(
        Veri.Ulkeler(),
        unlu => unlu.UlkeId,
        ulke => ulke.Id,
        (unlu, ulke) => new { UnluAd = unlu.Ad, UlkeAd = ulke.Ad }
    );

foreach (var oge in sonuc)
{
    Console.WriteLine(oge.UnluAd + " - " + oge.UlkeAd);
}


Console.ReadKey();