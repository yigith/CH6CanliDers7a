// Ülkeleri Listele
using DataLib;

Console.WriteLine("\r\n####### ÜLKELER #######");
foreach (Ulke ulke in Veri.Ulkeler())
{
    Console.WriteLine(ulke.Ad);
}

Console.WriteLine("\r\n####### ÜNLÜLER #######");
foreach (Unlu unlu in Veri.Unluler())
{
    Console.WriteLine(unlu.Ad);
}

Console.ReadKey();