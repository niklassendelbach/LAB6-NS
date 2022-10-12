using System;

namespace LAB6_NS
{
    class Program
    {
        static void Main(string[] args)
        {
            // NIKLAS SENDELBACH NET 22

            Cat cat = new Cat("Tova", "Female", "Catfood", 12, true);
            cat.PrintInfo();
            cat.MakeSound();
            Console.WriteLine(cat.GetSpeed());
            Console.WriteLine("**************************************************");
            Monkey monkey = new Monkey();
            monkey.Friendly = false;
            monkey.CheckFriendly();
            monkey.MakeSound();
            Console.WriteLine("**************************************************");
            Bear bear = new Bear();
            bear.Cubs = 1;
            bear.PrintInfo();
            bear.MakeSound();
            Console.WriteLine("**************************************************");
            Lion lion = new Lion();
            lion.MakeSound();
            lion.hunt = false;
            lion.GoHunt();
            Console.WriteLine("**************************************************");
            Cheetah leopard = new Cheetah();
            leopard.MakeSound();
            Console.WriteLine(leopard.GetSpeed());  

        }
    }
}
