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
            List<string> sets = new List<string>();
            int n = int.MinValue;
            string result = "";      
            int index = 0;
            bool newRoll = true;
            for (int y = 0; y < numbers.Length; y++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (newRoll)
                    {
                        i = index;
                        newRoll = false;
                    }
                    if (n < numbers[i])
                    {
                        n = numbers[i];
                        result += " " + numbers[i].ToString();
                    }
                    if (n >= numbers[i+1] || i + 1 == numbers.Length)
                    {
                        sets.Add(result);
                        result = "";
                        index += i - index;
                        n = int.MinValue;
                        newRoll = true;
                        break;
                    }

                }
                if (index == numbers.Length-1)
                {
                    break;
                }
            }
            foreach (var set in sets)
            {
                Console.WriteLine(set.Trim());
            }
            Console.WriteLine("Longest: {0}",sets.Max().Trim());
        }
    } 
}
