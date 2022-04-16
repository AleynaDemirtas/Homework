using System;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
            
            


            Console.WriteLine("Pozitif bir sayı giriniz:");
            int n= Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            Console.WriteLine(n + " " + "adet sayı giriniz:");

            for(int i=0; i<n; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Çift Sayılar:");
            for(int j=0;j<n;j++)
            {
                if(sayilar[j] % 2==0)
                {
                    Console.Write(" " + sayilar[j] + "");
                }
                else
                    continue;

                
            }
            
            

             
        }
    }
}
