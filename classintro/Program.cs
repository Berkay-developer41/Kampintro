// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

{
   

    Kurs kurs1 = new Kurs();
    kurs1.KursAdi = "C#";
    kurs1.Eğitmen = "Engin Demiroğ ";
    kurs1.İzlenmeOranı = 68;

    Kurs kurs2 = new Kurs();
    kurs2.KursAdi = "Java";
    kurs2.Eğitmen = "Kerem Varsa ";
    kurs2.İzlenmeOranı = 58;

    Kurs kurs3 = new Kurs();
    kurs3.KursAdi = "Python";
    kurs3.Eğitmen = "Berkay Bilgin ";
    kurs3.İzlenmeOranı = 95;

    Kurs kurs4 = new Kurs();
    kurs4.KursAdi = "C++";
    kurs4.Eğitmen = "Murat Kurtboğan ";
    kurs4.İzlenmeOranı = 100;



    Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

    foreach (var Kurs in Kurslar)

    {
        Console.WriteLine(Kurs.KursAdi + ":" + Kurs.Eğitmen);
      //Console.WriteLine(Kurs.KursAdi);
    }

    }





    class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int İzlenmeOranı { get; set; }
}