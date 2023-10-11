using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sayisi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 5000 arasındaki fibonacci sayı dizisini ekrana yazdıran programı yazınız. (1 1 2 3 5 8 13...)

            int x = 1, y = 1, z;

            Console.WriteLine(x);
            Console.WriteLine(y);

            for (int i = 0; i < 17; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.WriteLine(z);
            }
            Console.ReadLine();
        }
    }
}
