using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            // create food instance
            Console.WriteLine("Building a buffet.");
            Console.WriteLine("######################################################");
            Buffet buff = new Buffet();

            // create a new ninja
            Ninja john = new Ninja("John");
            while(john.IsFull == false)
            {
                john.Eat(buff.Serve());
            }
            Console.WriteLine("######################################################");

        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cals, bool spice, bool sweet)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spice;
            IsSweet = sweet;
            // Console.WriteLine($"{Name} item created!");
        }
        public override string ToString()
        {
            return $"Food: {Name} \t Calories: {Calories} \t Spicy: {IsSpicy} \t Sweet: {IsSweet}";
        }
    }
    class Buffet
    {
        public List<Food> Menu;
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Sweet and Sour Chicken", 500, true, true),
                new Food("Kung Pao Chicken", 400, true, false),
                new Food("Potstickers", 200, false, false),
                new Food("Manapua", 400, false, true),
                new Food("Spam Musubi", 350, false, false),
                new Food("Poke Bowl", 650, true, true),
                new Food("Crab Rangoon", 250, false, true),
            };
            // Console.WriteLine("Buffet Created.");
        }
     
        public Food Serve()
        {
            Random rand = new Random();
            int menuItem = rand.Next(0,7);
            return Menu[menuItem];
        }
    }
    class Ninja
    {
        public string Name;
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja(string name)
        {
            // new ninja with calorie intake of 0 and FoodHistory list
            Name = name;
            calorieIntake = 0;
            FoodHistory = new List<Food>();
            // Console.WriteLine($"New Ninja Created named {Name}");
        }
        
        // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
        public bool IsFull
        {
            get
            {
                int cals = 0;
                // figure out total cal intake so far
                foreach(var food in FoodHistory)
                {
                    cals += food.Calories;
                }
                if(cals >= 1200)
                {
                    Console.WriteLine("Sorry pal, you're obese. Go work out or something.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if(this.IsFull)
            {
                Console.WriteLine("Sorry pal, you're obese. Go work out or something.");
            }
            else
            {
                // adds calorie value to ninja's total calorieIntake
                this.calorieIntake += item.Calories;
                // adds the randomly selected Food object to ninja's FoodHistory list
                this.FoodHistory.Add(item);
                // writes the Food's Name - and if it is spicy/sweet to the console
                Console.WriteLine($"{this.Name} is eating {item.Name}, Spicy you ask? {item.IsSpicy}. Sweet you ask? {item.IsSweet}");
                Console.WriteLine($"Ninja has now consumed {this.calorieIntake} calories");
            }
        }
    }
}
