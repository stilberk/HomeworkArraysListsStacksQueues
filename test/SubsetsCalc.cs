using System;
using System.Linq;

namespace test
{
    class SubsetsCalc
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());         
            string[] source = Console.ReadLine().Split(' ').ToArray();     
            for (int i = 0; i < Math.Pow(2, source.Length); i++)
            {
                string[] combination = new string[source.Length];
                for (int j = 0; j < source.Length; j++)
                {
                    if ((i & (1 << (source.Length - j - 1))) != 0)
                    {
                        combination[j] = source[j];
                    }
                }
                int sum = 0;
                var s = combination.Where(x => !String.IsNullOrEmpty(x)).Select(int.Parse);
                if (s.Sum() == n)
                {
                    Console.Write(string.Join(" + ", s));
                    Console.WriteLine(" = {0}",n);
                }
            }
        }
    }
}
