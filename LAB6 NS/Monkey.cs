using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6_NS
{
    class Monkey : Animal
    {
        public bool Friendly { get; set; }
        public Monkey(string name = "King Louie", string sex = "Male", string food = "Bananas", bool sleep = false, int age = 30)
        {
            this.Name = name;
            this.Sex = sex;
            this.Food = food;
            this.Sleep = sleep;
            this.Age = age;
            
        }
        public void CheckFriendly()
        {
            if (Friendly == true)
            {
                Console.WriteLine($"{Name} can be with the other monkeys!");
            }
            else
            {
                Console.WriteLine($"{Name} needs to be alone");
            }
        }
      
        public override void PrintInfo()
        {
            Console.WriteLine("Name: {0} \nSex: {1} \nType of food: {2} \nAge: {3}", Name, Sex, Food, Age);
        }
        public override string Eating()
        {
            string eating = Name + " is eating " + Food;
            return eating;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says ooOooAAaaaOoooAAaa!!!");
        }

        public override string Sleeping()
        {
            if (Sleep == true)
            {
                string sleep = Name + " is sleeping in the tree!";
                return sleep;

            }
            else
            {
                string awake = Name + " says: You're sleeping!";
                return awake;
            }
        }
    }
}
