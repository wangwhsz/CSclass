using System;

namespace CS17_多态
{
    public class Cat:Animal
    {
        public Cat() : base("")
        {

        }

        public override void Shout()
        {
            Console.WriteLine("miao");
        }
    }
}