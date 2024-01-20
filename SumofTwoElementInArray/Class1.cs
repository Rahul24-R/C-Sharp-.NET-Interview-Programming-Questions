/*
 *Given an array of integers , find all pair of elements in that array , that when added, gives a pre-defined number
 * example arr =[1,3,5,7,2,5,2,6,8], num = 10
 * elements (2,8) , (5,5) and (3,7) when added gives 10 
 */

namespace SumofTwoElementInArray
{
    public class ArrayElementSum
    {
        int[] intArray = new int[] { 1, 3, 5, 7, 2, 5, 2, 6, 8 };
        int num = 10;
        
        public List<string> SumOfElementsEfficient()
        {
            List<string> result = new List<string>();
            HashSet<int> set = new HashSet<int>();
            foreach (int i in intArray)
            {
                int val = num - i;
                if(set.Contains(val))
                {
                    result.Add($"{i},{val}");
                }
                else
                {
                    set.Add(i);
                }
            }
            return result;
        }

        public List<string> SumOfElementsInArrayLoop()
        {
            List<string>result = new List<string>();
            for(int i = 0; i < intArray.Length-1; i++)
            {
                for(int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] + intArray[j] == num)
                    {
                        result.Add($"{intArray[i]},{intArray[j]}");
                    }
                }
            }
            return result;
        }
    }
}