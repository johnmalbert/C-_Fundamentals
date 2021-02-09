using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //create loop that prints from 1-255
            for(int i = 1; i < 256; i++){
                Console.Write(i + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("######################################################");
            Console.WriteLine("");
            //create loop that prints all values from 1-100 that are divisible by 3 or 5
            for(int i = 1; i < 101; i++){
                if(i % 5 == 0 || i % 3 == 0){
                    if(!(i % 5 == 0 && i % 3 == 0)){
                        Console.Write(i + ", ");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("######################################################");
            Console.WriteLine("");
            for(int i = 1; i < 101; i++){
                if(i % 5 == 0 || i % 3 == 0){
                    if(i % 5 == 0 && i % 3 == 0){
                        Console.WriteLine($"{i} FizzBuzz");
                    }
                    else if(i % 3 == 0){
                        Console.WriteLine($"{i} Fizz");
                    }
                    else{
                        Console.WriteLine($"{i} Buzz");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("######################################################");
            Console.WriteLine("");
            int count = 1;
            while(count <= 255){
                Console.Write(count + ", ");
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("######################################################");
            Console.WriteLine("");
            count = 1;
            while(count <= 100){
                if(count % 5 == 0 || count % 3 == 0){
                    if(!(count % 5 == 0 && count % 3 == 0)){
                        Console.Write(count + ", ");
                    }
                }
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("######################################################");
            Console.WriteLine("");
            int j = 1;
            while(j <= 100){
                if(j % 5 == 0 || j % 3 == 0){
                    if(j % 5 == 0 && j % 3 == 0){
                        Console.WriteLine($"{j} FizzBuzz");
                    }
                    else if(j % 3 == 0){
                        Console.WriteLine($"{j} Fizz");
                    }
                    else{
                        Console.WriteLine($"{j} Buzz");
                    }
                }
                j++;
            }
        }
    }
}
