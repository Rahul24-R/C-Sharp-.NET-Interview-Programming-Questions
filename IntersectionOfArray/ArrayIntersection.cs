/*
 * Given two array of size m and n, create anoher array with the common elements of the two array
 * 
 */


namespace IntersectionOfArray
{
    public class ArrayIntersection
    {
        int[] arr1 = new int[] { 1, 4, 7, 9, 3 };
        int[] arr2 = new int[] { 7, 6, 5, 4, };

        public int[] ArrayIntersectionMethod()
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            List<int> list = new List<int>();
            int n = arr1.Length;
            int m = arr2.Length;
            int i = 0;
            int j = 0;
            while (i < n && j < m)
            {
                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr1[i] > arr2[j])
                { 
                    j++;
                }
                else
                {
                    list.Add(arr1[i]);
                    i++;
                    j++;
                }
            }
            return list.ToArray();
        }
    }
}