using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aCordinat = Convert.ToInt32(Console.ReadLine());
            int bCordinat = Convert.ToInt32(Console.ReadLine());
            int cCordinat = Convert.ToInt32(Console.ReadLine());
            int count = 0, xDist = cCordinat, yDist = cCordinat;
            while (xDist<= aCordinat)
            {
                count ++;
                xDist += cCordinat;
            }
            xDist = count;
            count = 0;
            while (yDist <= bCordinat)
            {
                count+=xDist;
                yDist += cCordinat;

            }
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
