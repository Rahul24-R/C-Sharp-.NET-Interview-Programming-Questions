using ReverseStringnameSpace;


namespace ProgrammingQuestions
{
    class Program
    {
        static Dictionary<int, string> selectionOption = new Dictionary<int, string>()
        {
            {1,"ReverseString" }
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
                }
            }
        }
    }
}
