try
{
	Console.WriteLine("Lütfen birinci sayıyı giriniz");
	int sayi1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Lütfen ikinci sayıyı giriniz");
	int sayi2 = Convert.ToInt32(Console.ReadLine());

	int bolum = sayi1 / sayi2;
	Console.WriteLine("Bölüm sonucu " + bolum);
}
catch (FormatException)
{

    Console.WriteLine("Sayı girmediğiniz için işlem yapamıyorum. Lütfen kapatıp tekrar çalıştırın");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Tam sayılar 0'a bölünemez. Lütfen uygulamayı tekrar çalıştırın");
}
catch (Exception hata)
{
    Console.WriteLine("Bir hata meydana geldi. Hata mesajı:"+hata.Message);
}