 using System;
 namespace odev1
 {
     class Program

     {
         static void Main(string[] args)
         {
             ///Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            /// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş 
            ///olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi=new int[diziUzunlugu];


            for (int i = 0; i < diziUzunlugu; i++)
            {
                  Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
                  sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayi in sayıDizisi)
            {
                if(sayi%2 == 0)
                Console.WriteLine(sayi);
                
            }
         }
     }
public class soru2
{
    static void soru_2()
    {
         ///Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            /// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu 
            /// sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


            Console.WriteLine("Lütfen pozitif iki sayı giriniz:");
            int diziUzunlugu =int.Parse(Console.ReadLine());
            int sayi =int.Parse(Console.ReadLine());
            int[] dizi = new int[diziUzunlugu];
            
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz " ,i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayilar in dizi)
            {
                //if(sayilar == sayi || sayilar/sayi ==0 )

                if ( sayilar == sayi || sayi%sayilar == 0)
                Console.WriteLine(sayilar);
            }
    }
}
public class soru3
{
    static void soru_3()
    {
       ///Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı 
            //kelimeleri sondan başa doğru console'a yazdırın.


            Console.Write("Lütfen pozitif bir sayı giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            string[] dizi = new string[diziUzunlugu];

            Console.WriteLine("Lütfen girdiğiniz sayı kadar kelime giriniz.");

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}.kelimeyi giriniz: ",i+1);
                dizi[i] = Console.ReadLine();
            }

            int son = dizi.Length-1;

            for (int i = son; i >= 0; --i)
            {
                Console.WriteLine(dizi[i]);
            }
    }
}

public class soru4
{
    static void soru_4()
    {
       //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Lütfen bir cümle yazınız:");
            string cümle = Console.ReadLine();

            

            string [] dizi = cümle.Split(' ');
            Console.WriteLine("Kelime sayısı:"+ dizi.Length);
            Console.Write("Harf sayısı:"+cümle.Length);

            
    }
}


 }     

 

            
            
            
