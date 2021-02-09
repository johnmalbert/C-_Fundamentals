using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Bob = new Human("Bob");
            Human Jerry = new Human("Jerry", 20, 100, 100, 110);
            Console.WriteLine("Bob and Jerry Created.");
            Console.WriteLine(Bob.Attack(Jerry));
            Console.WriteLine(Bob.Attack(Jerry));
            Console.WriteLine(Jerry.Attack(Bob));
            Console.WriteLine(Jerry.Attack(Bob));
        }
    }
    class Human
    {
        //Fields for Human
        public string name;
        public int Strength;
        public int Intellegence;
        public int Dexterity;
        private int health;

        //getter to access health data
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string Name) 
        {
            name = Name;
            Strength = 10;
            Intellegence = 90;
            Dexterity = 80;
            health = 100;
        }

        public Human(string Name, int Str, int Intel, int Dext, int heal)
        {
            name = Name;
            Strength = Str;
            Intellegence = Intel;
            Dexterity = Dext;
            health = heal;
        }

        //build attack method
        public int Attack(Human target)
        {
            health -= this.Strength;
            Console.WriteLine($"{target.name} was attacked by {this.name}! His health was decreased by {this.Strength}");
            return Health;
        }
    }
}
