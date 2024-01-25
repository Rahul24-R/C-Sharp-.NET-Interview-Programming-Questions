/* Find all the leaders in an Array 
 * leaders in an array are the elements which which have elemts lesser than t hem to the left
 * example in an arr =[16,17,4,5,3,2] the elements 17,5,2 are the leaders in the array
 */

namespace LeadersInArray
{
    public class ArrayLeaders
    {
        int[] arr = new int[] { 16, 17, 4, 5, 3, 2 };
        public int[] Leaders()
        {
            List<int> list = new List<int>();
            int max = arr[arr.Length - 1];
            list.Add(max);
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    list.Add(arr[i]);
                    max = arr[i];
                }
            }
            return list.ToArray();

        }
    }
}