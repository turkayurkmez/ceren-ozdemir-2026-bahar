Console.WriteLine("Hello, World!");
/*
 * Amacım, uygulamanın doğum yılıma göre yaşımı hesaplaması.
 * Bu hesap için gerekli veriler:
 *    1. Şu anki yıl
 *    2. Kişinin doğduğu yıl.
 *    3. yaş hesaplamak için ilk veriden ikincisini çıkart.
 *    
 *    
 *    Sözel, sayısal, mantıksal
 */

int suAnkiYil = DateTime.Now.Year;
Console.WriteLine("Lütfen doğum yılınızı 4 haneli olarak girin:");
//Kullanıcı, console üzerinden doğum yılını girer ve bu veri dogumYili isimli değişkende saklanır.
string girilenYil = Console.ReadLine();
int dogumYili = Convert.ToInt32(girilenYil);

int yas = suAnkiYil - dogumYili;

Console.WriteLine(yas);
Console.WriteLine(DateTime.Now);
//sadece byte negatif (-) olamaz.
byte enKucuk = 255;
sbyte negatifByte = -128;

short onaltiBit = 32767;
int otuzIkiBit = 2_000_000_000;
long altmisDort = 545454545454454545;

double pi = 3.14;
float fPi = 3.14f;
decimal decPi = 3.14591041510475860566855460455665410456655665566m;

char harf = 'T';
Console.WriteLine("Adınızı girin:");
string isim = Console.ReadLine();

bool renkliMi = false;
bool kullaniciAktifMi = true;

Console.WriteLine(isim+", "+yas+" "+"yaşında");


