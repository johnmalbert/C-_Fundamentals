using System;

namespace Human
{
    class Ninja : Human
    {
        //constructor
        public Ninja(string n) : base(n)
        {
            //Ninja should have a default dexterity of 175
            Dexterity = 175;
            Console.WriteLine($"New Ninja created named {n}!");
        }

        //Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack(Human target)
        {
            int attackStrength = 5 * Dexterity;
            Random rand = new Random();
            if(rand.Next(6) > 4)
            {
                attackStrength += 10;
            }
            target.Health -= attackStrength;
            Console.WriteLine($"{target.name} was attacked by {name}! His health was decreased by {attackStrength}");
            return target.Health;
        }
        //Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"Ninja {name} stole 5 health points from {target.name}. {name} now has {Health} health and {target.name} now has {target.Health} health.");
            return Health;
        }
    }
}