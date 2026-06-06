Console.WriteLine("Hello, World!");
                      //0          1        2          3        4      5           6
string[] gunler = { "Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar","Uyduruk" };
Console.WriteLine(gunler[0]);
//C# dilinde index, 0'dan başlar!
Console.WriteLine("gunler isimli array'in eleman sayısı: " + gunler.Length);
Console.WriteLine("her zaman son eleman: " +  gunler[gunler.Length - 1]);

/*
 * Bir sınıftaki öğrenci sayısı bilinmemektedir. Uygulama çalıştığında,
 * öğrenci sayısı sorulacak ve her öğrenci bir listeye kaydedilecek
 */
Console.WriteLine("Sınıfta kaç öğrenci var?");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
string[] ogrenciAdlari = new string[ogrenciSayisi];
int[] puanlar = new int[ogrenciSayisi];
//ogrenciAdlari[0] = "Lea";
//ogrenciAdlari[1] = "Orhan";
//ogrenciAdlari[2] = "Türkay";
//ogrenciAdlari[3] = "Zeynep";
//ogrenciAdlari[4] = "Zeynep";
//ogrenciAdlari[5] = "İzel";
//ogrenciAdlari[6] = "Hatice";
//ogrenciAdlari[7] = "İsmail";
//ogrenciAdlari[8] = "Derya";
//ogrenciAdlari[9] = "Dilek";

//keşke bir değişkenim olsa
//0'dan başlasa
//ogrenciSayisi değişkeninden küçük olduğu sürece
//1'er artsa

for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine("Öğrenci adını giriniz:");
    ogrenciAdlari[i] = Console.ReadLine();
    Console.WriteLine("Puanını giriniz:");
    puanlar[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine($"Öğrenci adı: {ogrenciAdlari[i]} Puanı: {puanlar[i]}");
}

//Console.WriteLine($"Öğrenci adı: {ogrenciAdlari[1]} Puanı: {puanlar[1]}");





