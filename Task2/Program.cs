using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int countPlus = 0, countMinus = 0;
            int sumPlus = 0, sumMinus = 0;
            do
            {
                
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number > 0)
                {
                    countPlus++;
                    sumPlus += Number;
                }
                else 
                    if (Number < 0)
                        {
                            countMinus++;
                            sumMinus += Number;
                        }
                
                
            } while (Number!=0);
            if (countPlus > countMinus)
            {
                Console.WriteLine("Количество положительных больше: {0}. Общая сумма составляет: {1}", countPlus, sumPlus);
            }
            else if(countMinus > countPlus)
                {
                Console.WriteLine("Количество отрицательных больше: {0}. Общая сумма составляет: {1}", countMinus, sumMinus);
                }
            else 
            {
                Console.WriteLine("Error!");
            }
            Console.ReadKey();


        }
    }
}
