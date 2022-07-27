// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
	string kurs1 = "Yazılım Geliştirici Yetiştrime Kampı";
	string kurs2 = "Programlamaya başlangıç için temel kurs";
	string kurs3 = "java";
	string kurs4 = "Python";
	string kurs5 = "C#";

	Console.WriteLine(kurs1);
    Console.WriteLine(kurs2);
    Console.WriteLine(kurs3); 
    Console.WriteLine(kurs4);
    Console.WriteLine(kurs5);
    //array - dizi

    string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştrime Kampı", "Programlamaya başlangıç için temel kurs","Java","Python","C#" };



	for (int i = 0; i < kurslar.Length; i++)
	{
		Console.WriteLine(kurslar[i]);

	}
	Console.WriteLine("For Bitti");
	foreach (string kurs in kurslar)

	{
		Console.WriteLine(kurs);
	}
	{

	}
        Console.WriteLine("sayfa sonu - footer");
    
}