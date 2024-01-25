using _3Sum;
using IntersectionOfArray;
using LeadersInArray;
using MissingElementInArray;
using ReverseStringnameSpace;
using SumOfDigits;
using SumofTwoElementInArray;
using System.Collections;
using UniqueElementInArray;

namespace ProgrammingQuestions
{
    class Program
    {
        static Dictionary<int, string> selectionOption = new Dictionary<int, string>()
        {
            {1,"ReverseString" },
            {2,"sumOfTwoElements" },
            {3,"IntersectionOfArray" },
            {4,"MissingElement" },
            {5,"SumOfDigits" },
            {6,"UniqueElementInArray" },
            {7,"3Sum" },
            {8,"LeadersInArray" }
        };
        static void Main()
        {
            Console.WriteLine("Welcome to C# Programming questions example");
            Console.WriteLine("Select the Programming Question as per below selecion option.Type the option number.\n");
            foreach( var selection in selectionOption )
            {
                Console.WriteLine(selection.Key+" - "+selection.Value);
            }
            int value = 0;
            if(int.TryParse(Console.ReadLine(),out value))
            {
                switch(value)
                {
                    case 1:
                        ReverseString revesreStringObj = new ReverseString();
                        Console.WriteLine(revesreStringObj.ReverseStringFunctionWithInBuilt());
                        Console.WriteLine(revesreStringObj.ReverseStringFunctionLoop());
                        break;
                    case 2:
                        ArrayElementSum arrayElementSumObj = new ArrayElementSum();
                        foreach( var arrayElement in arrayElementSumObj.SumOfElementsEfficient())
                        {
                            Console.WriteLine(arrayElement.ToString());
                        }
                        Console.WriteLine("From forLoop");
                        foreach(var arrayElement in arrayElementSumObj.SumOfElementsInArrayLoop())
                        {
                            Console.WriteLine(arrayElement);
                        }
                        break;
                    case 3:
                        ArrayIntersection arrayIntersectionObj = new ArrayIntersection();
                        foreach(var arrayElement in arrayIntersectionObj.ArrayIntersectionMethod())
                        {
                            Console.WriteLine(arrayElement.ToString()); 
                        }
                        break;
                    case 4:
                        MissingElement missingElementObj = new MissingElement();
                        Console.WriteLine(missingElementObj.MissingNumber());
                        break;
                    case 5:
                        SumOfDigitsOfNumber sumOfDigitsOfNumberObj = new SumOfDigitsOfNumber();
                        Console.WriteLine(sumOfDigitsOfNumberObj.SumOfDigits());
                        break;
                    case 6:
                        UniqueElement uniqueElementObj = new UniqueElement();
                        Console.WriteLine(uniqueElementObj.Unique());
                        break;
                    case 7:
                        ThreeSum threeSumObj = new ThreeSum();
                        foreach(var outerArray in threeSumObj.ThreeSumList())
                        {
                            foreach(var innerList in outerArray)
                            {
                                Console.Write(innerList.ToString());
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        ArrayLeaders arrayLeadersObj = new ArrayLeaders();
                        foreach (var item in arrayLeadersObj.Leaders())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }
        }
    }
}
