using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StuckNumbers
{
    class SubsetSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] source = Console.ReadLine().Split(' ').Distinct().ToArray();
            bool noMatching = true;
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
                var s = combination.Where(x => !String.IsNullOrEmpty(x)).Select(int.Parse);
                if (s.Sum() == n && s.Sum()!=0)
                {
                    Console.Write(string.Join(" + ", s));
                    Console.WriteLine(" = {0}", n);
                    noMatching = false;
                }
            }
            if (noMatching)
            {
                Console.WriteLine("No matching subsets.");
            }

        }
    }
}
