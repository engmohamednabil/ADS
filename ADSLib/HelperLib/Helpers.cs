using System;

namespace HelperLib
{
    public class Helpers
    {
        public static void displayArrayData(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i].ToString() + " ");
        }
        public static int[] createRandomArray(int arraySize)
        {
            int[] arr = new int[arraySize];
            //The random number generation starts from a seed value. If the same seed is used repeatedly, 
            //the same series of numbers is generated.
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = Convert.ToInt32(rnd.NextDouble() * 100);
            }
            return arr;
        }
    }
}
