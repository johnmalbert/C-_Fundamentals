using System;

namespace Human
{
    class Wizard : Human
    {
        public Wizard(string n) : base(n)
        {
            Health = 50;
            Intellegence = 25;
            Console.WriteLine($"New Wizard created named {n}!");
        }
        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target)
        {
            int intelDmg = 5 * Intellegence;
            target.Health -= intelDmg;
            Health += intelDmg;
            Console.WriteLine($"{target.name} was attacked by {name}! {target.name} lost {intelDmg} health and now has a health of {target.Health}. Meanwhile, {name}'s health increased by {intelDmg}");
            return target.Health;
        }
        //Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal(Human target)
        {
            int healAmt = 10 * Intellegence;
            target.Health += healAmt;
            Console.WriteLine($"{target.name} was healed by Wizard {name}. {target.name} now has a health of {target.Health}.");
            return target.Health;
        }
    }
}