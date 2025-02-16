using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Written by Bobbi Lovstad
//2/16/25

namespace Homework3_CIS122
{
   public class AbsoluteValue
    {
        public int sumValues (int[] arr)
        {
            int sum = 0;

            for (int x< 0; x < arr.Length; x++)
            {
                int values(arr[0] <0) ?-arr: arr[x];

                sum += values 

            }
            return sum;
        }
    }
}


public class solution
{
    public static void Main(string[] args)
    {
        int num = { 1.2.3.4.5 }

        AbsoluteValue calculator = new AbsoluteValue();

        int answer = calculator.sumValues(num);

        Console.WriteLine("sum is" + answer);
    }
}

