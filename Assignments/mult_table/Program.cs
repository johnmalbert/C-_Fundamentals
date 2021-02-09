using System;

namespace mult_table
{
    class Program
    {
        static void Main(string[] args)
        {
        //  Build a multidimentional array that stores the above values.
        int [,] multTable = new int[10,10];
        for(int i = 0; i < 10; i++){
            Console.Write("[");
            for(int j = 0; j < 10; j++){
                multTable[i,j] = (i+1) * (j+1);
                Console.Write(multTable[i,j] + ",\t");
            }
            Console.WriteLine("]");
        }
        //  (Bonus) Write the values to the console, so that it resembles the above table.
        }
    }
}
