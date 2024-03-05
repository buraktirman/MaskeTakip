//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();

SelamVer("Engin");
SelamVer("Ahmet");
SelamVer("Ayşe");
SelamVer();

int sonuc = Topla(6,58);

//Diziler / Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);

Person person1 = new Person();
person1.FirstName = "BURAK";
person1.LastName = "TIRMAN";
person1.DateOfBirthYear = 2001;
person1.NationalIdentity = 1234567890;

Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttmanager = new PttManager(new PersonManager());
pttmanager.GiveMask(person1);

static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}
static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //dbden gelir
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Engin";
    string soyad = "Demiroğ";
    int dogumYili = 1985;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);

    Console.WriteLine(tutar * 1.18);
}

//pascal casing
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}