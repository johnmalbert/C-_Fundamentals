using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");
            int[] res = RandomArray();
            Console.WriteLine("########################################################");
            string coin = TossCoin();
            Console.WriteLine("########################################################");
            Console.WriteLine(TossMultipleCoins(100));
            Console.WriteLine("########################################################");
            List<string> names = Names();
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static int[] RandomArray()
        {
        // Create a function called RandomArray() that returns an integer array

        // Place 10 random integer values between 5-25 into the array
        // Print the sum of all the values
        // Print the min and max values of the array
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++){
                arr[i] = rand.Next(5,26);
                // Console.WriteLine($"arr[{i}] is {arr[i]}");
            }
            // Print min and max
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(min > arr[i]){
                    min = arr[i];
                }
                if(max < arr[i]){
                    max = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine($"The max value is {max}");
            Console.WriteLine($"The min value is {min}");
            Console.WriteLine($"The sum is {sum}");

            return arr;
        }

        public static string TossCoin()
        {
            // Create a function called TossCoin() that returns a string
            // Have the function print "Tossing a Coin!"
            // Randomize a coin toss with a result signaling either side of the coin 
            // Have the function print either "Heads" or "Tails"
            // Finally, return the result
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();

            int hcount = 0;
            int tcount = 0;
            string coin = "";
            for(int i = 0; i < 1; i++)
            {
                int result = rand.Next(1,3);
                // Console.WriteLine(result);
                if(result == 1)
                {
                    coin = "Heads";
                    hcount++;
                }
                else{
                    coin = "Tails";
                    tcount++;
                }
            }
            // Console.WriteLine($"Heads: {hcount}, Tails: {tcount}");
            Console.WriteLine(coin);
            return coin;
        }
        public static double TossMultipleCoins(int num)
        {
        //         Create another function called TossMultipleCoins(int num) that returns a Double
        // Have the function call the tossCoin function multiple times based on num value
        // Have the function return a Double that reflects the ratio of head toss to total toss
            int hcount = 0; 
            for(int i = 0; i < num; i++){
                string coin_result = TossCoin();
                if(coin_result == "Heads"){
                    // Console.WriteLine("It's heads");
                    hcount++;
                }
            }
            double ratio = (double) hcount/num;
            // Console.WriteLine($"{hcount}, {num}, {ratio}");
            return ratio;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            // Names
            // Build a function Names that returns a list of strings.  In this function:
            List<string> shuffledNames = new List<string>();
            int[] shuffle = Shuffle(5);
            for(int i = 0; i < names.Count; i++)
            {  
                int next = shuffle[i] - 1;
                shuffledNames.Add(names[next]);
            }
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // Shuffle the list and print the values in the new order
            for(int i = 0; i < shuffledNames.Count; i++)
            {
                if(shuffledNames[i].Length <= 5)
                {
                    shuffledNames.Remove(shuffledNames[i]);
                }
            }
            // Return a list that only includes names longer than 5 characters
            return shuffledNames;
        }

        public static int[] Shuffle(int num)
        {
            Random rand = new Random();
            int[] arr = new int[num];
            arr[0] = rand.Next(1,num + 1);
            // populate each value of the array:
            for(int i = 0; i < num; i++)
            {
                // if the random number already exists in the array, get a new random number
                int check = rand.Next(1,num + 1);
                for(int j = 0; j < num; j++){
                    // Console.WriteLine($"Checking {arr[j]} and {check}");
                    if(arr[j] == check){
                        check = rand.Next(1,num + 1);
                        // Console.WriteLine("Changed check");
                        j = -1;
                    }
                }
                arr[i] = check;
                // if it doesn't exist, assign it to the next position in the array
            }

            return arr;
        }
    }
}
