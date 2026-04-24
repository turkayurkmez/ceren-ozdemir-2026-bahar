Console.WriteLine("Hello, World!");
/*
 * Kullanıcı aşağıdaki seçimlerden birini seçer:
 * 1. Kırmızı
 * 2. Sarı
 * 3. Yeşil
 * 
 * Eğer 1 seçilirse "DUR"
 * Eğer 2 seçilirse "DİKKAT"
 * Eğer 3 seçilirse "GEÇ" 
 * 
 * yanıtı verilir.
 * 
 */

Console.WriteLine("Lütfen aşağıdaki numaralardan birini seçin.\n1. Kırmızı\n2. Sarı\n3.Yeşil");
string secim = Console.ReadLine();

if (secim == "1")
{
    Console.WriteLine("DUR!");
}
else if (secim == "2")
{
    Console.WriteLine("DİKKAT ET");
}
else if (secim == "3")
{
    Console.WriteLine("GEÇ!");
}
else
{
    Console.WriteLine("Hatalı seçim yaptınız");
}

switch (secim)
{
    case "1":
        Console.WriteLine("DUR!");
        break;
    case "2":
        Console.WriteLine("DİKKAT!");
        break;
    case "3":
        Console.WriteLine("GEÇ!");
        break;
    default:
        Console.WriteLine("Hatalı seçim yaptınız");
        break;
}

