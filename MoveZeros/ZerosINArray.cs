/*
 * In a given array , write a code to move all the zeros in the array to the end
 * arr = [1,0,2,0,5,0,6,7,8]
 */

namespace MoveZeros
{
    public class ZerosINArray
    {
        int[] arr = new int[] { 1, 0, 2, 0, 5, 0, 6, 7, 8 };
        public int[] MoveZerosInArray()
        {
            int i = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                }
            }
            return arr;
        }

    }
}