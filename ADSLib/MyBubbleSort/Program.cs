﻿using System;
using HelperLib;

namespace MyBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, temp;
            int[] myArray = Helpers.createRandomArray(10);
            for (j = myArray.Length-1; j > 1; j--)
            {
                for (i = 0; i < j; i++)
                {
                    k = i;
                    if (myArray[k++] > myArray[k])
                    {
                        temp = myArray[k];
                        myArray[k] = myArray[k-1];
                        myArray[k-1] = temp;
                    }
                }
                Helpers.displayArrayData(myArray);
                Console.WriteLine();
            }
        }
    }
}
