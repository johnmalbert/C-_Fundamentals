using System;
using System.Collections.Generic;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student kyle = new Student("Kyle", "Marymee");
            Student larry = new Student("Larry", "Metcalf", 89);
            Student fletcher = new Student("Fletcher", "Albert", 110);
            List<Student> students = new List<Student>() {
                kyle,
                larry,
                fletcher
            };
            fletcher.MyPrivateProperty = "cool!";
            Console.WriteLine(fletcher.MyPrivateProperty);
            // notice the type variance here, var. 
            foreach(var stud in students)
            {
                Console.WriteLine(stud);
            }

        }
    }

    public class Student
    {
        //these are fields: 
        public string FirstName;
        public string LastName;
        public int energy{get;set;}

        private string myPrivateField;

        public string MyPrivateProperty {
            get
            {
                return myPrivateField;
            }
            set
            {
                myPrivateField = value;
            }
        }
        public string FullName
        { // property example: 
            //cant set it directly
            // typically pascal case
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        //constructor: runs every time a new student is created
        public Student(string first, string last, int en = 100)
        {
            FirstName = first;
            LastName = last; 
            energy = en;
            myPrivateField = "not cool";
            Console.WriteLine($"New student created!");
        }

        
        //optional override to see useful info!
        public override string ToString()
        {
            return $"{FullName} has {energy} energy";
        }
    }
}
