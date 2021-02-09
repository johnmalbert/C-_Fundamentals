using System;
using System.Collections.Generic;

namespace FirstDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}");

            //random numbers
            Random rand = new Random();
            for(int i = 0; i < 3; i++){
                Console.WriteLine(rand.NextDouble());
            }
            //arrays
            int[] array = {1,2,3,4,6};
            
            for(int i = 0; i < array.Length; i++){
                Console.WriteLine(array[i]);
            }

            //using foreach
            string[] myCars = { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
            foreach(string car in myCars){
                Console.WriteLine($"I own a {car}");
            }
            myCars[3] = "Little Car";
            Console.WriteLine(myCars[3]);
            //Lists
            List<int> faveNums = new List<int>();
            
            faveNums.Add(37);
            faveNums.Add(22);
            faveNums.Add(5);
            Console.WriteLine(faveNums[1].ToString());
            Console.WriteLine(faveNums[2]);
            Console.WriteLine(faveNums.Count);

            faveNums.Remove(22);
            faveNums.RemoveAt(0);
            Console.WriteLine(faveNums[0]);

            //Dictionaries!
            Dictionary<string,string> profile = new Dictionary<string,string>();

            profile.Add("Name", "John");
            profile.Add("Age","27");
            profile.Add("Weight","205");
            profile.Add("Gender","Male");
            Console.WriteLine("Player Profile:");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("Age - " + profile["Age"]);
            Console.WriteLine("Weight - " + profile["Weight"]);
            Console.WriteLine("Gender - " + profile["Gender"]);

            // iterate through dictionary using foreach
            foreach (KeyValuePair<string,string> entry in profile){
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            //alternatively...
            foreach(var entry in profile){
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            Vehicle v = new Vehicle(5);
            Console.WriteLine($"Vehicle has {v.passengers} passengers");
        }
    }
    class Vehicle
    {
        public int passengers;
        public Vehicle(int value){
            passengers = value;
        }
    }
}
