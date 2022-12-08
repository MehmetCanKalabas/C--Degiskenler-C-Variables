
Console.WriteLine("Hello, World!");

string isim, soyisim;
Console.WriteLine("İsminizi Giriniz");
isim = Console.ReadLine();



Console.WriteLine("Soyisminizi Giriniz");
soyisim = Console.ReadLine();

if (isim == "sedat" && soyisim == "tefçi")
{
    Console.WriteLine("Doğru");

}

else
{

    Console.WriteLine("Yanlış");
}


int calisma_gun_sayisi = 4500;
int yas = 50;
char cinsiyet = 'K';
bool hamilemi = true;
double prim = 0;
bool askerlik_durumu = true;
string sehir = "izmir";

var araba = 1.2;
Console.WriteLine(araba);


if (cinsiyet == 'K')
{

    if ((yas >= 45 && calisma_gun_sayisi > 4000) || hamilemi == true || sehir == "izmir")
    {
        prim *= 3;
    }
    else
    {
        prim = prim * 2;
    }
}
else
{
    if ((yas >= 45 && calisma_gun_sayisi > 4000) || askerlik_durumu == true)
    {
        prim = prim * 3;
    }
    else
    {
        prim = prim * 2;
    }
}








