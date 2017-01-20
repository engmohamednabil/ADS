using HelperLib;

namespace MyInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 20 , 8 , 2 , 7 , 15 };
            int temp, x , y;
            for (int i = 1; i < myArray.Length; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    x = k;
                    y = k - 1;
                    if (myArray[x] < myArray[y])
                    {
                        temp = myArray[x];
                        myArray[x] = myArray[y];
                        myArray[y] = temp;
                    }
                }
                Helpers.displayArrayData(myArray);
                System.Console.WriteLine();
            }
        }
    }
}
