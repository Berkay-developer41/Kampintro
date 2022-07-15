// See https://aka.ms/new-console-template for more information
 using Metotlar;
Console.WriteLine("Hello, World!");

{
    {
        string urunAdi = "Elma";
        double fiyati = 15;
        string aciklama = "Amasya elması";

        string[] meyveler = new string[] { "Elma", "karpuz" };

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyatı = 15;
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyatı = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };
        //type safe -- tip güvenliği
        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyatı);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("--------------");
        }


        Console.WriteLine("---------Metotlar--------");

        SepetManeger sepetManeger = new SepetManeger();
        sepetManeger.Ekle(urun1);
        sepetManeger.Ekle(urun2);

        sepetManeger.Ekle2("Armut", "Yeşil armut", 12, 10);
        sepetManeger.Ekle2("Elma", "Yeşil elma", 12, 9);
        sepetManeger.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 7);
    }
}
 // Dont repeat yourself - DRY - Clean Code - Best Practice

