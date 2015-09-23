using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestIncreasingSequence
{
    class LongestIncrSeq
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sets = GetIncreasingSequences(numbers);
            // Print all sets 
            foreach (var set in sets){Console.WriteLine(set.Trim());}
            //Find the longest set
             Console.WriteLine("Longest: {0}", FindLongestSet(sets));
        }

        private static string FindLongestSet(List<string> sets)
        {
            int a = 0;
            string longest = "";
            foreach (var set in sets)
            {
                if (set.Split(' ').Count() > a)
                {
                    longest = set;
                    a = set.Split(' ').Count();
                }
            }
            return longest;
        }

        private static List<string> GetIncreasingSequences(int[] numbers)
        {
            List<string> sets = new List<string>();
            int n = int.MinValue;
            string result = "";
            int index = 0;
            bool newRoll = true;
            for (int y = 0; y < int.MaxValue; y++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (newRoll)
                    {
                        i = index;
                    }

                    if (true)
                    {
                        n = numbers[i];
                        result += " " + numbers[i].ToString();
                        if (i + 1 > numbers.Length - 1) { goto pass; }
                        if (newRoll && numbers[i + 1] != numbers[i] && numbers[i + 1] > numbers[i])
                        {
                            result += " " + numbers[i + 1].ToString();
                            i++;
                            n = numbers[i];
                        }
                        pass:
                        newRoll = false;
                    }
                    if (i + 1 == numbers.Length)
                    {
                        sets.Add(result);
                        index = ++i;
                        result = "";
                        newRoll = true;
                        break;
                    }
                    if (numbers[i] >= numbers[i + 1])
                    {
                        sets.Add(result);
                        index = ++i;
                        result = "";
                        newRoll = true;
                        break;
                    }
                }
                if (index == numbers.Length)
                {
                    break;
                }
            }
            return sets;
        }
    } 
}
