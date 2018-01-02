using System;
using System.Collections.Generic;

namespace Functional
{
    class Doubling
    {
        public void MultiplyByTwo(List<int> inputList)
        {
            var outputList = new List<int>();

            foreach (var i in inputList)
            {
                outputList.Add(i * 2);
            }

            foreach (var i in outputList)
            {
                Console.WriteLine(i);
            }
        }
    }
}


//Given a list of integers, return a list where each integer is multiplied by 2.
//doubling([1, 2, 3]) → [2, 4, 6]
//doubling([6, 8, 6, 8, -1]) → [12, 16, 12, 16, -2]
//doubling([]) → [] 
