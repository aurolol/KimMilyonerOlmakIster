using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

class App
{
    static void Main(string[] args)
    {
        

        int correct = 0; // burada int correct değişkenini kullanıyorum çünkü yarışmacı bir sonraki soruya geçmesi için belli bir puan toplaması gerekiyor.

        Console.WriteLine("Kim Milyoner Olmak İster Yarışmamıza Hoş Geldiniz!");

        Console.WriteLine("1-> Türkiyenin kaç adet bölgesi vardır?"); // Soru 1-

        Console.WriteLine("A: 7   B: 4");

        string cevap1 = Console.ReadLine().ToLower(); // küçük harf büyük harf sorunu olmasın diye tolower değişkenini unutmuyoruz.



        if (cevap1 == "a")
        {
            correct++;
            Console.WriteLine("Doğru!");

        }
        else
        {

            Console.WriteLine("Yanlış!");
        }

        Console.WriteLine("2-> Renkleri sarı lacivert olan Türk takımı hangisidir?");  // Soru 2-

        Console.WriteLine("A: FB B: GS");

        string cevap2 = Console.ReadLine().ToLower();

        if (cevap2 == "a")
        {
            correct++;
            Console.WriteLine("Doğru!");

        }
        else
        {
            Console.WriteLine("Yanlış!");

        }
        if (correct == 2)  // eğer yarışmacı 2 adet soru bilgiği zaman yarışma bitiyor ve ödülü kazanıyor.
        {
            Console.WriteLine("Tebrikler 1 Milyon TL kazandınız!");
            return;
        }
        if (correct < 1) // eğer yarışmacı ilk 2 soruyu bilemezse otomatik olarak eleniyor.
        {
            Console.WriteLine("İlk iki soruyu yanlış cevapladınız ve elendiniz!");
            return;
        }

        Console.WriteLine("3-> Damlaya damlaya .... olur \n.... yerine hangisi gelmelidir? "); // Soru 3-

        Console.WriteLine("A: Deniz B: Göl");

        string cevap3 = Console.ReadLine().ToLower();

        if (cevap3 == "a")
        {
            Console.WriteLine("Yanlış!");
            Console.WriteLine("İki soruyu yanlış cevapladınız ve elendiniz!");
        }
        else
        {
            correct++;
            Console.WriteLine("Doğru!");
            Console.WriteLine("Tebrikler 1 Milyon TL kazandınız!");
        }
       
    }
}
