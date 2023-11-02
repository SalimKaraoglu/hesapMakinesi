﻿

Console.WriteLine(
   "\"██╗░░██╗███████╗░██████╗░█████╗░██████╗░  ███╗░░░███╗░█████╗░██╗░░██╗██╗███╗░░██╗███████╗░██████╗██╗\\n\"\r\n\"" +
   "  ██║░░██║██╔════╝██╔════╝██╔══██╗██╔══██╗  ████╗░████║██╔══██╗██║░██╔╝██║████╗░██║██╔════╝██╔════╝██║\\n\"\r\n\"" +
   "  ███████║█████╗░░╚█████╗░███████║██████╔╝  ██╔████╔██║███████║█████═╝░██║██╔██╗██║█████╗░░╚█████╗░██║\\n\"\r\n\"" +
   "  ██╔══██║██╔══╝░░░╚═══██╗██╔══██║██╔═══╝░  ██║╚██╔╝██║██╔══██║██╔═██╗░██║██║╚████║██╔══╝░░░╚═══██╗██║\\n\"\r\n\"" +
   "  ██║░░██║███████╗██████╔╝██║░░██║██║░░░░░  ██║░╚═╝░██║██║░░██║██║░╚██╗██║██║░╚███║███████╗██████╔╝██║\\n\"\r\n\"" +
   "  ╚═╝░░╚═╝╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░  ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚══════╝╚═════╝░╚═╝\\n\")");

Console.WriteLine("İşlem Seçiniz => [Dört İşlem '1' , Geometrik İşlem '2']");
string matematikselİslem = Console.ReadLine();

if (matematikselİslem == "1") // Cebirsel İşlemler
{
    Console.Write("Lütfen İlk Sayıyı Giriniz: ");
    double sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
    double sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"====================\nİşlem Giriniz: \nToplam : '+'\nÇıkarma : '-'\nÇarpma : '*'\nBölme : '/'");
    
    string islem = Console.ReadLine();

    if (sayi1 > sayi2 && islem == "-") // Çıkarma İşlemi
    {
        double fark = sayi1 - sayi2;
        Console.WriteLine("İşlem Sonucu : " + fark.ToString());
    }
    else if (islem == "+") // Toplama İşlemi
    {
        double toplam = sayi1 + sayi2;
        Console.WriteLine("İşlem Sonucu : " + toplam.ToString());
    }
    else if (islem == "/") // Bölme İşlemi
    {
        double bolum = sayi1 / sayi2;
        Console.WriteLine("İşlem Sonucu : " + bolum.ToString());
    }
    else if (islem == "*") // Çarpma İşlemi
    {
        double carpım = sayi1 * sayi2;
        Console.WriteLine("İşlem Sonucu : " + carpım.ToString());
    }
    else
        Console.WriteLine("Hatali Giriş Yaptınız!!!");
}
if (matematikselİslem == "2") // Geometrik İşlemler
{
    Console.WriteLine("Ucgen İcin '1', Dörtgen İçin '2'");
    string secim1 = Console.ReadLine();
    if (secim1 == "1") // Üçgen ile İlgili İşlemler
    {
        Console.WriteLine("Alan İçin '1' , Çevre İçin '2' ");
        string ucgenislem = Console.ReadLine();
        if (ucgenislem == "1")
        {
            Console.Write("Yüksekliği Giriniz : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Taban Uzunluğunu Giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());

            int alan = (h * taban) / 2;
            Console.WriteLine("Girmiş Olduğun Üçgenin Alanı: " + alan);
        }
        else if (ucgenislem == "2")
        {
            Console.Write("1. Kenar Uzunluğunu Giriniz: ");
            int ucgenKenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Kenar Uzunluğunu Giriniz: ");
            int ucgenKenar2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Kenar Uzunluğunu Giriniz: ");
            int ucgenKenar3 = Convert.ToInt32(Console.ReadLine());

            int cevre = ucgenKenar1 * ucgenKenar2 * ucgenKenar3;
            Console.Write("Girmiş Olduğun Üçgenin Çevresi: " + cevre);
        }
    }
    if (secim1 == "2") // Dörtgen İle İlgili İşlemler 
    {
        Console.WriteLine("Kısa Kenar Ölçüsünü Giriniz : ");
        int dortgenKenar1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Uzun Kenar Ölçüsünü Giriniz : ");
        int dortgenKenar2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Alan Hesabı İçin '1',Çevre İçin '2'");
        string dortgenİslem = Console.ReadLine();
        if (dortgenİslem == "1")
        {
            int dortgenAlan = dortgenKenar1 * dortgenKenar2;
            Console.WriteLine("Girmiş Olduğunuz Dörtgenin Alanı : " + dortgenAlan);
        }
        else if (dortgenİslem == "2")
        {
            int dortgenCevre = (dortgenKenar1 + dortgenKenar2) * 2;
            Console.WriteLine("Girmiş Olduğunuz Dörtgenin Cevresi : " + dortgenCevre);
        }
    }
}


Console.WriteLine("Çıkmak İçin Bir Tuşa Basınız!");
Console.ReadKey();









