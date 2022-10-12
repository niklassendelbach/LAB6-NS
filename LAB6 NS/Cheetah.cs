using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6_NS
{
    
    class Cheetah : Cat
    {
        private int ultraSpeed = 130;
        public int UltraSpeed { get; }
        public Cheetah(string name = "Speedy Cat", string sex = "Male", string food = "Gnu", int age = 3, bool sleep = false)
        {
            this.Name = name;
            this.Sex = sex;
            this.Food = food;
            this.Sleep = sleep;
            this.Age = age;
        }
        public override string GetSpeed()
        {
            string mySpeed = "A regular cat might be fast, but I can run " + ultraSpeed + "km/h!";
            return mySpeed;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Name: {0} \nSex: {1} \nType of food: {2} \nAge: {3}", Name, Sex, Food, Age);
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says roooooarrrr!!");
        }
    }
}
