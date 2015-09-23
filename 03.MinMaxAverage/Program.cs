using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxAverage
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(new[]{' ','\t'}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            List<int> nonfloat = new List<int>();
            List<double> floatnum = new List<double>();
            foreach (var num in numbers)
            {
                if (num %1 == 0)
                {
                    nonfloat.Add((int)num);
                }
                else
                {
                    floatnum.Add(num);
                }
            }
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",string.Join(" ",floatnum),floatnum.Min(),floatnum.Max(),floatnum.Sum(),floatnum.Average());
            Console.WriteLine("[{0}] -> min: {1}, man:{2}, sum: {3}, avg {4:f2}", string.Join(" ", nonfloat),nonfloat.Min(),nonfloat.Max(),nonfloat.Sum(),nonfloat.Average());
        }
    }
}
