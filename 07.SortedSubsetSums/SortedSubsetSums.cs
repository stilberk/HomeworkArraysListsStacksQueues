using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SortedSubsetSums
{
    class SortedSubsetSums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] source = Console.ReadLine().Split(' ').Distinct().ToArray();
            List<List<int>> sets = new List<List<int>>();
            bool noMatch = true;
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
                    sets.Add(new List<int>(s));
                    //Console.Write(string.Join(" + ", s));
                    //Console.WriteLine(" = {0}", n);
                    noMatch = false;
                }
            }
            if (!noMatch)
            {
                List<List<int>> sortedSets = new List<List<int>>(sets);
                // Sort the sets  
                sortedSets.ForEach(set => set.Sort());
                var sortedList = sortedSets.OrderByDescending(l => l.Count()).ToList();
                sortedList.Reverse();
                foreach (var set in sortedList)
                {
                    Console.Write(string.Join(" + ", set));
                    Console.WriteLine(" = {0}", n);
                }
            }
            else
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
