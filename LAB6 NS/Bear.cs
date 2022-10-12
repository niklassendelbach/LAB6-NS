using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6_NS
{
    class Bear : Animal
    {
        private int cubs = 3;
        public int Cubs 
        { 
            get
            {
                return cubs;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Value cant be lower than 0");
                }  
                else
                {
                    cubs = value;
                }
            }
        }
        public Bear(string name = "Björne-Lisa", string sex = "Female", string food = "Blueberries", bool sleep = true, int age = 10)
        {
            this.Name = name;
            this.Sex = sex;
            this.Food = food;
            this.Sleep = sleep;
            this.Age = age;   
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Name: {0} \nSex: {1} \nType of food: {2} \nAge: {3}  \nCubs: {4}", Name, Sex, Food, Age, Cubs);
        }
        
        public string NumCubs()
        {
            string cubs = "Numer of cubs: " + Cubs;
            return cubs;
        }
        public override string Eating()
        {
            string eating = Name + " is eating " + Food;
            return eating;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is saying BJÖÖÖÖÖÖRN!");
        }
        public override string Sleeping()
        {
            if (Sleep == true)
            {
                string sleep = Name + " is hibernating!";
                return sleep;

            }
            else
            {
                string awake = "It's summer, I'm up!";
                return awake;
            }
        }
    }
}
