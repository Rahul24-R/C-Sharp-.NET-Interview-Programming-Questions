/* Given a number , find the sum of the digits of a number , till the sum is a single digit number
 * Example num = 38 -> 3+8=11 -> 1+1 = 2, return 2
 */

namespace SumOfDigits
{
    public class SumOfDigitsOfNumber
    {
        int num = 38;
        public int SumOfDigits()
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;

                if(num==0 && sum > 9)
                {
                    num = sum;
                    sum = 0;
                }
            }
            return sum;
        }

    }
}