using System;
using System.Linq;

namespace _04.SequenceOfEqualStrings
{
    class FindEqual
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ').ToArray();
            //Find Equal strings with LINQ
            var same = strings.GroupBy(s => s);
            foreach (var stack in same)
            {
                for (int i = 0; i < stack.Count(); i++)
                {
                    Console.Write("{0} ", stack.Key);
                }
                Console.WriteLine();
            }
        }  
    }
}
