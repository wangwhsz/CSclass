using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS18_抽象
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            // todo
            dog.Shout();
            cat.Shout();
        }
    }
}