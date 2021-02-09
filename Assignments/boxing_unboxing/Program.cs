using System;
using System.Collections.Generic;
namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create an empty List of type object
        List<object> things = new List<object>();
        //  Add the following values to the list: 7, 28, -1, true, "chair"
        things.Add(7);
        things.Add(28);
        things.Add(-1);
        things.Add(true);
        things.Add("chair");
        //  Loop through the list and print all values (Hint: Type Inference might help here!)
        foreach(var value in things){
            Console.WriteLine(value);
        }
        //  Add all values that are Int type together and output the sum
        int sum = 0;
        for(var i = 0; i < things.Count; i++){
            if(things[i] is int){
                sum += Convert.ToInt32(things[i]);
            }
        }
        Console.WriteLine($"Sum is {sum}");
        }
    }
}
