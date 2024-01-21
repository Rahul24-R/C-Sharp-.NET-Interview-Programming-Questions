/*
 * Given an array which has two occurances of each element, except one , find the unique element.
 * example arr = [4,1,2,1,3]
 * should return the value 4
 */


using System.Reflection.Metadata.Ecma335;

namespace UniqueElementInArray
{
    public class UniqueElement
    {
        int[] arr = new int[] { 4, 1, 2, 1, 3 };
        public int Unique()
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i))
                {
                    set.Remove(i);
                }
                else
                {
                    set.Add(i);
                }
            }
            return set.First();
        }
    }
}