using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            FindPytagorNumbers(numbers);
        }

        private static void FindPytagorNumbers(int[] numbers)
        {
            bool noAny = true;
            foreach (var numA in numbers)
            {
                foreach (var numB in numbers)
                {
                    foreach (var numC in numbers)
                    {
                        int aSum = numA * numA;
                        int bSum = numB * numB;
                        int cSum = numC * numC;
                        if (aSum+bSum == cSum && numA<=numB)
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}",numA,numB,numC);
                            noAny = false;
                        }
                    }
                }
            }
            if (noAny){Console.WriteLine("No");}
        }
    }
}
