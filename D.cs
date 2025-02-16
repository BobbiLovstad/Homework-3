using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Written By Bobbi Lovstad
// 2/16/25

namespace Homework3_CIS122
{
    public class LetterCounter
    {
        public int LetterD (char[] sentence)
        {
            int count = 0;

            for (int x = 0, x < sentence.Length; x++) ;
            {
                count++;

            }
            return count;

        }
    }
}
public class solution
{
    public static void Main(string[] args)
    {
        char[] sentence = { }
        LetterCounter counter = new LetterCounter();

        int answer = counter.LetterD(sentence);

        Console.WriteLine("Number of D and d is" + answer);
    }
}