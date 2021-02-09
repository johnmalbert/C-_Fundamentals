using System; // like an import statement!
using System.Collections.Generic;

namespace HelloDotNetCore   // matches name of project
{
    class Program // main program being run
    {
        static void Main(string[] args) // will run Main every time, called the entry point to the app
        // static : means that whenever method is called, it doesn't have to be connected to object. Allows you to call function directly from the class.
        // void: return type
        {
            Console.WriteLine("Hello World!");

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            // Math myMathInstance = new Math(); //without static in method

            int result = Math.add(1,2); // becuase Math is listed as static, we don't have to create an instance of Math. 
            Console.WriteLine(result);

            int[] myArr = {1,2,3,4};

            foreach(int val in myArr)
            {
                Console.WriteLine($"The value is {val}");
            }

            // lists - more flexible than arrays

            List<string> myList = new List<string>();

            myList.Add("Nick");
            myList.Add("CJ");
            myList.Add("John");
            myList.Add("Tino");

            myList.Remove("CJ");

            foreach(string person in myList)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine($"There are {myList.Count} people");

            Dictionary<string, object> myDict = new Dictionary<string, object>();
            myDict.Add("Age", 25);
        }

    }
    class Math 
    {
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
