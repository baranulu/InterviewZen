using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewZen_Q5
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            int[] sayilar = new int[9] { 2, 7, 99, 15, 13, 3, 22, 42, 21 };

            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = i; j < sayilar.Length; j++)
                {
                    if (sayilar[i] > sayilar[j])
                    {
                        x = sayilar[j];
                        sayilar[j] = sayilar[i];
                        sayilar[i] = x;
                    }

                }

            }
            Console.WriteLine();
            Console.Write("Küçükten Büyüğe Sıralanmış dizi: ");
            foreach (int deger in sayilar)
            {
                Console.Write(deger + " ");
            }
            Console.ReadKey();

        }
    }
}
