/* Given an array and the final element in the array to be n, find the missing  , example n=9, arr= [1,2,3,4,5,6,7,9], here the elemrnt 8 is missing.
 * 
 */

namespace MissingElementInArray
{
    public class MissingElement
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 9 };
        int n = 9;

        public int MissingNumber()
        {
            return (((n*(n+1))/2)-arr.Sum());
        }
    }
}