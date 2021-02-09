using System;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            PrintOdds();
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            PrintSum();
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            int[] nums = new int[] {10,9,8,7,-6,5,4,3,2,1,-1,12,5};
            LoopArray(nums);
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            Console.WriteLine($"The max is {FindMax(nums)}");
            Console.WriteLine("##########################################################");
            GetAverage(nums);
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            int[] result = (OddArray());
            LoopArray(result);
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            Console.WriteLine($"There are {GreaterThanY(nums,3)} numbers greater than 3");
            Console.WriteLine("##########################################################");
            SquareArrayValues(nums);
            Console.WriteLine("##########################################################");
            Console.WriteLine();
            int[] nums2 = new int[] {-10,9,8,7,-6,5,4,3,2,1,-1,12,5};
            EliminateNegatives(nums2);
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            MinMaxAverage(nums2);
            Console.WriteLine("##########################################################");
            ShiftValues(nums2);
            Console.WriteLine();
            Console.WriteLine("##########################################################");
            int[] nums3 = new int[] {-10,9,-58,-7,-6,5,-4,-3,2,1,-1,12,5};
            object[] res = NumToString(nums3);
            LoopObject(res);
        }
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for(var i = 0; i < 256; i++){
                Console.Write(i + ", ");
            }
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for(var i = 1; i < 256; i=i+2){
                Console.Write(i + ", ");
            }
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            int sum = 0;
            for(int i = 0; i < 256; i++){
                sum += i;
                Console.WriteLine($"New Number: {i} Sum: {sum}");
            }

        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            Console.Write("[");
            for(int i = 0; i < numbers.Length; i++){
                Console.Write(numbers[i] + ",");
            }
            Console.Write("]");
        }
        public static void LoopObject(object[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            Console.Write("[");
            for(int i = 0; i < numbers.Length; i++){
                Console.Write(numbers[i] + ",");
            }
            Console.Write("]");
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++){
                if(max < numbers[i]){
                    max = numbers[i];
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            double avg = 0;
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            for(int i = 0; i < numbers.Length; i++){
                avg += numbers[i];
            }
            avg = avg/numbers.Length;
            Console.Write(avg);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            int[] arr = new int[(256/2)];
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            for(int i = 1; i < 256; i=i+2){
                arr[(i-1)/2] = i;
            }
            return arr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count++;
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = numbers[i] * numbers[i];
            }
            LoopArray(numbers);
        }
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0 - numbers[i];
                }
            }
            LoopArray(numbers);
        }
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            int min = numbers[0]; 
            int max = numbers[0];
            double avg = 0;
            // the minimum value in the array, and the average of the values in the array.
            for(int i = 0; i < numbers.Length; i++){
                if(min > numbers[i]){
                    min = numbers[i];
                }
                if(max < numbers[i]){
                    max = numbers[i];
                }
                avg = avg + (numbers[i]);
            }
            avg = avg/numbers.Length;
            Console.WriteLine($"Min - {min}");
            Console.WriteLine($"Max - {max}");
            Console.WriteLine($"Average - {avg}");
        }
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for(int i = 0; i < numbers.Length-1; i++){
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            LoopArray(numbers);
        }
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] newArr = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    newArr[i] = "Dojo";
                }
                else{
                    newArr[i] = numbers[i];
                }
            }
            return newArr;
        }

    }
}
