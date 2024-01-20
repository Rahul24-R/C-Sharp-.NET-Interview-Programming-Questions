/*
 * In This we are trying to reverse a given string using 
 * 1. The inbuilt reverse static method available in the Array class
 * 2. Using the for loop to iterate thrugh the char array which we crearted from ṭhe string and reversing the same
*/


namespace ReverseStringnameSpace
{
    public class ReverseString
    {
        string stringValue = "HelloWorld";
        public string ReverseStringFunctionWithInBuilt()
        {
            char[] charArray = stringValue.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ReverseStringFunctionLoop()
        {
            char[] charArray = stringValue.ToCharArray();
            char[] newCharArray = new char[charArray.Length];
            int j = 0;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                newCharArray[j++] = charArray[i];
            }
            return new string(newCharArray);
        }
    }
}
