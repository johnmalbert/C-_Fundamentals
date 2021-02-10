using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    interface IConsumable
    {
        string Name { get; set; }
        int Calories { get; set; }
        bool IsSpicy { get; set; }
        bool IsSweet { get; set; }
        string GetInfo();
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create food instance
            Console.WriteLine("Building a buffet.");
            Console.WriteLine("######################################################");
            Console.WriteLine("A Sweet Tooth has entered the buffet. ");
            Buffet buff = new Buffet();

            // create a new ninja
            SweetTooth john = new SweetTooth();
            SpiceHound vesper = new SpiceHound();
            while (john.IsFull == false)
            {
                john.Consume(buff.Serve());
            }
            Console.WriteLine("######################################################");
            Console.WriteLine("A Spice Hound has entered the buffet. ");
            while (vesper.IsFull == false)
            {
                vesper.Consume(buff.Serve());
            }
            Console.WriteLine("######################################################");
            if (john.ConsumptionHistory.Count > vesper.ConsumptionHistory.Count)
            {
                Console.WriteLine($"The Sweet Tooth consumed more items that the Spice Hound, with a total of {john.ConsumptionHistory.Count}!");
            }
            else if (john.ConsumptionHistory.Count < vesper.ConsumptionHistory.Count)
            {
                Console.WriteLine($"The Spice Hound consumed more items that the Sweet Tooth, with a total of {vesper.ConsumptionHistory.Count}!");
            }
            else
            {
                Console.WriteLine($"It's a tie, the Spice Hound and the Sweet Tooth both consumed {john.ConsumptionHistory.Count} items!");
            }

        }
    }
    class Food : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cals, bool spice, bool sweet)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spice;
            IsSweet = sweet;
            // Console.WriteLine($"{Name} item created!");
        }
        public string GetInfo()
        {
            return $"Food: {Name} \tCalories: {Calories} \t Spicy: {IsSpicy} \t Sweet: {IsSweet}";
        }
    }
    class Drink : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        // Add a constructor method
        public Drink(string name, int cals, bool spice)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spice;
            IsSweet = true;
        }
        // Implement a GetInfo Method
        public string GetInfo()
        {
            return $"Drink: {Name} \tCalories: {Calories} \tSpicy? {IsSpicy} \tSweet? {IsSweet}";
        }
    }
    class Buffet
    {
        public List<IConsumable> Menu;
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Sweet and Sour Chicken", 500, true, true),
                new Food("Kung Pao Chicken", 400, true, false),
                new Food("Potstickers", 200, false, false),
                new Food("Manapua", 400, false, true),
                new Food("Spam Musubi", 350, false, false),
                new Food("Poke Bowl", 650, true, true),
                new Food("Crab Rangoon", 250, false, true),
                new Drink("Coca-Cola", 200, false),
                new Drink("Sprite", 100, false),
                new Drink("Bloody Mary", 300, true),
            };
            // Console.WriteLine("Buffet Created.");
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            int menuItem = rand.Next(0, Menu.Count);
            return Menu[menuItem];
        }
    }
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;

        // add a constructor
        public Ninja()
        {
            // new ninja with calorie intake of 0 and FoodHistory list
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
            // Console.WriteLine($"New Ninja Created named {Name}");
        }

        // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
        public abstract bool IsFull { get; }
        public abstract void Consume(IConsumable item);

    }
    class SweetTooth : Ninja
    {
        //Make a child class of Ninja, for a SweetTooth. A SweetTooth should be "full" at 1500 calories.
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1500)
                {
                    return true;
                }
                return false;
            }

        }

        //constructor:
        public SweetTooth()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine("Sorry pal, you're obese. Go work out or something.");
            }
            else
            {
                // adds calorie value to ninja's total calorieIntake
                calorieIntake += item.Calories;
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }
                // adds the randomly selected Food object to ninja's FoodHistory list
                ConsumptionHistory.Add(item);
                // writes the Food's Name - and if it is spicy/sweet to the console
                Console.WriteLine(item.GetInfo());
                Console.WriteLine($"SweetTooth has now consumed {calorieIntake} calories");
            }
        }

    }
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                return false;
            }

        }

        //constructor:
        public SpiceHound()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine("Sorry Spice Hound, you're full. Go work it off and take some tums. ");
            }
            else
            {
                calorieIntake += item.Calories;
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
                Console.WriteLine($"Spice Hound has now consumed {calorieIntake} calories.");
            }
        }
    }
}
