/*
 *Create a zero one Triangle
 *Example =
 *  1
 *  01
 *  101
 *  0101
 * 
 */

namespace ZeroOneTriangle
{
    public class ZeroOne
    {
        public void PrintZeroOneTriangle()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("1 ");
                    }
                    else { Console.Write("0 "); }
                }
                Console.WriteLine("\n");
            }
        }
    }
}