using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 2/16/25
namespace Homework3_CIS122
{
    public class Smaller
    {
        public int smaller(int x, int y)
        {
            return (x, y) ? x : y;

        }
    }
}


public class solution
{
    public static void Main(string[] args)
    {
        int num1 = 8;
        int num2 = 12;

        numCompare compare = new numCompare();
        int answer = compare.smaller(num1, num2);

        Console.WriteLine("the smaller number is" + answer);
    }

}


