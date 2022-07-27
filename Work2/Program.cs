// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

{
    Musterı musterı1 = new Musterı();
    musterı1.kullanıcıAdi = "Berkay";
    musterı1.kullanıcıSoyad = "Özkol";
    musterı1.kullanıcıId = 2002;

    Musterı musterı2 = new Musterı();
    musterı2.kullanıcıAdi = "Burak";
    musterı2.kullanıcıSoyad = "Özkol";
    musterı2.kullanıcıId = 1999;

    Musterı musterı3 = new Musterı();
    musterı3.kullanıcıAdi = "Burak";
    musterı3.kullanıcıSoyad = "Özkol";
    musterı3.kullanıcıId = 1999;

    Musterı musterı4 = new Musterı();
    musterı4.kullanıcıAdi = "Burak";
    musterı4.kullanıcıSoyad = "Özkol";
    musterı4.kullanıcıId = 1999;


    Musterı[] Musterıler = new Musterı[] { musterı1, musterı2, musterı3, musterı4 };


    foreach (var Musterı in Musterıler)
    {
        Console.WriteLine(Musterı.kullanıcıAdi + " : " + Musterı.kullanıcıSoyad + " : " + Musterı.kullanıcıId);
    }
}





















class Musterı
{
    public string kullanıcıAdi { get; set; }
    public string kullanıcıSoyad { get; set; }
    public int kullanıcıId { get; set; }
}