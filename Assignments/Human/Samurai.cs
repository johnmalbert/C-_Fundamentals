using System;

namespace Human
{
    class Samurai : Human
    {
        public Samurai(string n) : base(n)
        {
            Health = 200;
            Console.WriteLine($"New Samurai created named {n}!");
        }
        public int Meditate()
        {
            Health = 200;
            Console.WriteLine($"Samurai {name} has meditated and now has a health of {Health}");
            return Health;
        }
        //Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.Health < 50)
            {
                Console.WriteLine($"{target.name} was attacked by {name}. Because he had a health less than 50, {name} wiped him out.");
                target.Health = 0;
            }
            else
            {
                Console.WriteLine($"{target.name} was attacked by {name}. {target.name} now has a health of {target.Health}.");
            }
            return target.Health;
        }
    }
}