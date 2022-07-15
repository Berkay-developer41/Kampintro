 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    //type safety = tip güvenliği
    //do not repeat yourself - kendini tekrarlama
    //değer tutucu, alias

    string KategoriEtiketi = "Kategoriler";
    int ÖğrenciSayısı = 1000;
    double faizoranı = 1.45;
    bool sistemeGrişYapmışMi = true;
    double dolarDun = 7.55;
    double dolarBugun = 7.55;

    if (dolarDun>dolarBugun)

    {
        Console.WriteLine("Azalış Butonu");

    }
    else if (dolarDun<dolarBugun)
    {
        Console.WriteLine("Artış Butonu");

    }
    else
    {
        Console.WriteLine("Değişmedi Butonu");
    }


    if (sistemeGrişYapmışMi  == true)
    {
        Console.WriteLine("Kullanıcı Ayarları Butonu");

    }
    else
    {
        Console.WriteLine("Giriş yap butonu");
    }

  
    
    
    Console.WriteLine(KategoriEtiketi);


}