using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp1    
{
    class Program
    {
        // do while - oldukca, sagladıgı surece calıs
        public static int sayi2 = 0;
        static void Main(string[] args)
        {
            int sayi = 0;
            do
            {
                sayi++;                     // sayi++ if continue den sonra yazar ise sonsuz dongü girer loop tamamlanamaz
                if (sayi == 7) continue;        // continue yazar isek yazdıgımız sayiyi atlar sayi++ ifden once yazmalıyız
                Console.WriteLine(sayi);   // sayi 10dan kucuk oldukca calısacak
                
               // break;           break yazarsak sadece 1 kere calısır.
            } while (sayi < 10);   // true de yazabiliriz yukardaki secenekleri sagladıgı surece calıs gibi

            while (sayi < 10)           // do while ile while arasinda kullanim bize kalmis
            {
                sayi++;
                if (sayi == 7) continue;
                Console.WriteLine(sayi);
            }
            
            Console.ReadLine(); 

        }
            
          
      
        
    }
}
