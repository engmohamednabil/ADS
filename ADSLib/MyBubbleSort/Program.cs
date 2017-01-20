using System;

namespace MyBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, temp;
            int[] myArray = { 8 , 1 , 10 , 7 , 9 , 5 , 2};
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
                display(myArray);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        private static void display(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i].ToString() + " ");
        }
    }
}
