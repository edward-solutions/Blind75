using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public class MostWordsFound
    {
        public int Solution(string[] sentences)
        {
            //count each words in each sentence inside the sentences array
            //return the count
            int count = 0;

            foreach (string sentence in sentences)
            {
                var test = sentence.Split(' ');
                Console.WriteLine(test.Count());
                count = Math.Max(count, test.Count());
            }
            return count;
        }
    }
}
