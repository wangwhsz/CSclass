using System;

namespace CS17_多态
{
    public class Dog:Animal
    {
        public Dog() : base("")
        {
            
        }

        public override void Shout()
        {
            Console.WriteLine("wang");
        }
    }
}