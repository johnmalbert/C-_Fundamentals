﻿using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####################################################################");
            Human Bob = new Human("Bob");
            Human Jerry = new Human("Jerry", 5, 3, 3, 110);
            Console.WriteLine("New Humans Bob and Jerry Created!");
            Ninja n = new Ninja("Mike");
            Wizard gandalf = new Wizard("Gandalf");
            Samurai sally = new Samurai("Sally");
            Console.WriteLine("####################################################################");
            Jerry.Attack(n);
            gandalf.Attack(Bob);
            Console.WriteLine("####################################################################");
            gandalf.Heal(Bob);
            Console.WriteLine("####################################################################");
            n.Steal(gandalf);
            n.Steal(gandalf);
            Console.WriteLine("####################################################################");
            sally.Meditate();
            Console.WriteLine("####################################################################");
            sally.Attack(n);
            sally.Attack(n);
            sally.Attack(n);
            Console.WriteLine("####################################################################");
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
            set { health = value; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string Name) 
        {
            name = Name;
            Strength = 3;
            Intellegence = 3;
            Dexterity = 3;
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
        public virtual int Attack(Human target)
        {
            int attackStrength = 5 * Strength;
            target.Health -= attackStrength;
            Console.WriteLine($"{target.name} was attacked by {this.name}! His health was decreased by {attackStrength}");
            return target.Health;
        }
    }
}
