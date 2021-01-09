using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varMiYokMu_090121
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Antalya", "Ankara", "Bolu", "Denizli", "Kars", "Kastamonu" };
            Console.WriteLine("Bir şehir giriniz: ");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            int indexNo = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == girilenSehir)
                {
                    varMi = true;
                    indexNo = i;
                }

            }

            if (varMi)
            {
                Console.WriteLine($"{girilenSehir} array'de var, index numarası {indexNo}");
            }
            else
            {
                Console.WriteLine($"{girilenSehir} array'de yok.");
            }

            Console.ReadKey();


        }
    }
}
