using System;

namespace CS17_多态
{
    public class Animal
    {
        private string cName;

        public string CName
        {
            get => cName;
            set => cName = value;
        }
        public Animal(string cName)
        {
            this.cName = cName;
        }
        public virtual void Shout()
        {
            Console.WriteLine("动物叫");
        }
    }
}