using System;

namespace Proje2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan
             n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */

             

             Console.WriteLine("Pozitif iki sayı giriniz:");
             int n = Convert.ToInt32(Console.ReadLine());
             int m = Convert.ToInt32(Console.ReadLine());

             int[] sayilar = new int[n];

             Console.WriteLine(n +" "+ "adet sayı giriniz:");
             for(int i=0;i<n;i++)
             {
                  sayilar[i] = Convert.ToInt32(Console.ReadLine());
             }

             for(int i=0;i<n;i++)
             {
                 if(sayilar[i] % m == 0 || sayilar[i] == m)
                 {
                     Console.Write(" " + sayilar[i] + "");
                 }
                 else
                  continue;
             }

        }
    }
}
