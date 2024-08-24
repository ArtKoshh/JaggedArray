using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Index                   0   1    2    3
            //normal array of type int : [4],[34],[24],[55]
            //    Index                                0                       1                       2  
            //Jagged array of type int:  [array1([15],[13],[5])],[array2([25],[3],[15])],[array3([55],[33],[51])]

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };


            Console.WriteLine("The value in the middle of first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}",i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
            }
        }

    }
}