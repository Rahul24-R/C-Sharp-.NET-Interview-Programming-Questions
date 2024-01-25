/*
 * From a list of numbers , find three numbers whos sum gives a pre -defined number.
 * for example arr = [-1,01,2,-1,-4] , output [[-1,-1,2],[-1,0,1]]   
 */

namespace _3Sum
{
    public class ThreeSum
    {
        int[] arr = new int[] { -1, 0, 1, 2, -1, -4 };
        int num = 0;

        public List<List<int>> ThreeSumList()
        {
            Array.Sort(arr);
            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                int j = i + 1;
                int k = arr.Length - 1;

                while (j < k)
                {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (sum < num)
                    {
                        j++;
                    }
                    else if (sum > num)
                    {
                        k--;
                    }
                    else
                    {
                        List<int> triplet = new List<int>() { arr[i], arr[j], arr[k] };
                        list.Add(triplet);
                        j++;
                        k--;
                    }
                }
            }

            return list;
        }
    }
}