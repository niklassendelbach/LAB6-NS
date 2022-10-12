using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6_NS
{
    class Cat : Animal
    { 
        private int speed = 10;
        public int Speed
        { 
            get
            {
                return speed;
            }
        }
        public Cat(string name = "Niklas", string sex = "Male", string food = "Burgers", int age = 34, bool sleep = false)
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
        public virtual string GetSpeed()
        {
            string mySpeed = "My speed is " + speed + "!" + " I'm quick like a cat!";
            return mySpeed;
        }
        public override string Eating()
        {
            string eating = Name + " is eating " + Food;
            return eating;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says MJAAAAU!!");
        }
        public override string Sleeping()
        {
            if (Sleep == true)
            {
                string sleep = Name + " is sleeping!";
                return sleep;
                
            }
            else
            {
                string awake = Name + " I'm not tired!";
                return awake;
            }
        }
    }
}
