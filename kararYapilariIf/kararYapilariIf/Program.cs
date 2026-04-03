Console.WriteLine("Lütfen kullanıcı adını giriniz:");
/*
 * amaç: kullanıcı adı turkay olanlar uygulamaya giriş yapabilir.
 * 
 * 1.  Kullanıcıdan, Console'üzerinden  adını al ve bir değişkene at.
 * 2.  Eğer bu değişkenin değeri "turkay" ise
 *      "Hoşgeldin Türkay" yazsın.
 *     Değilse eğer değişkenin değeri "hatice" ise
 *      "Hoşgeldiniz Hatice hanım" yazsın. 
 *     Değilse 
 *     Console'a  "Tanınmayan kullanıcı" yazsın.
 */

string kullaniciAdi = Console.ReadLine();
if (kullaniciAdi == "turkay")
{
    Console.WriteLine("Hoşgeldin patron!");
}
else if (kullaniciAdi == "hatice")
{
    Console.WriteLine("Hoşgeldiniz hatice hanım....");
}
else
{
    Console.WriteLine("Tanınmayan kullanıcı");
}

/*
 *  0 - Tura
 *  1 - Yazı olacak.
 *  
 *  En küçük 0 ile en fazla 2 arasında rastgele bir sayı seç.
 *  Eğer  sayı 0 ise 
 *      Tura
 *  Değilse 
        Yazı
 */

Random rastgeleSayiUretici = new Random();
//CamasirMakinesi benimEvdekiMakinem = new CamasirMakinesi();
int rastgeleSayi = rastgeleSayiUretici.Next(0, 2);
if (rastgeleSayi == 0)
{
    Console.WriteLine("Tura");
}
else
{
    Console.WriteLine("Yazı");
}




