using HelperLib;

namespace MySelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, min , replacedIx=0;
            int[] myArray = { 3 , 9 , 5 , 8 , 7 , 66 , 80 , 22 , 30};
            for (int j = 0; j < myArray.Length; j++)
            {
                min = myArray[j];
                for (int i = j+1; i < myArray.Length; i++)
                {
                    if (min > myArray[i])
                    {
                        min = myArray[i];
                        replacedIx = i;
                    }
                }
                if (min != myArray[j])
                {
                    temp = myArray[j];
                    myArray[j] = min;
                    myArray[replacedIx] = temp;
                }
                Helpers.displayArrayData(myArray);
                System.Console.WriteLine();
            }
        }
    }
}
