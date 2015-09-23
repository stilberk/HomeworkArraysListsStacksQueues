using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortArrayBySelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> sortedNumbers = new List<int>();
            int min = int.MaxValue;
            int index = -1;
            int elementsCount = numbers.Count;
            for (int yi = 0; yi < elementsCount; yi++)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]<min)
                    {
                        min = numbers[i];
                        index = i;
                    }
                    if (i==numbers.Count-1)
                    {
                        numbers.RemoveAt(index);
                        //sortedNumbers.Add(min);
                        Console.Write("{0} ",min);
                        min = int.MaxValue;
                    }
                }  
            }
            //Console.WriteLine(string.Join(" ",sortedNumbers));
        }
    }
}
