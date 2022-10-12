using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6_NS
{
    public abstract class Animal
    {
        public string Name;
        public string Sex;
        public string Food;
        public bool Sleep;
        public int Age;
   
        public abstract string Eating();
        public abstract string Sleeping();
        public abstract void MakeSound();
        public abstract void PrintInfo();
        
    }
}
