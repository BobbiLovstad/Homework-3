using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bobbi Lovstad
// 2/16/25

namespace Homework3_CIS122
{
    public class ValueMultiplier
    {
        public int multiplier (int[] arr)
        {
            int size = 0;

            foreach( int x in arr)
            {
                for (int x =0;x<size.Length; x++)
                {
                    arr[x] = arr[x] * size 
                }

            }
        }
    }
}

public class solution
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5 }
        ArrayMultiplier multiply = new ArrayMultiplier();
        multiply.multiplier(num);

        Console.WriteLine("updated array");

        for (int x = 0; x < num.Length; x++)
        {
            Console.WriteLine(num[x] + "is the value");
        }
    }


}
