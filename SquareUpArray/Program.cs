using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareUpArray
{
    class Program
    {
        static void Main(string[] args)
        {

            var squareUpArray = new SquareUpArray();
            int length = 25;

            squareUpArray.CreateArray(length);

        }
    }
}

//Given n>=0, create an array length n* n with the following pattern, shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).


//squareUp(3) → [0, 0, 1, 0, 2, 1, 3, 2, 1]
//squareUp(2) → [0, 1, 2, 1]
//squareUp(4) → [0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1] 