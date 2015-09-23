﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace _06.SubsetSum
{

    class SubsetSum
    {
        static int[] numbers;
        static int N;
        static bool solution = false;
      static   Stopwatch timer = new Stopwatch();
        static void Main()
        {
            Console.Write("Please, enter a value for N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a sequence of numbers, separated by a space: ");
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();
            timer.Start();
            //numbers = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("\nOutput:");
            List<int> subset = new List<int>();
            MakeSubset(0, subset);
            if (!solution)// if no sum matches N
                Console.WriteLine("No matching subsets.");
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
        }

        static void MakeSubset(int index, List<int> subset)
        {
            if (subset.Sum() == N && subset.Count > 0) // if subset sum = N, print it on the console
            {
                Console.WriteLine(" {0} = {1}", string.Join(" + ", subset), N);
                solution = true; // set solution to true, and we will not be printing that there is no solution
            }
            //Console.WriteLine(string.Join(" ", subset));
            for (int i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);
                MakeSubset(i + 1, subset); // call MakeSubset recursively, every time starting from the previous index + 1
                subset.RemoveAt(subset.Count - 1); // remove last element
            }
        }
    }
}
