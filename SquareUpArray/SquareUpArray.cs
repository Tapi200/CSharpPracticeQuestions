using System;

namespace SquareUpArray
{
    class SquareUpArray
    {
        public void CreateArray(int length)
        {
            var arr = new int[length * length];

            for (int j = 1; j <= length; j++)
            {
                for (int i = 0; i < length * j; i++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        if (j - k > 0)
                        {
                            arr[j * length - (j - k)] = j - k;
                        }
                    }

                }

            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}

//Given n>=0, create an array length n* n with the following pattern, shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).


//squareUp(3) → [0, 0, 1, 0, 2, 1, 3, 2, 1]
//squareUp(2) → [0, 1, 2, 1]
//squareUp(4) → [0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1] 