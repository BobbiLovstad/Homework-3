using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Written By Bobbi Lovstad
// 2/16/25

namespace Homework3_CIS122
{
    public class MinMax
    {
        public int[] Value(int min, int max)
        {
            int max = Array[0];
            int min = Array[0];

            foreach (int x in Value)
            {
                if (x > max) { max = x; }
                if (x < min) { min = x; }
            }

            return [min, max];

        }
    }
}

public class solution
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5 }

        int[] output = solution.Value(num);

        Console.WriteLine("min is" + output[0];
        Console.WriteLine("Max is" + output[1];
    }
}

