using System;
using System.Collections;
namespace dizilerr
{
    class Program
    {
        static void Main(string[] args)
        {
    //dizi tanımı
     string[] renkler= new String[10];
    // Console.WriteLine("sorun yok");

    string[] hayvanlar= {"kedi","köpek","kuş","Maymun"};
    
     int[] dizi;
     dizi= new int[5];
    //dizilere değer atama ve erişim
      renkler[8]= "mavi";
       dizi[3]= 10;

      Console.WriteLine(hayvanlar[1]);
      Console.WriteLine(dizi[3]);
      Console.WriteLine(renkler[0]);

      //döngülerle dizi kullanımı
      Console.WriteLine("Lütfen dizinin elemen sayısını giriniz:");
      int diziUzunlugu= int.Parse(Console.ReadLine());
      int [] sayiDizisi= new int[diziUzunlugu];

      for(int i=0 ; i<diziUzunlugu; i++)
      {
        Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
        sayiDizisi[i]= int.Parse(Console.ReadLine());

      }
      int toplam= 0;
      foreach (var sayi in sayiDizisi)
      {
        toplam+= sayi;
      }
      Console.WriteLine("Ortalama :" +toplam/diziUzunlugu);

  }

    }
}
