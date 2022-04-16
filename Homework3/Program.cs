using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */

            Console.WriteLine("Bir adet pozitif tam sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[n];
            Console.WriteLine(n +" "+ "adet kelime giriniz:");

            for(int i=0;i<n;i++)
            {
               words[i]= Console.ReadLine();
            }

            foreach (var item in words)
            {
                Console.Write(" " +item+" ");
            }
        }
    }
}
