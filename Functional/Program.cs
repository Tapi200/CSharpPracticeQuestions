using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputList = new List<int> { 1, 2, 3,7,9 };
            IEnumerable<int> inputList2 =   from number in inputList
                                            where number > 2
                                            select number * 2;
            foreach(int i in inputList2)
                Console.WriteLine(i);
            Console.WriteLine("");

            var doubling = new Doubling();
            doubling.MultiplyByTwo(inputList);

            IEnumerable<int> inputList3 = inputList.Where(n => n < 3).Select(n=> n);

            Console.WriteLine("Input List 3");
            foreach(int n in inputList3)
                Console.WriteLine(n);
        }
    }
}


//Given a list of integers, return a list where each integer is multiplied by 2.
//doubling([1, 2, 3]) → [2, 4, 6]
//doubling([6, 8, 6, 8, -1]) → [12, 16, 12, 16, -2]
//doubling([]) → [] 
