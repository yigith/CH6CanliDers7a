using DataLib;
using Sorgu3;

Console.WriteLine("*** ÜNLÜLER VE ÜLKELERİ *** ");

List<Unlu> unluler = Veri.Unluler();
List<Ulke> ulkeler = Veri.Ulkeler();

List<UnluUlke> sonuc = unluler.Join(
    ulkeler,
    un => un.UlkeId,
    ul => ul.Id,
    (unlu, ulke) => new UnluUlke()
    {
        UnluId = unlu.Id,
        UnluAd = unlu.Ad,
        UnluDogumYili = unlu.DogumYili,
        UlkeKod = ulke.Id,
        UlkeAd = ulke.Ad
    }
).ToList();

foreach (var oge in sonuc)
{
    Console.WriteLine("{0,3} {1,-20} {2,5} {3,4} {4}", oge.UnluId, oge.UnluAd, oge.UnluDogumYili, oge.UlkeKod, oge.UlkeAd);
}

Console.ReadKey();