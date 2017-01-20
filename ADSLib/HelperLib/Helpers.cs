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
    }
}
