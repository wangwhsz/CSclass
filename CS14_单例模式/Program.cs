using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS14_单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person psn = new Person("1asd",1);
            Person psn = Person.GetPerson("zhangsan", 24);
            Person psn2 = Person.GetPerson("dierge",26)
        }
    }
}
