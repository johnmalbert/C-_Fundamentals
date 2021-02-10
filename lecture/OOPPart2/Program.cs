using System;
using System.Collections.Generic;

namespace OOPPart2
{
    interface INameable
    {
        //like a blueprint for our class.
        //this is a method signature.
        public void sayMyName(); //make sure that we can say the name
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ermes = new Student("Ermes", "Natale");
            ermes.sayMyName();
            ermes.addCourse(new Course("Python", "Ed Im"));
            ermes.addCourse(new Course("C#", "Morley"));

            Console.WriteLine(ermes.Courses.Count);
        }
    }
    public class Dog : INameable
    {
        public string Name {get;set;}
        public Dog(string n)
        {
            Name = n;
        }
        public void sayMyName()
        {
            Console.WriteLine("I'm a dog named ", Name);
        }
    }

    public class Human : INameable
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        //constructor:
        public Human(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public void sayMyName()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
    //Student inheritance 

    public class Student : Human
    {
        public List<Course> Courses {get; set;} //method
        public Student(string fName, string lName) : base(fName, lName)
        {   //constructor
            Courses = new List<Course>();
        }

        public List<Course> addCourse(Course c) // method
        {
            Courses.Add(c);
            return Courses;
        }
    }

    public class Course
    {
        public string Language {get;set;}
        public string Teacher {get;set;}
        
        public Course(string lang, string teach)
        {
            Language = lang;
            Teacher = teach;
        }
    }
}
