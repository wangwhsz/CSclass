using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS17_多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dg1 = new Dog();
            Animal cat = new Cat();
            // Cat cat1 = new Animal();
            cat.CName = "wangcai";
            dg1.CName = "虎子";
            dg1.Shout();
            cat.Shout();
            Console.WriteLine();
            
        }
    }
}
