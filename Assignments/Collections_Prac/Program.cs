using System;
using System.Collections.Generic;

namespace Collections_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Creating variables
                Initializing/Iterating collection types
                Practice using built-in methods for Lists/Dictionaries
           */
        int x = 5;
        int y = 6;
        Console.WriteLine(x + y);

        List<string> discs = new List<string>();
        discs.Add("Destroyer");
        discs.Add("Nuke");
        discs.Add("Mantis");
        discs.Add("Banger GT");

        foreach(string disc in discs){
            Console.WriteLine(disc);
        }
        // Create an array to hold integer values 0 through 9
        int[] array = new int[10];
        for(int i = 0; i < array.Length; i++){
            array[i] = i;
        }
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine("###################################################################");
        // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
        for(int i = 0; i < nameArray.Length; i++){
            Console.WriteLine(nameArray[i]);
        }
        // Create an array of length 10 that alternates between true and false values, starting with true
            Console.WriteLine("###################################################################");
            bool[] boolArray = new bool[10];
            for(int i = 0; i < boolArray.Length; i++){
                if(i % 2 == 0){
                    boolArray[i] = true;
                }else{
                    boolArray[i] = false;
                }
            }
            for(var i = 0; i < boolArray.Length; i++){
                Console.WriteLine(boolArray[i]);
            }
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            Console.WriteLine("###################################################################");
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Rocky Road");
            flavors.Add("Strawberry");
            flavors.Add("Vanilla");
            flavors.Add("Cookie Dough");
            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.Remove("Strawberry");
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count);

            Console.WriteLine("###################################################################");

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> names = new Dictionary<string, string>();
            Random rand = new Random();
            for(var i = 0; i < nameArray.Length; i++){
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
                int randomNum = rand.Next(0,flavors.Count);
                names.Add(nameArray[i], flavors[randomNum]);
            // each value is a randomly select a flavor from your flavors list.
            }
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(var entry in names){
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }
    }
}
