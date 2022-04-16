using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

            string[] words;

            Console.WriteLine("Bir cümle giriniz:");
            string clause=Console.ReadLine();

            words = clause.Split(" ");

            Console.WriteLine("Cümlede {0} kelime var",words.Length);
             Console.WriteLine("Cümlede {0} harf var",clause.Length);

        }
    }
}
