using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6_NS
{
    class Lion : Cat
    {
        
        public bool hunt { get; set; }

        public Lion(string name = "Leo", string sex = "female", string food = "Gazelle", int age = 4, bool sleep = false)
        {
            this.Name = name;
            this.Sex = sex;
            this.Food = food;
            this.Sleep = sleep;
            this.Age = age;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Name: {0} \nSex: {1} \nType of food: {2} \nAge: {3}", Name, Sex, Food, Age);
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says ROOOOARRR!!");
        }
      
        public void GoHunt()
        {
            if (hunt == true)
            {
                Console.WriteLine($"{Name} is hunting a {Food} for food");
            }
            else
            {
                Console.WriteLine("I'm not hungry!");
            }
        }
    }
}
