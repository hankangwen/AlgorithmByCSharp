using System;
using System.Diagnostics;

namespace Algorithm
{
    public class BubbleSort : BaseClass
    {
        protected override void Start()
        {
            int[] intArray = {2, 1, 5, 4, 8, 9};
            int[] result = MySort(intArray);
            Print(result);
        }

        private int[] MySort(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        (intArray[i], intArray[j]) = (intArray[j], intArray[i]);
                    }
                }
            }

            return intArray;
        }
    }
}